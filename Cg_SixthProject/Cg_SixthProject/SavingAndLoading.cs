using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Cg_SixthProject
{
    public class SavingAndLoading
    {
        public static void SaveNetwork(string FileName, Network network)
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                string str = "";
                for (int i = 0; i < network.entities.Count; i++)
                    str += network.entities[i].ToStr();
                sw.Write(str);
            }
        }

        public static void LoadNetwork(string FileName, out Network network)
        {
            network = new Network();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string str = sr.ReadLine();
                while (str != null)
                {
                    string[] _arrayEntity = str.Trim().Split(),
                             _arratyLines = sr.ReadLine().Trim().Split();
                    List<Line> lines = new List<Line>();
                    if (_arratyLines[0] != "")
                        for (int i = 0; i < _arratyLines.Length; i += 3)
                        {
                            lines.Add(new Line(Convert.ToInt32(_arratyLines[i]), Convert.ToInt32(_arratyLines[i + 1]), Convert.ToInt32(_arratyLines[i + 2])));
                            network.lines.Add(new Line(Convert.ToInt32(_arratyLines[i]), Convert.ToInt32(_arratyLines[i + 1]), Convert.ToInt32(_arratyLines[i + 2])));
                        }
                    Entity node = new Entity(_arrayEntity[1],Convert.ToInt32(_arrayEntity[0])
                         , Convert.ToInt32(_arrayEntity[2]),  Convert.ToInt32(_arrayEntity[3])
                         , Convert.ToInt32(_arrayEntity[4]),  Convert.ToInt32(_arrayEntity[5]), lines);
                    network.entities.Add(node);
                    str = sr.ReadLine();
                }
            }
        }
    }
}
