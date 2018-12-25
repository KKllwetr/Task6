using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cg_SixthProject
{
    public abstract class Style
    {
        public Color c;
        public Font Font { get; set; }

        public Style(Color c, Font font)
        {
            this.c = c;
            Font = font;
        }
    }
}
