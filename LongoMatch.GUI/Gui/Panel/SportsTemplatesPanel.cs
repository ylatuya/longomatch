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
using System;
using LongoMatch.Interfaces.GUI;
using Gtk;
using System.Collections.Generic;
using LongoMatch.Store.Templates;
using LongoMatch.Interfaces;
using LongoMatch.Handlers;
using Gdk;
using Mono.Unix;
using LongoMatch.Gui.Helpers;
using LongoMatch.Gui.Dialog;
using LongoMatch.Common;

namespace LongoMatch.Gui.Panel
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class SportsTemplatesPanel : Gtk.Bin, IPanel
	{
		public event BackEventHandle BackEvent;

		ListStore templates;
		List<string> selectedTemplate;
		Categories loadedTemplate;
		
		ICategoriesTemplatesProvider provider;
		
		public SportsTemplatesPanel ()
		{
			this.Build ();
			provider = Config.CategoriesTemplatesProvider;
			logoimage.Pixbuf = IconTheme.Default.LoadIcon ("longomatch", 80, IconLookupFlags.ForceSvg);
			
			templates = new ListStore (typeof(Pixbuf), typeof(string));
			
			sporttemplatestreeview.Model = templates;
			sporttemplatestreeview.Model = templates;
			sporttemplatestreeview.HeadersVisible = false;
			sporttemplatestreeview.AppendColumn ("Icon", new CellRendererPixbuf (), "pixbuf", 0); 
			sporttemplatestreeview.AppendColumn ("Text", new CellRendererText (), "text", 1); 
			sporttemplatestreeview.SearchColumn = 1;
			sporttemplatestreeview.EnableGridLines = TreeViewGridLines.None;
			sporttemplatestreeview.CursorChanged += HandleSelectionChanged;
			
			templatesvbox.WidthRequest = 280;
			
			buttonswidget.Sensitive = false;
			buttonswidget.Mode = TagMode.Edit;
			newtemplatebutton.Visible = true;
			deletetemplatebutton.Visible = false;
			
			selectedTemplate = new List<string>();
			newtemplatebutton.Clicked += HandleNewTeamClicked;
			deletetemplatebutton.Clicked += HandleDeleteTeamClicked;
			savetemplatebutton.Clicked += (sender, e) => Save ();
			backrectbutton.Clicked += (sender, o) => {
				if (BackEvent != null)
					BackEvent();
			};
			Load (null);
		}
		
		void Load (string templateName) {
			TreeIter templateIter = TreeIter.Zero;
			bool first = true;
			
			templates.Clear ();
			foreach (Categories template in provider.Templates) {
				Pixbuf img;
				TreeIter iter;
				
				if (template.Image != null)
					img = template.Image.Value;
				else
					img = IconTheme.Default.LoadIcon ("longomatch", 20, IconLookupFlags.ForceSvg);
					
				iter = templates.AppendValues (img, template.Name);
				if (first || template.Name == templateName) {
					templateIter = iter;
				}
				first = false;
			}
			if (templates.IterIsValid (templateIter)) {
				sporttemplatestreeview.Selection.SelectIter (templateIter);
				HandleSelectionChanged (null, null);
			}
		}
		
		void Save () {
			if (loadedTemplate != null && buttonswidget.Edited) {
				string msg = Catalog.GetString ("Do you want to save the current template");
			    if (Config.GUIToolkit.QuestionMessage (msg, null, this)) {
					provider.Update (loadedTemplate);
			    }
			}
		}
		
		void LoadTemplate (string templateName) {
			Save ();
			
			try {
				loadedTemplate = provider.Load (templateName);
				buttonswidget.Template = loadedTemplate;
			} catch (Exception ex) {
				Log.Exception (ex);
				GUIToolkit.Instance.ErrorMessage (Catalog.GetString ("Could not load template"));
				return;
			}
		}
		
		void HandleSelectionChanged (object sender, EventArgs e)
		{
			TreeIter iter;
			TreePath[] pathArray;
			
			selectedTemplate.Clear ();

			pathArray = sporttemplatestreeview.Selection.GetSelectedRows ();
			for(int i=0; i< pathArray.Length; i++) {
				sporttemplatestreeview.Model.GetIterFromString (out iter, pathArray[i].ToString());
				selectedTemplate.Add (sporttemplatestreeview.Model.GetValue (iter, 1) as string);
			}
			
			deletetemplatebutton.Visible = selectedTemplate.Count >= 1;
			buttonswidget.Sensitive = true;
			
			if (selectedTemplate.Count == 1) {
				LoadTemplate (selectedTemplate[0]);
			}
		}
		
		void HandleDeleteTeamClicked (object sender, EventArgs e)
		{
			foreach (string teamName in selectedTemplate) {
				if (teamName == "default") {
					MessagesHelpers.ErrorMessage (this,
						Catalog.GetString ("The default template can't be deleted"));
					continue;
				}
				string msg = Catalog.GetString("Do you really want to delete the template: ") + teamName;
				if (MessagesHelpers.QuestionMessage (this, msg, null)) {
					provider.Delete (teamName);
				}
			}
			Load ("default");
		}

		void HandleNewTeamClicked (object sender, EventArgs e)
		{
			bool create = false;
			
			EntryDialog dialog = new EntryDialog();
			dialog.TransientFor = (Gtk.Window)this.Toplevel;
			dialog.ShowCount = true;
			dialog.Text = Catalog.GetString("New team");
			dialog.CountText = Catalog.GetString ("Categories:");
			dialog.AvailableTemplates = provider.TemplatesNames;
			
			while (dialog.Run() == (int)ResponseType.Ok) {
				if (dialog.Text == "") {
					MessagesHelpers.ErrorMessage (dialog, Catalog.GetString("The template name is empty."));
					continue;
				} else if (dialog.Text == "default") {
					MessagesHelpers.ErrorMessage (dialog, Catalog.GetString("The template can't be named 'default'."));
					continue;
				} else if(provider.Exists(dialog.Text)) {
					var msg = Catalog.GetString("The template already exists. " +
					                            "Do you want to overwrite it ?");
					if (MessagesHelpers.QuestionMessage (this, msg)) {
						create = true;
						break;
					}
				} else {
					create = true;
					break;
				}
			}
			
			if (create) {
				if (dialog.SelectedTemplate != null) {
					provider.Copy (dialog.SelectedTemplate, dialog.Text);
				} else {
					Categories template;
					template = Categories.DefaultTemplate (dialog.Count);
					template.Name = dialog.Text;
					provider.Save (template);
				}
				Load (dialog.Text);
			}
			dialog.Destroy();
		}
	}
}

