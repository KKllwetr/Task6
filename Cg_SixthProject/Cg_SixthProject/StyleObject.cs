using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cg_SixthProject
{
    public enum Figure : byte
    {
        Ellipse,
        Rectangle
    }

    public class StyleObject: Style, ICloneable
    {
        public Pen Pen { get; set; }
        public Figure Figure { get; set; }
        public HatchStyle myHatchStyle { get; set; }
        public LinearGradientMode myLinearGradientMode { get; set; }
        public Brush myBrush { get; set; }
        public SolidBrush mySolidBrush { get; set; }
        public TextureBrush myBrushTexture { get; set; }
        public HatchBrush myHatchBrush { get; set; }
        public LinearGradientBrush myBrushGrad { get; set; }
        public byte Choose { get; set; } 
        public bool Fill { get; set; }
        public object Clone()
        {
            Font font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style);
            Pen pen_new = new Pen(this.Pen.Brush, this.Pen.Width);
            pen_new.EndCap = this.Pen.EndCap;
            pen_new.DashStyle = this.Pen.DashStyle;
            SolidBrush solidBrush_new = new SolidBrush(this.mySolidBrush.Color);
            return new StyleObject(c, font, solidBrush_new, pen_new, this.Choose, this.Fill, this.Figure);
            {/*Font font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style);
            Pen pen_new = new Pen(this.Pen.Brush,this.Pen.Width);
            Brush brush_new = (Brush)myBrush.Clone();
            SolidBrush solidBrush_new = new SolidBrush(this.mySolidBrush.Color) ?? null;
            TextureBrush myBrushTexture_new = new TextureBrush(this.myBrushTexture.Image) ?? null;
            HatchBrush myHatchBrush_new = new HatchBrush(myHatchBrush.HatchStyle,pen_new.Color,solidBrush_new.Color) ?? null;
            LinearGradientBrush myBrushGrad_new = new LinearGradientBrush(this.myBrushGrad.Rectangle,pen_new.Color,solidBrush_new.Color,myLinearGradientMode) ?? null;
            return new StyleObject(
                
                font,
                c,
                pen_new,
                Figure,
                myHatchStyle,
                myLinearGradientMode,
                myBrush = null,
                mySolidBrush = solidBrush_new,
                myBrushTexture = myBrushTexture_new,
                myHatchBrush = myHatchBrush_new,
                myBrushGrad = myBrushGrad_new,
                Choose = this.Choose,
                Fill = this.Fill
            );*/
            }
        }

        public StyleObject(Color c, Font f, SolidBrush brush, Pen pen, byte choose, bool fill, Figure figure): base(c,f)
        {
            myBrush = brush;
            mySolidBrush = brush;
            Choose = choose;
            Fill = fill;
            Pen = pen;
            Figure = figure;
        }

        public StyleObject(Font f, Color c,Pen pen,Figure figure, HatchStyle hatchStyle, LinearGradientMode myLinearGradientMode, Brush myBrush,SolidBrush solidBrush,TextureBrush textureBrush,HatchBrush hatchBrush, LinearGradientBrush linearGradientBrush,byte choose,bool fill) : base(c, f)
        {
            Pen = pen;
            Figure = figure;
            myHatchStyle = hatchStyle;
            this.myLinearGradientMode = myLinearGradientMode;
            this.myBrush = myBrush;
            mySolidBrush = solidBrush;
            myBrushTexture = textureBrush;
            myHatchBrush = hatchBrush;
            myBrushGrad = linearGradientBrush;
            Choose = choose;
            Fill = fill;
        }

        public StyleObject(Color c, Font f) : base(c,f){ }
    }
}
