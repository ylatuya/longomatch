//
//  Copyright (C) 2014 Andoni Morales Alastruey
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
using Gtk;
using VAS.Core;
using VAS.Core.Store;
using VAS.Drawing;

namespace LongoMatch.Gui.Menus
{
	public class PeriodsMenu : Gtk.Menu
	{
		MenuItem additem, delitem;
		Timer timer;
		Time time;
		Project project;
		SelectionCanvas selectionCanvas;

		public PeriodsMenu ()
		{
			CreateMenu ();
		}

		public void ShowMenu (Project project, Timer timer, Time time,
							  SelectionCanvas selectionCanvas)
		{
			this.timer = timer;
			this.time = time;
			this.project = project;
			this.selectionCanvas = selectionCanvas;
			delitem.Visible = project != null && timer != null;
			delitem.Sensitive = project.Periods.Count > 1;
			Popup ();
		}

		void CreateMenu ()
		{
			additem = new MenuItem (Catalog.GetString ("Add period"));
			additem.Activated += (sender, e) => {
				string periodname = App.Current.Dialogs.QueryMessage (Catalog.GetString ("Period name"), null,
										(project.Periods.Count + 1).ToString (),
										null).Result;
				if (periodname != null) {
					project.Dashboard.GamePeriods.Add (periodname);
					Period p = new Period { Name = periodname };
					p.Nodes.Add (new TimeNode {
						Name = periodname,
						Start = new Time { TotalSeconds = time.TotalSeconds - 10 },
						Stop = new Time { TotalSeconds = time.TotalSeconds + 10 }
					});
					project.Periods.Add (p);
				}
			};
			Add (additem);
			delitem = new MenuItem (Catalog.GetString ("Delete period"));
			delitem.Activated += (sender, e) => {
				project.Periods.Remove (timer as Period);
			};
			Add (delitem);
			ShowAll ();
		}
	}
}
