using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cg_SixthProject
{
    public class StyleLine: Style, ICloneable
    {
        public Pen Pen { get; set; }
        
        public StyleLine(Color c, Font f, Pen pen) : base(c, f) => Pen = pen;
        public StyleLine(Color c, Font f) : base(c, f) { }
        
        public object Clone()
        {
            Font font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style);
            Pen pen = new Pen(this.Pen.Brush, this.Pen.Width);
            pen.EndCap = this.Pen.EndCap;
            pen.DashStyle = this.Pen.DashStyle;
            return new StyleLine(this.c, font, pen);  
        }
    }
}
