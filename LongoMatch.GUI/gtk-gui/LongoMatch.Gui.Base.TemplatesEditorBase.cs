
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Base
{
	public partial class TemplatesEditorBase
	{
		private global::Gtk.Notebook notebook;
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox mainbox;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.ScrolledWindow scrolledwindow;
		private global::Gtk.VBox vbox2;
		private global::Gtk.VBox upbox;
		private global::Gtk.Button newprevbutton;
		private global::Gtk.Button newafterbutton;
		private global::Gtk.Button removebutton;
		private global::Gtk.Button editbutton;
		private global::Gtk.Button exportbutton;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label label1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Base.TemplatesEditorBase
			global::Stetic.BinContainer.Attach (this);
			this.WidthRequest = 400;
			this.Name = "LongoMatch.Gui.Base.TemplatesEditorBase";
			// Container child LongoMatch.Gui.Base.TemplatesEditorBase.Gtk.Container+ContainerChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.mainbox = new global::Gtk.VBox ();
			this.mainbox.Name = "mainbox";
			this.mainbox.Spacing = 6;
			// Container child mainbox.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.scrolledwindow = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow.CanFocus = true;
			this.scrolledwindow.Name = "scrolledwindow";
			this.scrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
			w1.Add (this.scrolledwindow);
			this.scrolledwindow2.Add (w1);
			this.mainbox.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.mainbox [this.scrolledwindow2]));
			w4.Position = 0;
			this.hbox1.Add (this.mainbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.mainbox]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.upbox = new global::Gtk.VBox ();
			this.upbox.Name = "upbox";
			this.upbox.Spacing = 6;
			this.vbox2.Add (this.upbox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.upbox]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.newprevbutton = new global::Gtk.Button ();
			this.newprevbutton.TooltipMarkup = "Insert a new category before the selected one";
			this.newprevbutton.Sensitive = false;
			this.newprevbutton.CanFocus = true;
			this.newprevbutton.Name = "newprevbutton";
			this.newprevbutton.UseUnderline = true;
			// Container child newprevbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-top", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w11.LabelProp = global::Mono.Unix.Catalog.GetString ("New Before");
			w11.UseUnderline = true;
			w8.Add (w11);
			w7.Add (w8);
			this.newprevbutton.Add (w7);
			this.vbox2.Add (this.newprevbutton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.newprevbutton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.newafterbutton = new global::Gtk.Button ();
			this.newafterbutton.TooltipMarkup = "Insert a new category after the selected one";
			this.newafterbutton.Sensitive = false;
			this.newafterbutton.CanFocus = true;
			this.newafterbutton.Name = "newafterbutton";
			this.newafterbutton.UseUnderline = true;
			// Container child newafterbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w17 = new global::Gtk.HBox ();
			w17.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w18 = new global::Gtk.Image ();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-bottom", global::Gtk.IconSize.Menu);
			w17.Add (w18);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w20 = new global::Gtk.Label ();
			w20.LabelProp = global::Mono.Unix.Catalog.GetString ("New After");
			w20.UseUnderline = true;
			w17.Add (w20);
			w16.Add (w17);
			this.newafterbutton.Add (w16);
			this.vbox2.Add (this.newafterbutton);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.newafterbutton]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.removebutton = new global::Gtk.Button ();
			this.removebutton.TooltipMarkup = "Remove the selected category";
			this.removebutton.Sensitive = false;
			this.removebutton.CanFocus = true;
			this.removebutton.Name = "removebutton";
			this.removebutton.UseUnderline = true;
			// Container child removebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w25 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w26 = new global::Gtk.HBox ();
			w26.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w27 = new global::Gtk.Image ();
			w27.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w26.Add (w27);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w29 = new global::Gtk.Label ();
			w29.LabelProp = global::Mono.Unix.Catalog.GetString ("Remove");
			w29.UseUnderline = true;
			w26.Add (w29);
			w25.Add (w26);
			this.removebutton.Add (w25);
			this.vbox2.Add (this.removebutton);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.removebutton]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.editbutton = new global::Gtk.Button ();
			this.editbutton.TooltipMarkup = "Edit the selected category";
			this.editbutton.Sensitive = false;
			this.editbutton.CanFocus = true;
			this.editbutton.Name = "editbutton";
			this.editbutton.UseUnderline = true;
			// Container child editbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w34 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w35 = new global::Gtk.HBox ();
			w35.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w36 = new global::Gtk.Image ();
			w36.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w35.Add (w36);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w38 = new global::Gtk.Label ();
			w38.LabelProp = global::Mono.Unix.Catalog.GetString ("Edit");
			w38.UseUnderline = true;
			w35.Add (w38);
			w34.Add (w35);
			this.editbutton.Add (w34);
			this.vbox2.Add (this.editbutton);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.editbutton]));
			w42.Position = 4;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.exportbutton = new global::Gtk.Button ();
			this.exportbutton.TooltipMarkup = "Export the template to a file";
			this.exportbutton.CanFocus = true;
			this.exportbutton.Name = "exportbutton";
			this.exportbutton.UseUnderline = true;
			// Container child exportbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w43 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w44 = new global::Gtk.HBox ();
			w44.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save-as", global::Gtk.IconSize.Menu);
			w44.Add (w45);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w47 = new global::Gtk.Label ();
			w47.LabelProp = global::Mono.Unix.Catalog.GetString ("Export");
			w47.UseUnderline = true;
			w44.Add (w47);
			w43.Add (w44);
			this.exportbutton.Add (w43);
			this.vbox2.Add (this.exportbutton);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.exportbutton]));
			w51.PackType = ((global::Gtk.PackType)(1));
			w51.Position = 5;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w52.PackType = ((global::Gtk.PackType)(1));
			w52.Position = 6;
			w52.Expand = false;
			w52.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w53.Position = 1;
			w53.Expand = false;
			w53.Fill = false;
			this.notebook.Add (this.hbox1);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.notebook.SetTabLabel (this.hbox1, this.label1);
			this.label1.ShowAll ();
			this.Add (this.notebook);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.exportbutton.Hide ();
			this.hseparator1.Hide ();
			this.Show ();
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.newprevbutton.Clicked += new global::System.EventHandler (this.OnNewBefore);
			this.newafterbutton.Clicked += new global::System.EventHandler (this.OnNewAfter);
			this.newafterbutton.Activated += new global::System.EventHandler (this.OnNewBefore);
			this.removebutton.Clicked += new global::System.EventHandler (this.OnRemove);
			this.editbutton.Clicked += new global::System.EventHandler (this.OnEdit);
			this.exportbutton.Clicked += new global::System.EventHandler (this.OnExportbuttonClicked);
		}
	}
}
