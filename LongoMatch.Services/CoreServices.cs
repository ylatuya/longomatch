// 
//  Copyright (C) 2011 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using LongoMatch.Core.Interfaces;
using VAS.Core;
using VAS.Core.Common;
using VAS.Core.Events;
using VAS.Core.Interfaces;
using VAS.Core.Interfaces.GUI;
using VAS.Core.Interfaces.Multimedia;
using VAS.Services;
using Constants = LongoMatch.Core.Common.Constants;
using LMCommon = LongoMatch.Core.Common;
using Catalog = LongoMatch.Core.Catalog;


#if OSTYPE_WINDOWS
using System.Runtime.InteropServices;
#endif

namespace LongoMatch.Services
{
	public class CoreServices
	{
		static DataBaseManager dbManager;
		static EventsManager eManager;
		static HotKeysManager hkManager;
		static RenderingJobsManager videoRenderer;
		static ProjectsManager projectsManager;
		static PlaylistManager plManager;
		internal static ToolsManager toolsManager;
		static TemplatesService ts;
		static List<IService> services = new List<IService> ();
		public static IProjectsImporter ProjectsImporter;

		#if OSTYPE_WINDOWS
		[DllImport("libglib-2.0-0.dll") /* willfully unmapped */ ]
		static extern bool g_setenv (String env, String val, bool overwrite);
		#endif
		public static void Init ()
		{
			Log.Debugging = Debugging;

			App.Init ();
			FillVersion ();

			/* Check default folders */
			CheckDirs ();

			/* Redirects logs to a file */
			Log.SetLogFile (App.Current.LogFile);
			Log.Information ("Starting " + Constants.SOFTWARE_NAME);
			Log.Information (Utils.SysInfo);

			/* Load user config */
			//Config.Load ();

			if (App.Current.Config.Lang != null) {
				Environment.SetEnvironmentVariable ("LANGUAGE", App.Current.Config.Lang.Replace ("-", "_"));
#if OSTYPE_WINDOWS
				g_setenv ("LANGUAGE", Config.Lang.Replace ("-", "_"), true);
#endif
			}
			InitTranslations ();

			/* Fill up the descriptions again after initializing the translations */
			App.Current.Config.Hotkeys.FillActionsDescriptions ();
		}

		static void FillVersion ()
		{
			Assembly assembly = Assembly.GetExecutingAssembly ();
			FileVersionInfo info = FileVersionInfo.GetVersionInfo (assembly.Location); 
			App.Current.Version = assembly.GetName ().Version;
			App.Current.BuildVersion = info.ProductVersion;
		}

		public static void InitTranslations ()
		{
			string localesDir = App.Current.RelativeToPrefix ("share/locale");

			if (!Directory.Exists (localesDir)) {
				var cerbero_prefix = Environment.GetEnvironmentVariable ("CERBERO_PREFIX");
				if (cerbero_prefix != null) {
					localesDir = Path.Combine (cerbero_prefix, "share", "locale");
				} else {
					Log.ErrorFormat ("'{0}' does not exist. This looks like an uninstalled execution." +
					"Define CERBERO_PREFIX.", localesDir);
				}
			}
			/* Init internationalization support */
			Catalog.Init (Constants.SOFTWARE_NAME.ToLower (), localesDir);
		}

		public static void Start (IGUIToolkit guiToolkit, IMultimediaToolkit multimediaToolkit)
		{
			App.Current.MultimediaToolkit = multimediaToolkit;
			App.Current.GUIToolkit = guiToolkit;
			App.Current.EventsBroker = new LongoMatch.Core.Common.EventsBroker ();
			App.Current.EventsAggregator = new EventsAggregator ();
			((LMCommon.EventsBroker)App.Current.EventsBroker).QuitApplicationEvent += HandleQuitApplicationEvent;
			RegisterServices (guiToolkit, multimediaToolkit);
			StartServices ();
		}

		public static void Stop ()
		{
			StopServices ();
			services.Clear ();
		}

		public static void RegisterService (IService service)
		{
			Log.InformationFormat ("Registering service {0}", service.Name);
			services.Add (service);
		}

		public static void RegisterServices (IGUIToolkit guiToolkit, IMultimediaToolkit multimediaToolkit)
		{
			/* Start DB services */
			dbManager = new DataBaseManager ();
			RegisterService (dbManager);

			ts = new TemplatesService ();
			RegisterService (ts);

			/* Start the rendering jobs manager */
			videoRenderer = new RenderingJobsManager ();
			RegisterService (videoRenderer);

			projectsManager = new ProjectsManager ();
			RegisterService (projectsManager);

			/* State the tools manager */
			toolsManager = new ToolsManager ();
			RegisterService (toolsManager);
			ProjectsImporter = toolsManager;

			/* Start the events manager */
			eManager = new EventsManager ();
			RegisterService (eManager);

			RegisterService (new CoreEventsManager ());

			/* Start the hotkeys manager */
			hkManager = new HotKeysManager ();
			RegisterService (hkManager);

			/* Start playlists hotkeys manager */
			plManager = new PlaylistManager ();
			RegisterService (plManager);
		}

		public static void StartServices ()
		{
			foreach (IService service in services.OrderBy (s => s.Level)) {
				if (service.Start ()) {
					Log.InformationFormat ("Started service {0} successfully", service.Name);
				} else {
					Log.InformationFormat ("Failed starting service {0}", service.Name);
				}
			}
		}

		public static void StopServices ()
		{
			foreach (IService service in services.OrderByDescending (s => s.Level)) {
				if (service.Stop ()) {
					Log.InformationFormat ("Stopped service {0} successfully", service.Name);
				} else {
					Log.InformationFormat ("Failed stopping service {0}", service.Name);
				}
			}
		}

		public static void CheckDirs ()
		{
			if (!System.IO.Directory.Exists (App.Current.HomeDir))
				System.IO.Directory.CreateDirectory (App.Current.HomeDir);
			if (!System.IO.Directory.Exists (App.Current.SnapshotsDir))
				System.IO.Directory.CreateDirectory (App.Current.SnapshotsDir);
			if (!System.IO.Directory.Exists (App.Current.PlayListDir))
				System.IO.Directory.CreateDirectory (App.Current.PlayListDir);
			if (!System.IO.Directory.Exists (App.Current.DBDir))
				System.IO.Directory.CreateDirectory (App.Current.DBDir);
			if (!System.IO.Directory.Exists (App.Current.VideosDir))
				System.IO.Directory.CreateDirectory (App.Current.VideosDir);
			if (!System.IO.Directory.Exists (App.Current.TempVideosDir))
				System.IO.Directory.CreateDirectory (App.Current.TempVideosDir);
		}

		static bool? debugging = null;

		public static bool Debugging {
			get {
				#if DEBUG
				return true;
				#else
				if (debugging == null) {
					debugging = EnvironmentIsSet ("LGM_DEBUG");
				}
				return debugging.Value;
				#endif
			}
			set {
				debugging = value;
				Log.Debugging = Debugging;
			}
		}

		public static bool EnvironmentIsSet (string env)
		{
			return !String.IsNullOrEmpty (Environment.GetEnvironmentVariable (env));
		}

		static void HandleQuitApplicationEvent ()
		{
			if (videoRenderer.PendingJobs.Count > 0) {
				string msg = Catalog.GetString ("A rendering job is running in the background. Do you really want to quit?");
				if (!App.Current.GUIToolkit.QuestionMessage (msg, null).Result) {
					return;
				}
			}
			App.Current.GUIToolkit.Quit ();
		}
	}
}
