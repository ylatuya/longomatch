// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Popup {
    
    
    public partial class TransparentDrawingArea {
        
        private Gtk.DrawingArea drawingarea;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Popup.TransparentDrawingArea
            this.Name = "LongoMatch.Gui.Popup.TransparentDrawingArea";
            this.Title = Mono.Unix.Catalog.GetString("TransparentDrawingArea");
            this.TypeHint = ((Gdk.WindowTypeHint)(4));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.AllowShrink = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Container child LongoMatch.Gui.Popup.TransparentDrawingArea.Gtk.Container+ContainerChild
            this.drawingarea = new Gtk.DrawingArea();
            this.drawingarea.Name = "drawingarea";
            this.Add(this.drawingarea);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 644;
            this.DefaultHeight = 370;
            this.Show();
            this.drawingarea.MotionNotifyEvent += new Gtk.MotionNotifyEventHandler(this.OnDrawingareaMotionNotifyEvent);
            this.drawingarea.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnDrawingareaButtonPressEvent);
            this.drawingarea.ExposeEvent += new Gtk.ExposeEventHandler(this.OnDrawingareaExposeEvent);
            this.drawingarea.ConfigureEvent += new Gtk.ConfigureEventHandler(this.OnDrawingareaConfigureEvent);
            this.drawingarea.ButtonReleaseEvent += new Gtk.ButtonReleaseEventHandler(this.OnDrawingareaButtonReleaseEvent);
        }
    }
}
