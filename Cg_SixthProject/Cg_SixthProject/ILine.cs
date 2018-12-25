using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cg_SixthProject
{
    interface ILine
    {
        string Value { get; set; }
        int Entity_1 { get; set; }
        int Entity_2 { get; set; }
        StyleLine GetStyles();
    }
}
