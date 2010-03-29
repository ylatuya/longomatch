// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {
    
    
    public partial class ProjectSelectionDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.RadioButton fromfileradiobutton;
        
        private Gtk.Image image61;
        
        private Gtk.HBox hbox2;
        
        private Gtk.RadioButton fakeliveradiobutton;
        
        private Gtk.Image image62;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.ProjectSelectionDialog
            this.Name = "LongoMatch.Gui.Dialog.ProjectSelectionDialog";
            this.Title = Mono.Unix.Catalog.GetString("New Project");
            this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Menu, 16);
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.fromfileradiobutton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("New project usng a video file"));
            this.fromfileradiobutton.CanFocus = true;
            this.fromfileradiobutton.Name = "fromfileradiobutton";
            this.fromfileradiobutton.Active = true;
            this.fromfileradiobutton.DrawIndicator = true;
            this.fromfileradiobutton.UseUnderline = true;
            this.fromfileradiobutton.FocusOnClick = false;
            this.fromfileradiobutton.Group = new GLib.SList(System.IntPtr.Zero);
            this.hbox1.Add(this.fromfileradiobutton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.fromfileradiobutton]));
            w2.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image61 = new Gtk.Image();
            this.image61.Name = "image61";
            this.image61.Pixbuf = Gdk.Pixbuf.LoadFromResource("video.png");
            this.hbox1.Add(this.image61);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.image61]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.fakeliveradiobutton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Live project using a fake capture device"));
            this.fakeliveradiobutton.CanFocus = true;
            this.fakeliveradiobutton.Name = "fakeliveradiobutton";
            this.fakeliveradiobutton.DrawIndicator = true;
            this.fakeliveradiobutton.UseUnderline = true;
            this.fakeliveradiobutton.Group = this.fromfileradiobutton.Group;
            this.hbox2.Add(this.fakeliveradiobutton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.fakeliveradiobutton]));
            w5.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.image62 = new Gtk.Image();
            this.image62.Name = "image62";
            this.image62.Pixbuf = Gdk.Pixbuf.LoadFromResource("camera-video.png");
            this.hbox2.Add(this.image62);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.image62]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Internal child LongoMatch.Gui.Dialog.ProjectSelectionDialog.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 6;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
            w10.Expand = false;
            w10.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 298;
            this.DefaultHeight = 138;
            this.Show();
        }
    }
}
