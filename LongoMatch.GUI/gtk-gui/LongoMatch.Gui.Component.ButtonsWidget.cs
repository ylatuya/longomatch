
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class ButtonsWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Button cancelbutton;
		private global::Gtk.Button starttagbutton;
		private global::Gtk.Table table1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.ButtonsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.ButtonsWidget";
			// Container child LongoMatch.Gui.Component.ButtonsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.cancelbutton = new global::Gtk.Button ();
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.UseUnderline = true;
			this.cancelbutton.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			this.vbox1.Add (this.cancelbutton);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.cancelbutton]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.starttagbutton = new global::Gtk.Button ();
			this.starttagbutton.Name = "starttagbutton";
			this.starttagbutton.UseUnderline = true;
			this.starttagbutton.Label = global::Mono.Unix.Catalog.GetString ("Tag new play");
			this.vbox1.Add (this.starttagbutton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.starttagbutton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(1));
			this.table1.ColumnSpacing = ((uint)(1));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w3.Position = 2;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.cancelbutton.Hide ();
			this.starttagbutton.Hide ();
			this.Show ();
			this.cancelbutton.Clicked += new global::System.EventHandler (this.OnCancelbuttonClicked);
			this.starttagbutton.Clicked += new global::System.EventHandler (this.OnStartTagClicked);
		}
	}
}
