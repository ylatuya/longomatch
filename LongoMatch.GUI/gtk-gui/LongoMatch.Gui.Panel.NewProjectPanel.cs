
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class NewProjectPanel
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.EventBox headereventbox;
		private global::LongoMatch.Gui.Panel.PanelHeader panelheader1;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HBox hbox20;
		private global::Gtk.RadioButton fromfileradiobutton;
		private global::Gtk.Image image61;
		private global::Gtk.HBox hbox2;
		private global::Gtk.RadioButton liveradiobutton;
		private global::Gtk.Image image63;
		private global::Gtk.HBox hbox4;
		private global::Gtk.RadioButton fakeliveradiobutton;
		private global::Gtk.Image image62;
		private global::Gtk.HBox ipcamerabox;
		private global::Gtk.RadioButton uriliveradiobutton;
		private global::Gtk.Image image64;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.HBox topbox;
		private global::Gtk.Table lefttable;
		private global::Gtk.Entry competitionentry;
		private global::Gtk.Label Competitionlabel;
		private global::Gtk.Label datelabel2;
		private global::LongoMatch.Gui.Component.DatePicker datepicker1;
		private global::Gtk.Entry seasonentry;
		private global::Gtk.Label seasonlabel;
		private global::Gtk.VBox centerbox;
		private global::Gtk.HBox hbox15;
		private global::LongoMatch.Gui.Component.HomeTeamsComboBox hometeamscombobox;
		private global::Gtk.Image vsimage;
		private global::LongoMatch.Gui.Component.AwayTeamsComboBox awayteamscombobox;
		private global::Gtk.Label filelabel;
		private global::Gtk.Table filetable;
		private global::LongoMatch.Gui.Component.MediaFileChooser mediafilechooser1;
		private global::LongoMatch.Gui.Component.MediaFileChooser mediafilechooser2;
		private global::Gtk.Table outputfiletable;
		private global::Gtk.HBox outputfilehbox1;
		private global::Gtk.Entry outfileEntry;
		private global::Gtk.Button savebutton;
		private global::Gtk.Label outputfilelabel;
		private global::Gtk.Table capturetable;
		private global::Gtk.ComboBox encodingcombobox;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label device;
		private global::Gtk.Label urilabel;
		private global::Gtk.HBox hbox7;
		private global::Gtk.ComboBox devicecombobox;
		private global::Gtk.Entry urientry;
		private global::Gtk.ComboBox imagecombobox;
		private global::Gtk.ComboBox qualitycombobox;
		private global::Gtk.Label qualitylabel;
		private global::Gtk.Label sizelabel;
		private global::Gtk.Label videoformatlabel;
		private global::Gtk.Table righttable;
		private global::Gtk.Label analysislabel;
		private global::Gtk.ComboBox tagscombobox;
		private global::Gtk.VBox vbox6;
		private global::Gtk.DrawingArea drawingarea;
		private global::Gtk.Label label3;
		private global::LongoMatch.Gui.Component.ProjectPeriods projectperiods1;
		private global::Gtk.Label label7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.NewProjectPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.NewProjectPanel";
			// Container child LongoMatch.Gui.Panel.NewProjectPanel.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.headereventbox = new global::Gtk.EventBox ();
			this.headereventbox.Name = "headereventbox";
			// Container child headereventbox.Gtk.Container+ContainerChild
			this.panelheader1 = new global::LongoMatch.Gui.Panel.PanelHeader ();
			this.panelheader1.Events = ((global::Gdk.EventMask)(256));
			this.panelheader1.Name = "panelheader1";
			this.headereventbox.Add (this.panelheader1);
			this.vbox3.Add (this.headereventbox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.headereventbox]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			this.notebook1.ShowBorder = false;
			this.notebook1.Scrollable = true;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox4.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox20 = new global::Gtk.HBox ();
			this.hbox20.Name = "hbox20";
			this.hbox20.Spacing = 6;
			// Container child hbox20.Gtk.Box+BoxChild
			this.fromfileradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("New project using a video file"));
			this.fromfileradiobutton.CanFocus = true;
			this.fromfileradiobutton.Name = "fromfileradiobutton";
			this.fromfileradiobutton.DrawIndicator = true;
			this.fromfileradiobutton.UseUnderline = true;
			this.fromfileradiobutton.FocusOnClick = false;
			this.fromfileradiobutton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox20.Add (this.fromfileradiobutton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox20 [this.fromfileradiobutton]));
			w4.Position = 0;
			// Container child hbox20.Gtk.Box+BoxChild
			this.image61 = new global::Gtk.Image ();
			this.image61.Name = "image61";
			this.image61.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("video.png");
			this.hbox20.Add (this.image61);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox20 [this.image61]));
			w5.Position = 1;
			this.vbox4.Add (this.hbox20);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox20]));
			w6.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.liveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a capture device"));
			this.liveradiobutton.CanFocus = true;
			this.liveradiobutton.Name = "liveradiobutton";
			this.liveradiobutton.DrawIndicator = true;
			this.liveradiobutton.UseUnderline = true;
			this.liveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox2.Add (this.liveradiobutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.liveradiobutton]));
			w7.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image63 = new global::Gtk.Image ();
			this.image63.Name = "image63";
			this.image63.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox2.Add (this.image63);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image63]));
			w8.Position = 1;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w9.Position = 2;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fakeliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using a fake capture device"));
			this.fakeliveradiobutton.CanFocus = true;
			this.fakeliveradiobutton.Name = "fakeliveradiobutton";
			this.fakeliveradiobutton.DrawIndicator = true;
			this.fakeliveradiobutton.UseUnderline = true;
			this.fakeliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.hbox4.Add (this.fakeliveradiobutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.fakeliveradiobutton]));
			w10.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.image62 = new global::Gtk.Image ();
			this.image62.Name = "image62";
			this.image62.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.hbox4.Add (this.image62);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.image62]));
			w11.Position = 1;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
			w12.Position = 3;
			// Container child vbox4.Gtk.Box+BoxChild
			this.ipcamerabox = new global::Gtk.HBox ();
			this.ipcamerabox.Name = "ipcamerabox";
			this.ipcamerabox.Spacing = 6;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.uriliveradiobutton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Live project using an IP camera"));
			this.uriliveradiobutton.CanFocus = true;
			this.uriliveradiobutton.Name = "uriliveradiobutton";
			this.uriliveradiobutton.DrawIndicator = true;
			this.uriliveradiobutton.UseUnderline = true;
			this.uriliveradiobutton.Group = this.fromfileradiobutton.Group;
			this.ipcamerabox.Add (this.uriliveradiobutton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.uriliveradiobutton]));
			w13.Position = 0;
			// Container child ipcamerabox.Gtk.Box+BoxChild
			this.image64 = new global::Gtk.Image ();
			this.image64.Name = "image64";
			this.image64.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("camera-video.png");
			this.ipcamerabox.Add (this.image64);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.ipcamerabox [this.image64]));
			w14.Position = 1;
			this.vbox4.Add (this.ipcamerabox);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.ipcamerabox]));
			w15.Position = 4;
			this.notebook1.Add (this.vbox4);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (this.vbox4, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.topbox = new global::Gtk.HBox ();
			this.topbox.Name = "topbox";
			this.topbox.Spacing = 6;
			// Container child topbox.Gtk.Box+BoxChild
			this.lefttable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.lefttable.Name = "lefttable";
			this.lefttable.RowSpacing = ((uint)(6));
			this.lefttable.ColumnSpacing = ((uint)(6));
			// Container child lefttable.Gtk.Table+TableChild
			this.competitionentry = new global::Gtk.Entry ();
			this.competitionentry.CanFocus = true;
			this.competitionentry.Name = "competitionentry";
			this.competitionentry.IsEditable = true;
			this.competitionentry.InvisibleChar = '●';
			this.lefttable.Add (this.competitionentry);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.lefttable [this.competitionentry]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.Competitionlabel = new global::Gtk.Label ();
			this.Competitionlabel.Name = "Competitionlabel";
			this.Competitionlabel.Xalign = 1F;
			this.Competitionlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Competition");
			this.lefttable.Add (this.Competitionlabel);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.lefttable [this.Competitionlabel]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.datelabel2 = new global::Gtk.Label ();
			this.datelabel2.Name = "datelabel2";
			this.datelabel2.Xalign = 1F;
			this.datelabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("Date");
			this.lefttable.Add (this.datelabel2);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.lefttable [this.datelabel2]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.datepicker1 = new global::LongoMatch.Gui.Component.DatePicker ();
			this.datepicker1.Events = ((global::Gdk.EventMask)(256));
			this.datepicker1.Name = "datepicker1";
			this.datepicker1.Date = new global::System.DateTime (0);
			this.lefttable.Add (this.datepicker1);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.lefttable [this.datepicker1]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(0));
			w20.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child lefttable.Gtk.Table+TableChild
			this.seasonentry = new global::Gtk.Entry ();
			this.seasonentry.CanFocus = true;
			this.seasonentry.Name = "seasonentry";
			this.seasonentry.IsEditable = true;
			this.seasonentry.InvisibleChar = '●';
			this.lefttable.Add (this.seasonentry);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.lefttable [this.seasonentry]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child lefttable.Gtk.Table+TableChild
			this.seasonlabel = new global::Gtk.Label ();
			this.seasonlabel.Name = "seasonlabel";
			this.seasonlabel.Xalign = 1F;
			this.seasonlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Season");
			this.lefttable.Add (this.seasonlabel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.lefttable [this.seasonlabel]));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.topbox.Add (this.lefttable);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.topbox [this.lefttable]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child topbox.Gtk.Box+BoxChild
			this.centerbox = new global::Gtk.VBox ();
			this.centerbox.WidthRequest = 500;
			this.centerbox.Name = "centerbox";
			this.centerbox.Spacing = 6;
			// Container child centerbox.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.HeightRequest = 60;
			this.hbox15.Name = "hbox15";
			// Container child hbox15.Gtk.Box+BoxChild
			this.hometeamscombobox = new global::LongoMatch.Gui.Component.HomeTeamsComboBox ();
			this.hometeamscombobox.Name = "hometeamscombobox";
			this.hbox15.Add (this.hometeamscombobox);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.hometeamscombobox]));
			w24.Position = 0;
			// Container child hbox15.Gtk.Box+BoxChild
			this.vsimage = new global::Gtk.Image ();
			this.vsimage.Name = "vsimage";
			this.vsimage.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "longomatch-vs", global::Gtk.IconSize.Dialog);
			this.hbox15.Add (this.vsimage);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.vsimage]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.awayteamscombobox = new global::LongoMatch.Gui.Component.AwayTeamsComboBox ();
			this.awayteamscombobox.Name = "awayteamscombobox";
			this.hbox15.Add (this.awayteamscombobox);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.awayteamscombobox]));
			w26.Position = 2;
			this.centerbox.Add (this.hbox15);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.hbox15]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.filelabel = new global::Gtk.Label ();
			this.filelabel.Name = "filelabel";
			this.filelabel.Xalign = 0F;
			this.filelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Video files");
			this.centerbox.Add (this.filelabel);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.filelabel]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.filetable = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.filetable.Name = "filetable";
			this.filetable.RowSpacing = ((uint)(6));
			this.filetable.ColumnSpacing = ((uint)(6));
			// Container child filetable.Gtk.Table+TableChild
			this.mediafilechooser1 = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.mediafilechooser1.Events = ((global::Gdk.EventMask)(256));
			this.mediafilechooser1.Name = "mediafilechooser1";
			this.filetable.Add (this.mediafilechooser1);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.filetable [this.mediafilechooser1]));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child filetable.Gtk.Table+TableChild
			this.mediafilechooser2 = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.mediafilechooser2.Events = ((global::Gdk.EventMask)(256));
			this.mediafilechooser2.Name = "mediafilechooser2";
			this.filetable.Add (this.mediafilechooser2);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.filetable [this.mediafilechooser2]));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			this.centerbox.Add (this.filetable);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.filetable]));
			w31.Position = 2;
			// Container child centerbox.Gtk.Box+BoxChild
			this.outputfiletable = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.outputfiletable.Name = "outputfiletable";
			this.outputfiletable.RowSpacing = ((uint)(6));
			this.outputfiletable.ColumnSpacing = ((uint)(6));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.outputfilehbox1 = new global::Gtk.HBox ();
			this.outputfilehbox1.Name = "outputfilehbox1";
			this.outputfilehbox1.Spacing = 6;
			// Container child outputfilehbox1.Gtk.Box+BoxChild
			this.outfileEntry = new global::Gtk.Entry ();
			this.outfileEntry.CanFocus = true;
			this.outfileEntry.Name = "outfileEntry";
			this.outfileEntry.IsEditable = false;
			this.outfileEntry.HasFrame = false;
			this.outfileEntry.InvisibleChar = '●';
			this.outputfilehbox1.Add (this.outfileEntry);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.outputfilehbox1 [this.outfileEntry]));
			w32.Position = 0;
			// Container child outputfilehbox1.Gtk.Box+BoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			// Container child savebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w33 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w34 = new global::Gtk.HBox ();
			w34.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w35 = new global::Gtk.Image ();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save-as", global::Gtk.IconSize.Menu);
			w34.Add (w35);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w37 = new global::Gtk.Label ();
			w34.Add (w37);
			w33.Add (w34);
			this.savebutton.Add (w33);
			this.outputfilehbox1.Add (this.savebutton);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.outputfilehbox1 [this.savebutton]));
			w41.Position = 1;
			w41.Expand = false;
			this.outputfiletable.Add (this.outputfilehbox1);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.outputfilehbox1]));
			w42.LeftAttach = ((uint)(1));
			w42.RightAttach = ((uint)(2));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child outputfiletable.Gtk.Table+TableChild
			this.outputfilelabel = new global::Gtk.Label ();
			this.outputfilelabel.Name = "outputfilelabel";
			this.outputfilelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Output file:");
			this.outputfiletable.Add (this.outputfilelabel);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.outputfiletable [this.outputfilelabel]));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			this.centerbox.Add (this.outputfiletable);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.outputfiletable]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			// Container child centerbox.Gtk.Box+BoxChild
			this.capturetable = new global::Gtk.Table (((uint)(2)), ((uint)(4)), true);
			this.capturetable.Name = "capturetable";
			this.capturetable.RowSpacing = ((uint)(6));
			this.capturetable.ColumnSpacing = ((uint)(6));
			// Container child capturetable.Gtk.Table+TableChild
			this.encodingcombobox = global::Gtk.ComboBox.NewText ();
			this.encodingcombobox.Name = "encodingcombobox";
			this.capturetable.Add (this.encodingcombobox);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.capturetable [this.encodingcombobox]));
			w45.LeftAttach = ((uint)(3));
			w45.RightAttach = ((uint)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.device = new global::Gtk.Label ();
			this.device.Name = "device";
			this.device.LabelProp = global::Mono.Unix.Catalog.GetString ("Device:");
			this.hbox6.Add (this.device);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.device]));
			w46.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.urilabel = new global::Gtk.Label ();
			this.urilabel.Name = "urilabel";
			this.urilabel.LabelProp = global::Mono.Unix.Catalog.GetString ("URL:");
			this.hbox6.Add (this.urilabel);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.urilabel]));
			w47.Position = 1;
			this.capturetable.Add (this.hbox6);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.capturetable [this.hbox6]));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.devicecombobox = global::Gtk.ComboBox.NewText ();
			this.devicecombobox.Name = "devicecombobox";
			this.hbox7.Add (this.devicecombobox);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.devicecombobox]));
			w49.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.urientry = new global::Gtk.Entry ();
			this.urientry.CanFocus = true;
			this.urientry.Name = "urientry";
			this.urientry.IsEditable = true;
			this.urientry.InvisibleChar = '•';
			this.hbox7.Add (this.urientry);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.urientry]));
			w50.Position = 1;
			this.capturetable.Add (this.hbox7);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.capturetable [this.hbox7]));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.imagecombobox = global::Gtk.ComboBox.NewText ();
			this.imagecombobox.Name = "imagecombobox";
			this.capturetable.Add (this.imagecombobox);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.capturetable [this.imagecombobox]));
			w52.TopAttach = ((uint)(1));
			w52.BottomAttach = ((uint)(2));
			w52.LeftAttach = ((uint)(1));
			w52.RightAttach = ((uint)(2));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.qualitycombobox = global::Gtk.ComboBox.NewText ();
			this.qualitycombobox.Name = "qualitycombobox";
			this.capturetable.Add (this.qualitycombobox);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.capturetable [this.qualitycombobox]));
			w53.TopAttach = ((uint)(1));
			w53.BottomAttach = ((uint)(2));
			w53.LeftAttach = ((uint)(3));
			w53.RightAttach = ((uint)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.qualitylabel = new global::Gtk.Label ();
			this.qualitylabel.Name = "qualitylabel";
			this.qualitylabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Quality:");
			this.capturetable.Add (this.qualitylabel);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.capturetable [this.qualitylabel]));
			w54.TopAttach = ((uint)(1));
			w54.BottomAttach = ((uint)(2));
			w54.LeftAttach = ((uint)(2));
			w54.RightAttach = ((uint)(3));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.sizelabel = new global::Gtk.Label ();
			this.sizelabel.Name = "sizelabel";
			this.sizelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Size:");
			this.capturetable.Add (this.sizelabel);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.capturetable [this.sizelabel]));
			w55.TopAttach = ((uint)(1));
			w55.BottomAttach = ((uint)(2));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child capturetable.Gtk.Table+TableChild
			this.videoformatlabel = new global::Gtk.Label ();
			this.videoformatlabel.Name = "videoformatlabel";
			this.videoformatlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Format:");
			this.capturetable.Add (this.videoformatlabel);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.capturetable [this.videoformatlabel]));
			w56.LeftAttach = ((uint)(2));
			w56.RightAttach = ((uint)(3));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			this.centerbox.Add (this.capturetable);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.centerbox [this.capturetable]));
			w57.Position = 4;
			w57.Expand = false;
			w57.Fill = false;
			this.topbox.Add (this.centerbox);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.topbox [this.centerbox]));
			w58.Position = 1;
			w58.Fill = false;
			// Container child topbox.Gtk.Box+BoxChild
			this.righttable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), true);
			this.righttable.Name = "righttable";
			this.righttable.RowSpacing = ((uint)(6));
			this.righttable.ColumnSpacing = ((uint)(6));
			// Container child righttable.Gtk.Table+TableChild
			this.analysislabel = new global::Gtk.Label ();
			this.analysislabel.Name = "analysislabel";
			this.analysislabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Analisys Template:");
			this.righttable.Add (this.analysislabel);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.righttable [this.analysislabel]));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child righttable.Gtk.Table+TableChild
			this.tagscombobox = global::Gtk.ComboBox.NewText ();
			this.tagscombobox.Name = "tagscombobox";
			this.righttable.Add (this.tagscombobox);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.righttable [this.tagscombobox]));
			w60.LeftAttach = ((uint)(1));
			w60.RightAttach = ((uint)(2));
			w60.YOptions = ((global::Gtk.AttachOptions)(0));
			this.topbox.Add (this.righttable);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.topbox [this.righttable]));
			w61.Position = 2;
			w61.Expand = false;
			w61.Fill = false;
			this.alignment1.Add (this.topbox);
			this.vbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.alignment1]));
			w63.Position = 0;
			w63.Expand = false;
			w63.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.Name = "drawingarea";
			this.vbox6.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.drawingarea]));
			w64.Position = 0;
			this.vbox5.Add (this.vbox6);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox6]));
			w65.Position = 1;
			this.notebook1.Add (this.vbox5);
			global::Gtk.Notebook.NotebookChild w66 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox5]));
			w66.Position = 1;
			w66.TabFill = false;
			w66.MenuLabel = "";
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.vbox5, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.projectperiods1 = new global::LongoMatch.Gui.Component.ProjectPeriods ();
			this.projectperiods1.Events = ((global::Gdk.EventMask)(256));
			this.projectperiods1.Name = "projectperiods1";
			this.notebook1.Add (this.projectperiods1);
			global::Gtk.Notebook.NotebookChild w67 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.projectperiods1]));
			w67.Position = 2;
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebook1.SetTabLabel (this.projectperiods1, this.label7);
			this.label7.ShowAll ();
			this.vbox3.Add (this.notebook1);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.notebook1]));
			w68.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.device.Hide ();
			this.urilabel.Hide ();
			this.devicecombobox.Hide ();
			this.urientry.Hide ();
			this.capturetable.Hide ();
			this.Hide ();
		}
	}
}
