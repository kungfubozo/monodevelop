// 
// MacUpdater.cs
//  
// Author:
//       Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (c) 2009 Novell, Inc. (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using MonoDevelop.Core;
using MonoDevelop.Ide;

namespace MonoDevelop.Platform.Updater
{

	public enum UpdateLevel
	{
		Stable = 0,
		Beta = 1,
		Alpha = 2,
		Test = 3
	}
	
	public static class UpdateService
	{
		const int formatVersion = 1;
		const string updateAutoPropertyKey = "AppUpdater.CheckAutomatically";
		const string updateLevelKey = "AppUpdate.UpdateLevel";
		
		static UpdateInfo[] updateInfos;
		
		//FIXME: populate from an extension point
		public static UpdateInfo[] DefaultUpdateInfos {
			get {
				if (updateInfos == null) {
					var files = new string[] {
						"/Developer/MonoTouch/updateinfo",
						"/Developer/MonoTouch/Source/updateinfo",
						"/Library/Frameworks/Mono.framework/Versions/Current/updateinfo",
						"/Library/Frameworks/Mono.framework/Versions/Current/updateinfo.csdk",
						Path.GetDirectoryName (typeof (MacPlatform).Assembly.Location) + "/../../../updateinfo",
					}.Where (File.Exists);
					
					var list = new List<UpdateInfo> ();
					foreach (string file in files) {
						try {
							list.Add (UpdateInfo.FromFile (file));
						} catch (Exception ex) {
							LoggingService.LogError ("Error reading update info file '" + file + "'", ex);
						}
					}
					updateInfos = list.ToArray ();
				}
				
				return updateInfos;
			}
		}
		
		public static bool CheckAutomatically {
			get {
				return PropertyService.Get<bool> (updateAutoPropertyKey, true);
			}
			set {
				PropertyService.Set (updateAutoPropertyKey, value);
			}
		}
		
		public static UpdateLevel UpdateLevel {
			get {
				return PropertyService.Get<UpdateLevel> (updateLevelKey, UpdateLevel.Stable);
			}
			set {
				PropertyService.Set (updateLevelKey, value);
			}
		}
		
		public static void RunCheckDialog (bool automatic)
		{
			RunCheckDialog (DefaultUpdateInfos, automatic);
		}
		
		public static void RunCheckDialog (UpdateInfo[] updateInfos, bool automatic)
		{
			return; // Disable updates
			if (updateInfos == null || updateInfos.Length == 0 || (automatic && !CheckAutomatically))
				return;
			
			if (!automatic) {
				ShowUpdateDialog ();
				QueryUpdateServer (updateInfos, UpdateLevel, delegate (UpdateResult result) {
					ShowUpdateResult (result);
				});
			} else {
				QueryUpdateServer (updateInfos, UpdateLevel, delegate (UpdateResult result) {
					if (result.HasError || !result.HasUpdates)
						return;
					ShowUpdateDialog ();
					ShowUpdateResult (result);
				});
			}
		}
		
		#region Singleton dialog management. Methods are threadsafe, field is not
		
		static UpdateDialog visibleDialog;
		
		static void ShowUpdateDialog ()
		{
			return; // Disable updates
			Gtk.Application.Invoke (delegate {
				if (visibleDialog == null) {
					visibleDialog = new UpdateDialog ();
					MessageService.ShowCustomDialog (visibleDialog);
					visibleDialog = null;
				} else {
					visibleDialog.GdkWindow.Focus (0);
				}
			});
		}
		
		static void ShowUpdateResult (UpdateResult result)
		{
			Gtk.Application.Invoke (delegate {
				if (visibleDialog != null)
					visibleDialog.LoadResult (result);
			});
		}
			
		#endregion
		
		public static void QueryUpdateServer (UpdateInfo[] updateInfos, UpdateLevel level, Action<UpdateResult> callback)
		{
			if (updateInfos == null || updateInfos.Length == 0) {
				string error = GettextCatalog.GetString ("No updatable products detected");
				callback (new UpdateResult (null, level, error, null));
				return;
			}
			
			var query = new StringBuilder ("http://go-mono.com/macupdate/update?v=");
			query.Append (formatVersion);
			foreach (var info in updateInfos)
				query.AppendFormat ("&{0}={1}", info.AppId, info.VersionId);
			
			if (!string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("MONODEVELOP_UPDATER_TEST")))
				level = UpdateLevel.Test;
			
			if (level != UpdateLevel.Stable) {
				query.Append ("&level=");
				query.Append (level.ToString ().ToLower ());
			}
			
			if (Directory.Exists ("/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator4.0.sdk")) {
				query.Append ("&env=iphsdk4.0");
			}
			
			var request = (HttpWebRequest) WebRequest.Create (query.ToString ());
			
			//FIXME: use IfModifiedSince
			//request.IfModifiedSince = somevalue;
			
			request.BeginGetResponse (delegate (IAsyncResult ar) {
				ReceivedResponse (request, ar, level, callback);
			}, null);
		}
		
		static void ReceivedResponse (HttpWebRequest request, IAsyncResult ar, UpdateLevel level, Action<UpdateResult> callback)
		{
			List<Update> updates = null;
			string error = null;
			Exception errorDetail = null;
			
			try {
				using (var response = (HttpWebResponse) request.EndGetResponse (ar)) {
					var encoding = Encoding.GetEncoding (response.CharacterSet);
					using (var reader = new StreamReader (response.GetResponseStream(), encoding)) {
						var doc = System.Xml.Linq.XDocument.Load (reader);
						updates = (from x in doc.Root.Elements ("Application")
							let first = x.Elements ("Update").First ()
							select new Update () {
								Name = x.Attribute ("name").Value,
								Url = first.Attribute ("url").Value,
								Version = first.Attribute ("version").Value,
								Level = first.Attribute ("level") != null
									? (UpdateLevel)Enum.Parse (typeof(UpdateLevel), (string)first.Attribute ("level"))
									: UpdateLevel.Stable,
								Date = DateTime.Parse (first.Attribute ("date").Value),
								Releases = x.Elements ("Update").Select (y => new Release () {
									Version = y.Attribute ("version").Value,
									Date = DateTime.Parse (y.Attribute ("date").Value),
									Notes = y.Value
								}).ToList ()
							}).ToList ();
					}
				}
			} catch (Exception ex) {
				error = GettextCatalog.GetString ("Error retrieving update information");
				errorDetail = ex;
			}
			callback (new UpdateResult (updates, level, error, errorDetail));
		}
	}
}
