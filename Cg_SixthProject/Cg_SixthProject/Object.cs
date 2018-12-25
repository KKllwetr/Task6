using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cg_SixthProject
{
    public abstract class Object : ICloneable 
    {
        public StyleObject style;
        public object Clone() => this.MemberwiseClone();
        public bool Select { get; set; }
        public string Value { get; set; }
        public int Id { get; set; } 
        public StyleObject GetStyles() => style;

        public Object(bool select, string value, int id, StyleObject style)
        {
            Select = select;
            value = Value;
            Id = id;
            this.style = style;
        } 
    }
}
