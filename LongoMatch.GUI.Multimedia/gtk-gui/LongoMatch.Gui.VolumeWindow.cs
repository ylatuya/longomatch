
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui
{
	public partial class VolumeWindow
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Button morebutton;
		private global::Gtk.VScale volumescale;
		private global::Gtk.Button lessbutton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.VolumeWindow
			this.Name = "LongoMatch.Gui.VolumeWindow";
			this.Title = "";
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.Decorated = false;
			this.DestroyWithParent = true;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Container child LongoMatch.Gui.VolumeWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.morebutton = new global::Gtk.Button ();
			this.morebutton.Name = "morebutton";
			this.morebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			this.morebutton.Label = "+";
			this.vbox2.Add (this.morebutton);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.morebutton]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.volumescale = new global::Gtk.VScale (null);
			this.volumescale.CanFocus = true;
			this.volumescale.Name = "volumescale";
			this.volumescale.Inverted = true;
			this.volumescale.Adjustment.Upper = 1;
			this.volumescale.Adjustment.PageIncrement = 1;
			this.volumescale.Adjustment.StepIncrement = 1;
			this.volumescale.Adjustment.Value = 1;
			this.volumescale.DrawValue = false;
			this.volumescale.Digits = 0;
			this.volumescale.ValuePos = ((global::Gtk.PositionType)(2));
			this.vbox2.Add (this.volumescale);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.volumescale]));
			w2.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lessbutton = new global::Gtk.Button ();
			this.lessbutton.Name = "lessbutton";
			this.lessbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			this.lessbutton.Label = "-";
			this.vbox2.Add (this.lessbutton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lessbutton]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 31;
			this.DefaultHeight = 204;
			this.Hide ();
			this.FocusOutEvent += new global::Gtk.FocusOutEventHandler (this.OnFocusOutEvent);
			this.morebutton.Clicked += new global::System.EventHandler (this.OnMorebuttonClicked);
			this.volumescale.ValueChanged += new global::System.EventHandler (this.OnVolumescaleValueChanged);
			this.lessbutton.Clicked += new global::System.EventHandler (this.OnLessbuttonClicked);
		}
	}
}
