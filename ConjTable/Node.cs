using System.Collections.Generic;
using System.Drawing;

namespace System.Windows.Forms
{
    public class Node : IDrawable, IDragable
    {
        public List<Node> Linked { get; set; } = new List<Node>();
        public string Label;
        public double Label1;
        public float Radius = 15f;
        public PointF Location;

        public void Drag(PointF offset)
        {
            Location = Location.Add(offset);
        }

        public void EndDrag() { }

        public bool Hit(PointF point)
        {
            var p = point.Sub(Location);
            return Math.Pow(p.X, 2) + Math.Pow(p.Y, 2) <= Radius * Radius;
        }

        public void Paint(Graphics gr)
        {
            int i = 0;
            foreach (var item in Linked)
            {
                gr.DrawLink(Location, item.Location, Radius);
                //gr.DrawString(Convert.ToString(Linked[i].Label1), SystemFonts.CaptionFont, SystemBrushes.ControlDarkDark, (item.Location.X + Location.X) / 2, (item.Location.Y + Location.Y) / 2);
                i++;
            }
                

            var state = gr.Save();
            gr.TranslateTransform(Location.X, Location.Y);
            gr.DrawCircle(Radius, Pens.Black);
            if (!string.IsNullOrEmpty(Label))
            {
                gr.DrawCenteredString(Convert.ToString(Convert.ToInt32(Label) + 1), SystemFonts.CaptionFont, SystemBrushes.ControlDarkDark, Radius);
            }
            gr.Restore(state);
        }

        public IDragable StartDrag(PointF p)
        {
            return this;
        }

        public override string ToString()
        {
            return string.Format("Node: {0}", Label);
        }
    }
}
