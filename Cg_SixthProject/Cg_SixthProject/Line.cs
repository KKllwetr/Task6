using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cg_SixthProject
{
    public class Line: ILine, ICloneable
    {
        StyleLine style;
        public object Clone() => this.MemberwiseClone();
        public StyleLine GetStyles() => style;
        public string Value { get; set; }
        public int Entity_1 { get; set; }
        public int Entity_2 { get; set; }
        public int Id { get; set; }
        public bool Select { get; set; }
        public List<Point> points = new List<Point>();

        
        
        public Line(StyleLine style, string value, int en1, int en2, int id)
        {
            this.style = style;
            Value = value;
            Entity_1 = en1;
            Entity_2 = en2;
            Id = id;
            Select = false;
        }

        public Line(int en1, int en2, int id)
        {
            Entity_1 = en1;
            Entity_2 = en2;
            Id = id;
            Select = false;
        }
        public Line(StyleLine style, int en1, int id)
        {
            Entity_1 = en1;
            Id = id;
            Select = false;
            this.style = style;
            
        }
    }
}
