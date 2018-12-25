using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Cg_SixthProject
{
    public partial class MainForm : Form
    {
        Network network = new Network();
        StyleObject style_o;
        StyleLine style_l;
        bool drawing = false;
        MouseEventArgs e0, e1;
        Drawing bmp;
        public static byte fl_tools = 0;
        Entity entity = null;

        public MainForm()
        {
            InitializeComponent();
            bmp = new Drawing(BasicPictureBox.Width, BasicPictureBox.Height);
            Font font = new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Regular);
            Color color = Color.Black;
            object[] hatchStyle = Enum.GetValues(typeof(HatchStyle)).Cast<object>().ToArray();
            comboBoxHatchStyle.Items.AddRange(hatchStyle);
            object[] gradMode = Enum.GetValues(typeof(LinearGradientMode)).Cast<object>().ToArray();
            comboBoxGradMode.Items.AddRange(gradMode);
            object[] lineCapStyle = Enum.GetValues(typeof(LineCap)).Cast<object>().ToArray();
            comboBoxEndCap.Items.AddRange(lineCapStyle);
            style_o = new StyleObject(color, font, new SolidBrush(SetColorBrush.BackColor), new Pen(SetColorPen.BackColor, (float)WidthUpDown.Value), 0, false, Figure.Rectangle);
            style_o.myBrushTexture = new TextureBrush(new Bitmap("C:\\Users\\Valentin\\source\\repos\\Computer_Graphics\\Cg_SixthProject\\Cg_SixthProject\\bin\\Debug\\texture.bmp"));
            style_l = new StyleLine(color, font, new Pen(SetColorPen.BackColor, (float)WidthUpDown.Value));
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            byte flBrush = Convert.ToByte((sender as RadioButton).Tag);
            style_o.Choose = flBrush;
            label4.Visible = flBrush == 1;
            comboBoxHatchStyle.Visible = flBrush == 1;
            label3.Visible = flBrush == 3;
            comboBoxGradMode.Visible = flBrush == 3;
        }

        private void comboBoxEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            style_l.Pen.EndCap = (LineCap)comboBoxEndCap.SelectedItem;
            style_o.Pen.EndCap = (LineCap)comboBoxEndCap.SelectedItem;
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void comboBoxDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            style_l.Pen.DashStyle = (DashStyle)comboBoxDashStyle.SelectedIndex;
            style_o.Pen.DashStyle = (DashStyle)comboBoxDashStyle.SelectedIndex;
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
                    SavingAndLoading.LoadNetwork(MainSaveFileDialog.FileName, out network);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainSaveFileDialog.ShowDialog() == DialogResult.OK)
                    SavingAndLoading.SaveNetwork(MainSaveFileDialog.FileName, network);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Draw() => BasicPictureBox.Image = Drawing.Answer;

        private void WidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            style_o.Pen.Width = (float)WidthUpDown.Value;
            style_l.Pen.Width = (float)WidthUpDown.Value;
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void AlfaBrush_ValueChanged(object sender, EventArgs e)
        {
            byte alfa = (byte)AlfaBrush.Value;
            Color col = style_o.mySolidBrush.Color;
            byte R = col.R, G = col.G, B = col.B;
            style_o.mySolidBrush.Color = Color.FromArgb(alfa, R, G, B);
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void AlfaPen_ValueChanged(object sender, EventArgs e)
        {
            byte alfa = (byte)AlfaPen.Value;
            Color col = style_l.Pen.Color;
            byte R = col.R, G = col.G, B = col.B;
            style_l.Pen.Color = Color.FromArgb(alfa, R, G, B);
            col = style_o.Pen.Color;
            R = col.R; G = col.G; B = col.B;
            style_o.Pen.Color = Color.FromArgb(alfa, R, G, B);
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void SetColorBrush_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                SetColorBrush.BackColor = MainColorDialog.Color;
                style_o.mySolidBrush.Color = SetColorBrush.BackColor;
                MainColorDialog.Dispose();
            }
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void SetColorPen_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                SetColorPen.BackColor = MainColorDialog.Color;
                style_l.Pen.Color = SetColorPen.BackColor;
                style_o.Pen.Color = SetColorPen.BackColor;
                MainColorDialog.Dispose();
            }
        }

        private void comboBoxHatchStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            style_o.myHatchStyle = (HatchStyle)comboBoxHatchStyle.SelectedItem;
            style_o.myHatchBrush = new HatchBrush(style_o.myHatchStyle, style_o.Pen.Color, style_o.mySolidBrush.Color);
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void comboBoxGradMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            style_o.myLinearGradientMode = (LinearGradientMode)comboBoxGradMode.SelectedItem;
            style_o.myBrushGrad = new LinearGradientBrush(ClientRectangle, style_o.Pen.Color, style_o.mySolidBrush.Color, style_o.myLinearGradientMode);
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void BasicPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked && !checkBox3.Checked)
                style_o.Figure = Figure.Ellipse;
            else if (checkBox3.Checked && checkBox2.Checked)
                style_o.Figure = Figure.Rectangle;
            drawing = true;
            e0 = e;
            if (fl_tools == 3 && network.SeacrhNode(e0.X, e0.Y) == null)
                return;
            else if (fl_tools == 3 && network.SeacrhNode(e0.X, e0.Y) != null)
                network.SelectNode(e0.X, e0.Y);
        }

        private void BasicPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (fl_tools == 0)
                    bmp.Draw(fl_tools, ref e0, e, null, style_o);
                else if
                    (fl_tools == 3)
                    bmp.Draw(fl_tools, ref e0, e, style_l);
                else if (fl_tools == 2)
                    bmp.DrawMovingNode(ref e0, e, network);
                e1 = e;
            }
            Draw();
        }

        private void BasicPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            e1 = e;
            if (network.e1 == null && fl_tools == 3)
                network.DrawFigure();
            if (e.Button == MouseButtons.Right && network.SeacrhNode(e.X, e.Y) != null)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
                return;
            }
            drawing = false;
            bmp.GetImage = Drawing.Answer;
            StyleObject _clone_style_o = (StyleObject)style_o.Clone();
            StyleLine _clone_styleLine = (StyleLine)style_l.Clone();
            switch (fl_tools)
            {
                case 0:
                    network.AddNode(_clone_style_o, null, network.entities.Count, e0.X, e0.Y, Drawing.Width_Node, Drawing.Height_Node);
                    break;
                case 1:
                    network.DeleteNode(e.X, e.Y);
                    network.DrawFigure();
                    break;
                case 2:
                    network.NewXY(e0.X, e0.Y, e.X, e.Y);
                    network.DrawFigure();
                    break;
                case 3:
                    if (network.SeacrhNode(e.X, e.Y) != null)
                    {
                        network.SelectNode(e.X, e.Y);
                        network.AddLine(_clone_styleLine);
                        network.DrawFigure();
                    }
                    break;
                case 4:
                   
                    break;
                case 6:
                    network.SelectNode(e.X, e.Y);
                    entity = network.SeacrhNode(e.X, e.Y);
                    if (entity != null && entity.Select)
                    {
                        ShowIntruments();
                    }
                    else
                        entity = null;
                    network.DrawFigure();
                    break;
            }
            Draw();
            network.e1 = null;
            network.e2 = null;
        }

        private void ShowIntruments()
        {
            if (entity != null && entity.Select) {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void AddEntityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fl_tools = Convert.ToByte((sender as RadioButton).Tag);
            checkBox1.Visible = fl_tools == 0;
            checkBox2.Visible = fl_tools == 0;
            checkBox3.Visible = fl_tools == 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
                style_o.Figure = Figure.Ellipse;
            }
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void Text_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                style_o.Font = fontDialog1.Font;
                style_l.Font = fontDialog1.Font;
                fontDialog1.Dispose();
            }
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteForm writeForm = new WriteForm();
            if (writeForm.ShowDialog() == DialogResult.OK)
            {
                string text = writeForm.TextSend.Text;
                Entity entity = network.SeacrhNode(e1.X, e1.Y);
                entity.Value = text;
            }
            network.DrawFigure();
            Draw();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            WriteForm writeForm = new WriteForm();
            Entity entity = network.SeacrhNode(e1.X, e1.Y);
            writeForm.TextSend.Text = entity.ToTextbox();
            writeForm.ShowDialog();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                style_o.Figure = Figure.Rectangle;
            }
            if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteLineRadioButton_Click(object sender, EventArgs e)
        {
            network.DeleteLine();
            network.DrawFigure();
            network.DrawFigure();
            Draw();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { style_o.Fill = checkBox1.Checked; if (entity != null)
            {
                entity.style = (StyleObject)style_o.Clone();
                network.DrawFigure();
                Draw();
            }
        }
        }
}
