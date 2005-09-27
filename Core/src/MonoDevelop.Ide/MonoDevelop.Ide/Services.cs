
using MonoDevelop.Core;
using MonoDevelop.Core.Execution;
using MonoDevelop.Core.Gui;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Documentation;
using MonoDevelop.Ide.Tasks;
using MonoDevelop.Projects;
using MonoDevelop.Projects.Parser;
using MonoDevelop.Projects.Gui;

namespace MonoDevelop.Ide
{
	internal class Services
	{
		static MessageService messageService;
		static DisplayBindingService displayBindingService;
		static ResourceService resourceService;
		static IStatusBarService statusBarService;
		static IconService icons;
		static MonodocService monodocService;
		static IDebuggingService debuggingService;
		static TaskService taskService;
		static IParserService parserService;
		static DispatchService dispatchService;
		static IProjectService projectService;
		static IFileService fileService;
	
		public static IFileService FileService {
			get {
				if (fileService == null)
					fileService = (IFileService) ServiceManager.GetService (typeof(IFileService));
				return fileService;
			}
		}

		public static IStatusBarService StatusBar {
			get {
				if (statusBarService == null)
					statusBarService = (IStatusBarService) ServiceManager.GetService (typeof(IStatusBarService));
				return statusBarService;
			}
		}

		public static MessageService MessageService {
			get {
				if (messageService == null)
					messageService = (MessageService) ServiceManager.GetService (typeof(MessageService));
				return messageService;
			}
		}

		internal static DisplayBindingService DisplayBindings {
			get {
				if (displayBindingService == null)
					displayBindingService = (DisplayBindingService) ServiceManager.GetService (typeof(DisplayBindingService));
				return displayBindingService;
			}
		}
	
		public static ResourceService Resources {
			get {
				if (resourceService == null)
					resourceService = (ResourceService) ServiceManager.GetService (typeof(ResourceService));
				return resourceService;
			}
		}
	
		public static IconService Icons {
			get {
				if (icons == null)
					icons = (IconService) ServiceManager.GetService (typeof(IconService));
				return icons;
			}
		}
	
		public static MonodocService Documentation {
			get {
				if (monodocService == null)
					monodocService = (MonodocService) ServiceManager.GetService (typeof(MonodocService));
				return monodocService;
			}
		}
	
		public static IDebuggingService DebuggingService {
			get {
				if (debuggingService == null)
					debuggingService = (IDebuggingService) ServiceManager.GetService (typeof(IDebuggingService));
				return debuggingService;
			}
		}
	
		public static TaskService TaskService {
			get {
				if (taskService == null)
					taskService = (TaskService) ServiceManager.GetService (typeof(TaskService));
				return taskService;
			}
		}
	
		public static IParserService ParserService {
			get {
				if (parserService == null)
					parserService = (IParserService) ServiceManager.GetService (typeof(IParserService));
				return parserService;
			}
		}
	
		public static DispatchService DispatchService {
			get {
				if (dispatchService == null)
					dispatchService = (DispatchService) ServiceManager.GetService (typeof(DispatchService));
				return dispatchService;
			}
		}
	
		public static IProjectService ProjectService {
			get {
				if (projectService == null)
					projectService = (IProjectService) ServiceManager.GetService (typeof(IProjectService));
				return projectService;
			}
		}
	}
}

