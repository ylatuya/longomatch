
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class TeamTaggerWidget
	{
		private global::Gtk.Frame frame;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.HBox buttonsbox;
		private global::Gtk.Label titlelabel;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.TeamTaggerWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.TeamTaggerWidget";
			// Container child LongoMatch.Gui.Component.TeamTaggerWidget.Gtk.Container+ContainerChild
			this.frame = new global::Gtk.Frame ();
			this.frame.Name = "frame";
			this.frame.ShadowType = ((global::Gtk.ShadowType)(2));
			// Container child frame.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.buttonsbox = new global::Gtk.HBox ();
			this.buttonsbox.Name = "buttonsbox";
			this.buttonsbox.Spacing = 6;
			this.GtkAlignment.Add (this.buttonsbox);
			this.frame.Add (this.GtkAlignment);
			this.titlelabel = new global::Gtk.Label ();
			this.titlelabel.Name = "titlelabel";
			this.titlelabel.UseMarkup = true;
			this.frame.LabelWidget = this.titlelabel;
			this.Add (this.frame);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
