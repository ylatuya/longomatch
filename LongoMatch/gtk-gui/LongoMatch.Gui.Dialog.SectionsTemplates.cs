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
    
    
    public partial class SectionsTemplates {
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.TreeView treeview;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Button newbutton;
        
        private Gtk.Button savebutton;
        
        private Gtk.Button deletebutton;
        
        private LongoMatch.Gui.Component.SectionsPropertiesWidget sectionspropertieswidget1;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.SectionsTemplates
            this.Name = "LongoMatch.Gui.Dialog.SectionsTemplates";
            this.Title = Mono.Unix.Catalog.GetString("Templates Manager");
            this.Icon = Gdk.Pixbuf.LoadFromResource("longomatch_logo.png");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.SectionsTemplates.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 182;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.treeview = new Gtk.TreeView();
            this.treeview.CanFocus = true;
            this.treeview.Name = "treeview";
            this.vbox2.Add(this.treeview);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.treeview]));
            w2.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Homogeneous = true;
            // Container child hbox2.Gtk.Box+BoxChild
            this.newbutton = new Gtk.Button();
            this.newbutton.TooltipMarkup = "Create a new template";
            this.newbutton.CanFocus = true;
            this.newbutton.Name = "newbutton";
            this.newbutton.UseUnderline = true;
            // Container child newbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w3 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w4 = new Gtk.HBox();
            w4.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w5 = new Gtk.Image();
            w5.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-new", Gtk.IconSize.Button, 20);
            w4.Add(w5);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w7 = new Gtk.Label();
            w4.Add(w7);
            w3.Add(w4);
            this.newbutton.Add(w3);
            this.hbox2.Add(this.newbutton);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.newbutton]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.savebutton = new Gtk.Button();
            this.savebutton.TooltipMarkup = "Save this template";
            this.savebutton.Sensitive = false;
            this.savebutton.CanFocus = true;
            this.savebutton.Name = "savebutton";
            this.savebutton.UseUnderline = true;
            // Container child savebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w12 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            Gtk.HBox w13 = new Gtk.HBox();
            w13.Spacing = 2;
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Image w14 = new Gtk.Image();
            w14.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-save", Gtk.IconSize.Button, 20);
            w13.Add(w14);
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Label w16 = new Gtk.Label();
            w13.Add(w16);
            w12.Add(w13);
            this.savebutton.Add(w12);
            this.hbox2.Add(this.savebutton);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox2[this.savebutton]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.deletebutton = new Gtk.Button();
            this.deletebutton.TooltipMarkup = "Delete this template";
            this.deletebutton.Sensitive = false;
            this.deletebutton.CanFocus = true;
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.UseUnderline = true;
            // Container child deletebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w21 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            Gtk.HBox w22 = new Gtk.HBox();
            w22.Spacing = 2;
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Image w23 = new Gtk.Image();
            w23.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-delete", Gtk.IconSize.Button, 20);
            w22.Add(w23);
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Label w25 = new Gtk.Label();
            w22.Add(w25);
            w21.Add(w22);
            this.deletebutton.Add(w21);
            this.hbox2.Add(this.deletebutton);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.hbox2[this.deletebutton]));
            w29.Position = 2;
            w29.Expand = false;
            w29.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w30.Position = 1;
            w30.Expand = false;
            w30.Fill = false;
            this.hpaned1.Add(this.vbox2);
            Gtk.Paned.PanedChild w31 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox2]));
            w31.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.sectionspropertieswidget1 = null;
            this.hpaned1.Add(this.sectionspropertieswidget1);
            w1.Add(this.hpaned1);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(w1[this.hpaned1]));
            w33.Position = 0;
            // Internal child LongoMatch.Gui.Dialog.SectionsTemplates.ActionArea
            Gtk.HButtonBox w34 = this.ActionArea;
            w34.Name = "dialog1_ActionArea";
            w34.Spacing = 6;
            w34.BorderWidth = ((uint)(5));
            w34.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-quit";
            this.AddActionWidget(this.buttonOk, 0);
            Gtk.ButtonBox.ButtonBoxChild w35 = ((Gtk.ButtonBox.ButtonBoxChild)(w34[this.buttonOk]));
            w35.Expand = false;
            w35.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 803;
            this.DefaultHeight = 388;
            this.Show();
            this.treeview.CursorChanged += new System.EventHandler(this.OnTreeviewCursorChanged);
            this.newbutton.Clicked += new System.EventHandler(this.OnNewbuttonClicked);
            this.savebutton.Clicked += new System.EventHandler(this.OnSavebuttonClicked);
            this.deletebutton.Clicked += new System.EventHandler(this.OnDeletebuttonClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
