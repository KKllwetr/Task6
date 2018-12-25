using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cg_SixthProject
{
    public class Entity : Object, IModel
    {
        public int XCoordinates { get; set; }
        public int YCoordinates { get; set; }
        public int Width { get; private set; } 
        public int Height { get; private set; }
        public List<Line> list;
        public bool start = false;
        public Rectangle r { get; set; }
        
        public Entity(StyleObject style, string value,int id, int x, int y, int width, int height, Rectangle r):
            base(false, value, id, style)
        {
            Width = width;
            Height = height;
            XCoordinates = x;
            YCoordinates = y;
            list = new List<Line>();
            this.r = r;
        }
        public Entity(StyleObject style, string value, int id, int x, int y, int width, int height, List<Line> lines) :
            base(false, value, id, style)
        {
            XCoordinates = x;
            YCoordinates = y;
            Width = width;
            Height = height;
            list = lines;
        }
        public Entity(string value, int id, int x, int y, int width, int height, List<Line> lines) :
           base(false, value, id, null)
        {
            XCoordinates = x;
            YCoordinates = y;
            Width = width;
            Height = height;
            list = lines;
        }

        public string ToStr()
        {
            string str = Id.ToString() + " " + Value + " " +
                         Select.ToString() + " " +
                         XCoordinates.ToString() + " " + 
                         YCoordinates.ToString() + " " + 
                         Width.ToString() + " " + 
                         Height.ToString() + 
                         Environment.NewLine;
            if (list != null)
                for (int i = 0; i < list.Count; i++)
                    str += list[i].Entity_1.ToString() + " " +
                           list[i].Entity_2.ToString() + " " +
                           list[i].Value + " " +
                           list[i].Id;// + " " +
                           //list[i].GetStyles().Pen.Color.ToString() + " " +
                           //list[i].GetStyles().Brush.ToString();
                           
            str += Environment.NewLine;
            return str;
        }
        public string ToTextbox()
        {
            string str = "1)ID элемента: " + Id.ToString() + " " + Environment.NewLine +
                         "2)Значение элемента: " + Value + " " + Environment.NewLine +
                         "3)Выделен элемента: " + Select.ToString() + " " + Environment.NewLine +
                         "4)Х-координата элемента: " + XCoordinates.ToString() + " " + Environment.NewLine +
                         "5)Y-координата элемента: " + YCoordinates.ToString() + " " + Environment.NewLine +
                         "6)Ширина элемента элемента: " + Width.ToString() + " " + Environment.NewLine +
                         "7)Высота элемента: " + Height.ToString() + Environment.NewLine + Environment.NewLine;
            
            return str;
        }
        public void DrawEntity() => Drawing.DrawNode(this);
    }
}
