using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cg_SixthProject
{
    public class Drawing
    {
        static Bitmap _current_bitmap;
        Bitmap bitmap;
        static Graphics g;
        public static Bitmap Answer { get { return _current_bitmap; } }
        public Bitmap GetImage { set { bitmap = value; } }
        public static int Width_Node { get; set; }
        public static int Height_Node { get; set; }

        public Drawing(int width, int height)
        {
            _current_bitmap = new Bitmap(width, height);
            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);
        }


        public static void DrawNode(Entity entity)
        {
            g = Graphics.FromImage(_current_bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            StyleObject e  = (StyleObject)entity.style.Clone();
            e.Pen.Color = Color.Red;
            if (entity.style.Figure == Figure.Rectangle)
            {
                if (entity.style.Fill)
                    g.FillRectangle(entity.style.myBrush, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
                if (entity.Select)
                    g.DrawRectangle(e.Pen, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
                else
                    g.DrawRectangle(entity.style.Pen, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
            }
            else if (entity.style.Figure == Figure.Ellipse)
            {
                if (entity.style.Fill)
                    g.FillEllipse(entity.style.myBrush, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
                if (entity.Select)
                    g.DrawEllipse(e.Pen, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
                else
                    g.DrawEllipse(entity.style.Pen, entity.XCoordinates, entity.YCoordinates, entity.Width, entity.Height);
            }
            if (entity.Value != null)
            {
                SizeF size = g.MeasureString(entity.Value, entity.style.Font);
                g.DrawString(entity.Value.ToString(), entity.style.Font, Brushes.Black, entity.XCoordinates + entity.Width / 4, entity.YCoordinates + entity.Height / 4);
            }
        }

        public static void DrawNetwork(Network network)
        {
            g = Graphics.FromImage(_current_bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.White);
            for (int i = 0; i < network.entities.Count; i++)
            {
                if (network.entities[i].list != null)
                    for (int j = 0; j < network.entities[i].list.Count; j++)
                    {
                        int x1 = network.entities[i].XCoordinates + network.entities[i].Width / 2;
                        int y1 = network.entities[i].YCoordinates + +network.entities[i].Height / 2;
                        for (int z = 0; z < network.entities.Count; z++)
                            if (network.entities[i].list[j].Entity_2 == network.entities[z].Id && network.entities[i].start)
                            {
                                int x2 = network.entities[z].XCoordinates + network.entities[z].Width / 2;
                                int y2 = network.entities[z].YCoordinates + network.entities[z].Height / 2;
                                var (p1, p2) = SearchPoint(new Point(x1, y1), new Point(x2, y2), network.entities[i], network.entities[z]);
                                g.DrawLine(network.entities[i].list[j].GetStyles().Pen, p1, p2);
                            }

                    }
            }
            for (int m = 0; m < network.entities.Count; m++)
                network.entities[m].DrawEntity();
        }

        private static (Point p1, Point p2) SearchPoint(Point point1, Point point2, Entity entity1, Entity entity2)
        {
            var result = (p1: new Point(), p2: new Point());
            Point point_left = point1.X < point2.X ? point1 : point2;
            Point point_right = point1.X > point2.X ? point1 : point2;
            Entity entity_left = entity1.XCoordinates + entity1.Width / 2 < entity2.XCoordinates + entity2.Width / 2 ? entity1 : entity2;
            Entity entity_right = entity1.XCoordinates + entity1.Width / 2 > entity2.XCoordinates + entity2.Width / 2 ? entity1 : entity2;
            List<Point> ponts_line = new List<Point>();
            for (int i = point_left.X; i < point_right.X; i++)
                ponts_line.Add(new Point(i, (int)SearchY(i, point_left, point_right)));
            for (int j = 0; j < ponts_line.Count; j++)
                if (entity_left.r.Contains(ponts_line[j]))
                    result.p1 = ponts_line[j];
            for (int j = ponts_line.Count - 1; j > 0; j--)
                if (entity_right.r.Contains(ponts_line[j]))
                    result.p2 = ponts_line[j];
            return result;
        }

        private static float SearchY(int x, Point point1, Point point2)
        {
            float a = point2.Y - point1.Y;
            float b = point2.X - point1.X;
            float k = (a / b);
            float p = k * (x - point1.X) + point1.Y;
            return p;
        }



        public static void SetBrush(StyleObject flBrush)
        {
            switch (flBrush.Choose)
            {
                case 0:
                    flBrush.myBrush = flBrush.mySolidBrush;
                    break;
                case 1:
                    flBrush.myBrush = flBrush.myHatchBrush;
                    break;
                case 2:
                    flBrush.myBrush = flBrush.myBrushTexture;
                    break;
                case 3:
                    flBrush.myBrush = flBrush.myBrushGrad;
                    break;
            }
        }

        public void Draw(byte fl_tools, ref MouseEventArgs e0, MouseEventArgs e, StyleLine style = null, StyleObject style2 = null)
        {
            _current_bitmap = (Bitmap)bitmap.Clone();
            g = Graphics.FromImage(_current_bitmap);
            switch (fl_tools)
            {
                case 3:
                    g.DrawLine(style.Pen, P(e0), P(e));
                    break;
                case 0:
                    if (style2.Figure == Figure.Rectangle)
                    {
                        if (!style2.Fill)
                            g.DrawRectangle(style2.Pen, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                        else
                        {
                            SetBrush(style2);
                            g.DrawRectangle(style2.Pen, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                            g.FillRectangle(style2.myBrush, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                        }
                    }
                    else if (style2.Figure == Figure.Ellipse)
                    {
                        if (!style2.Fill)
                            g.DrawEllipse(style2.Pen, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                        else
                        {
                            SetBrush(style2);
                            g.DrawEllipse(style2.Pen, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                            g.FillEllipse(style2.myBrush, e0.X, e0.Y, e.X - e0.X, e.Y - e0.Y);
                        }
                    }
                    Width_Node = e.X - e0.X;
                    Height_Node = e.Y - e0.Y;
                    break;
            }
        }

        public void DrawMovingNode(ref MouseEventArgs e0, MouseEventArgs e, Network network)
        {
            _current_bitmap = (Bitmap)bitmap.Clone();
            g = Graphics.FromImage(_current_bitmap);
            Entity entity = network.SeacrhNode(e0.X, e0.Y);
            if (entity == null)
                return;
            if (entity.style.Figure == Figure.Rectangle)
            {
                if (!entity.style.Fill)
                    g.DrawRectangle(entity.style.Pen, e.X, e.Y, entity.Width, entity.Height);
                else
                {
                    g.DrawRectangle(entity.style.Pen, e.X, e.Y, entity.Width, entity.Height);
                    g.FillRectangle(entity.style.myBrush, e.X, e.Y, entity.Width, entity.Height);
                }
            }
            else if (entity.style.Figure == Figure.Ellipse)
            {
                if (!entity.style.Fill)
                    g.DrawEllipse(entity.style.Pen, e.X, e.Y, entity.Width, entity.Height);
                else
                {
                    g.DrawEllipse(entity.style.Pen, e.X, e.Y, entity.Width, entity.Height);
                    g.FillEllipse(entity.style.myBrush, e.X, e.Y, entity.Width, entity.Height);
                }
            }
        }

        static Point P(MouseEventArgs e) => new Point(e.X, e.Y);
    }
}
