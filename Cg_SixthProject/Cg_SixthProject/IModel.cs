using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cg_SixthProject
{
    interface IModel
    {
        string Value { get; set; }
        int XCoordinates { get; set; }
        int YCoordinates { get; set; }
        StyleObject GetStyles();
    }
}
