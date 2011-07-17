
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MacDev.PlistEditor
{
	public partial class DocumentTypeWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox3;
		private global::MonoDevelop.MacDev.PlistEditor.ImageChooser imagechooser1;
		private global::Gtk.Table table1;
		private global::Gtk.Entry entryContentTypes;
		private global::Gtk.Entry entryName;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewIcons;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Button buttonAdd;
		private global::Gtk.Button buttonRemove;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Expander expander1;
		private global::MonoDevelop.MacDev.PlistEditor.CustomPropertiesWidget custompropertiesWidget;
		private global::Gtk.Label GtkLabel2;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.MacDev.PlistEditor.DocumentTypeWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.MacDev.PlistEditor.DocumentTypeWidget";
			// Container child MonoDevelop.MacDev.PlistEditor.DocumentTypeWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.imagechooser1 = new global::MonoDevelop.MacDev.PlistEditor.ImageChooser ();
			this.imagechooser1.Name = "imagechooser1";
			this.imagechooser1.Label = null;
			this.vbox3.Add (this.imagechooser1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.imagechooser1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryContentTypes = new global::Gtk.Entry ();
			this.entryContentTypes.CanFocus = true;
			this.entryContentTypes.Name = "entryContentTypes";
			this.entryContentTypes.IsEditable = true;
			this.entryContentTypes.InvisibleChar = '●';
			this.table1.Add (this.entryContentTypes);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryContentTypes]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewIcons = new global::Gtk.TreeView ();
			this.treeviewIcons.CanFocus = true;
			this.treeviewIcons.Name = "treeviewIcons";
			this.GtkScrolledWindow.Add (this.treeviewIcons);
			this.table1.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseStock = true;
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = "gtk-add";
			this.hbox2.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonAdd]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonRemove = new global::Gtk.Button ();
			this.buttonRemove.CanFocus = true;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.UseStock = true;
			this.buttonRemove.UseUnderline = true;
			this.buttonRemove.Label = "gtk-remove";
			this.hbox2.Add (this.buttonRemove);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonRemove]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Name:");
			this.label1.UseMarkup = true;
			this.label1.UseUnderline = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("_Type:");
			this.label2.UseMarkup = true;
			this.label2.UseUnderline = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("_Icons:");
			this.label3.UseMarkup = true;
			this.label3.UseUnderline = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.table1]));
			w13.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.expander1 = new global::Gtk.Expander (null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			this.expander1.Expanded = true;
			// Container child expander1.Gtk.Container+ContainerChild
			this.custompropertiesWidget = new global::MonoDevelop.MacDev.PlistEditor.CustomPropertiesWidget ();
			this.custompropertiesWidget.Events = ((global::Gdk.EventMask)(256));
			this.custompropertiesWidget.Name = "custompropertiesWidget";
			this.expander1.Add (this.custompropertiesWidget);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("Additional document type properties");
			this.GtkLabel2.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel2;
			this.vbox1.Add (this.expander1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.expander1]));
			w16.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.imagechooser1.Hide ();
			this.Show ();
		}
	}
}
