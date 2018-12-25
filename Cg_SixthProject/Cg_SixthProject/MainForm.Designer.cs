namespace Cg_SixthProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SetColorBrush = new System.Windows.Forms.Button();
            this.SetColorPen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AlfaBrush = new System.Windows.Forms.NumericUpDown();
            this.AlfaPen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEndCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGradMode = new System.Windows.Forms.ComboBox();
            this.comboBoxHatchStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDashStyle = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pointer = new System.Windows.Forms.RadioButton();
            this.Text = new System.Windows.Forms.RadioButton();
            this.DeleteLineRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteEntityRadioButton = new System.Windows.Forms.RadioButton();
            this.AddLineRadioButton = new System.Windows.Forms.RadioButton();
            this.MoveEntityRadioButton = new System.Windows.Forms.RadioButton();
            this.AddEntityRadioButton = new System.Windows.Forms.RadioButton();
            this.MainColorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicPictureBox = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.MainMenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlfaBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlfaPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.nodeToolStripMenuItem,
            this.lineToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenuStrip.Size = new System.Drawing.Size(1924, 31);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // nodeToolStripMenuItem
            // 
            this.nodeToolStripMenuItem.Name = "nodeToolStripMenuItem";
            this.nodeToolStripMenuItem.Size = new System.Drawing.Size(12, 25);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(12, 25);
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.checkBox3);
            this.MainPanel.Controls.Add(this.checkBox2);
            this.MainPanel.Controls.Add(this.SetColorBrush);
            this.MainPanel.Controls.Add(this.SetColorPen);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.checkBox1);
            this.MainPanel.Controls.Add(this.AlfaBrush);
            this.MainPanel.Controls.Add(this.AlfaPen);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.WidthUpDown);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.comboBoxEndCap);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.comboBoxGradMode);
            this.MainPanel.Controls.Add(this.comboBoxHatchStyle);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.comboBoxDashStyle);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1924, 136);
            this.MainPanel.TabIndex = 10;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(134, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 24);
            this.checkBox3.TabIndex = 57;
            this.checkBox3.Text = "Rectangle";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(134, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 24);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Ellipse";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // SetColorBrush
            // 
            this.SetColorBrush.BackColor = System.Drawing.Color.Aqua;
            this.SetColorBrush.Location = new System.Drawing.Point(965, 86);
            this.SetColorBrush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetColorBrush.Name = "SetColorBrush";
            this.SetColorBrush.Size = new System.Drawing.Size(40, 37);
            this.SetColorBrush.TabIndex = 56;
            this.SetColorBrush.UseVisualStyleBackColor = false;
            this.SetColorBrush.Click += new System.EventHandler(this.SetColorBrush_Click);
            // 
            // SetColorPen
            // 
            this.SetColorPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SetColorPen.Location = new System.Drawing.Point(912, 87);
            this.SetColorPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetColorPen.Name = "SetColorPen";
            this.SetColorPen.Size = new System.Drawing.Size(40, 37);
            this.SetColorPen.TabIndex = 55;
            this.SetColorPen.UseVisualStyleBackColor = false;
            this.SetColorPen.Click += new System.EventHandler(this.SetColorPen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(924, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Transparent";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 77);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 24);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Fill";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AlfaBrush
            // 
            this.AlfaBrush.Location = new System.Drawing.Point(996, 43);
            this.AlfaBrush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlfaBrush.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AlfaBrush.Name = "AlfaBrush";
            this.AlfaBrush.Size = new System.Drawing.Size(76, 26);
            this.AlfaBrush.TabIndex = 53;
            this.AlfaBrush.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AlfaBrush.ValueChanged += new System.EventHandler(this.AlfaBrush_ValueChanged);
            // 
            // AlfaPen
            // 
            this.AlfaPen.Location = new System.Drawing.Point(912, 43);
            this.AlfaPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlfaPen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AlfaPen.Name = "AlfaPen";
            this.AlfaPen.Size = new System.Drawing.Size(76, 26);
            this.AlfaPen.TabIndex = 52;
            this.AlfaPen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AlfaPen.ValueChanged += new System.EventHandler(this.AlfaPen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Pen.Width";
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Location = new System.Drawing.Point(1017, 93);
            this.WidthUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(78, 26);
            this.WidthUpDown.TabIndex = 48;
            this.WidthUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.WidthUpDown.ValueChanged += new System.EventHandler(this.WidthUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "End Cap";
            // 
            // comboBoxEndCap
            // 
            this.comboBoxEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndCap.FormattingEnabled = true;
            this.comboBoxEndCap.Location = new System.Drawing.Point(409, 34);
            this.comboBoxEndCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEndCap.Name = "comboBoxEndCap";
            this.comboBoxEndCap.Size = new System.Drawing.Size(234, 28);
            this.comboBoxEndCap.TabIndex = 46;
            this.comboBoxEndCap.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hatch Style";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Linear Gradient Mode";
            this.label3.Visible = false;
            // 
            // comboBoxGradMode
            // 
            this.comboBoxGradMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGradMode.FormattingEnabled = true;
            this.comboBoxGradMode.Location = new System.Drawing.Point(654, 34);
            this.comboBoxGradMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGradMode.Name = "comboBoxGradMode";
            this.comboBoxGradMode.Size = new System.Drawing.Size(228, 28);
            this.comboBoxGradMode.TabIndex = 43;
            this.comboBoxGradMode.Visible = false;
            this.comboBoxGradMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxGradMode_SelectedIndexChanged);
            // 
            // comboBoxHatchStyle
            // 
            this.comboBoxHatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHatchStyle.FormattingEnabled = true;
            this.comboBoxHatchStyle.Location = new System.Drawing.Point(654, 91);
            this.comboBoxHatchStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxHatchStyle.Name = "comboBoxHatchStyle";
            this.comboBoxHatchStyle.Size = new System.Drawing.Size(228, 28);
            this.comboBoxHatchStyle.TabIndex = 42;
            this.comboBoxHatchStyle.Visible = false;
            this.comboBoxHatchStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxHatchStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Dash Style";
            // 
            // comboBoxDashStyle
            // 
            this.comboBoxDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDashStyle.FormattingEnabled = true;
            this.comboBoxDashStyle.Items.AddRange(new object[] {
            "Custom",
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.comboBoxDashStyle.Location = new System.Drawing.Point(409, 91);
            this.comboBoxDashStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDashStyle.Name = "comboBoxDashStyle";
            this.comboBoxDashStyle.Size = new System.Drawing.Size(234, 28);
            this.comboBoxDashStyle.TabIndex = 40;
            this.comboBoxDashStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDashStyle_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(241, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(156, 132);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brush";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(16, 94);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(142, 24);
            this.radioButton9.TabIndex = 3;
            this.radioButton9.Tag = "3";
            this.radioButton9.Text = "Gradient Brush";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(16, 71);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(133, 24);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Tag = "2";
            this.radioButton8.Text = "Texture Brush";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(16, 46);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(123, 24);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Tag = "1";
            this.radioButton7.Text = "Hatch Brush";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 22);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(115, 24);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "0";
            this.radioButton6.Text = "Solid Brush";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pointer);
            this.groupBox2.Controls.Add(this.Text);
            this.groupBox2.Controls.Add(this.DeleteLineRadioButton);
            this.groupBox2.Controls.Add(this.DeleteEntityRadioButton);
            this.groupBox2.Controls.Add(this.AddLineRadioButton);
            this.groupBox2.Controls.Add(this.MoveEntityRadioButton);
            this.groupBox2.Controls.Add(this.AddEntityRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 132);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object";
            // 
            // Pointer
            // 
            this.Pointer.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pointer.AutoSize = true;
            this.Pointer.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pointer.Image = global::Cg_SixthProject.Properties.Resources.Pointer;
            this.Pointer.Location = new System.Drawing.Point(32, 52);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(24, 24);
            this.Pointer.TabIndex = 11;
            this.Pointer.Tag = "6";
            this.Pointer.UseVisualStyleBackColor = true;
            this.Pointer.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            // 
            // Text
            // 
            this.Text.Appearance = System.Windows.Forms.Appearance.Button;
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Image = global::Cg_SixthProject.Properties.Resources.Text;
            this.Text.Location = new System.Drawing.Point(62, 54);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(22, 22);
            this.Text.TabIndex = 10;
            this.Text.Tag = "5";
            this.Text.UseVisualStyleBackColor = true;
            this.Text.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // DeleteLineRadioButton
            // 
            this.DeleteLineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.DeleteLineRadioButton.AutoSize = true;
            this.DeleteLineRadioButton.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLineRadioButton.Image = global::Cg_SixthProject.Properties.Resources.LineMinus;
            this.DeleteLineRadioButton.Location = new System.Drawing.Point(90, 56);
            this.DeleteLineRadioButton.Name = "DeleteLineRadioButton";
            this.DeleteLineRadioButton.Size = new System.Drawing.Size(23, 23);
            this.DeleteLineRadioButton.TabIndex = 9;
            this.DeleteLineRadioButton.Tag = "4";
            this.DeleteLineRadioButton.UseVisualStyleBackColor = true;
            this.DeleteLineRadioButton.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            this.DeleteLineRadioButton.Click += new System.EventHandler(this.DeleteLineRadioButton_Click);
            // 
            // DeleteEntityRadioButton
            // 
            this.DeleteEntityRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.DeleteEntityRadioButton.AutoSize = true;
            this.DeleteEntityRadioButton.Image = global::Cg_SixthProject.Properties.Resources.DeleteNode_0;
            this.DeleteEntityRadioButton.Location = new System.Drawing.Point(34, 25);
            this.DeleteEntityRadioButton.Name = "DeleteEntityRadioButton";
            this.DeleteEntityRadioButton.Size = new System.Drawing.Size(22, 22);
            this.DeleteEntityRadioButton.TabIndex = 3;
            this.DeleteEntityRadioButton.Tag = "1";
            this.DeleteEntityRadioButton.UseVisualStyleBackColor = true;
            this.DeleteEntityRadioButton.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            // 
            // AddLineRadioButton
            // 
            this.AddLineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AddLineRadioButton.AutoSize = true;
            this.AddLineRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddLineRadioButton.Image = global::Cg_SixthProject.Properties.Resources.LinePlus;
            this.AddLineRadioButton.Location = new System.Drawing.Point(90, 27);
            this.AddLineRadioButton.Name = "AddLineRadioButton";
            this.AddLineRadioButton.Size = new System.Drawing.Size(23, 23);
            this.AddLineRadioButton.TabIndex = 8;
            this.AddLineRadioButton.Tag = "3";
            this.AddLineRadioButton.UseVisualStyleBackColor = false;
            this.AddLineRadioButton.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            // 
            // MoveEntityRadioButton
            // 
            this.MoveEntityRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MoveEntityRadioButton.AutoSize = true;
            this.MoveEntityRadioButton.Image = global::Cg_SixthProject.Properties.Resources.MoveNode_0;
            this.MoveEntityRadioButton.Location = new System.Drawing.Point(62, 26);
            this.MoveEntityRadioButton.Name = "MoveEntityRadioButton";
            this.MoveEntityRadioButton.Size = new System.Drawing.Size(22, 22);
            this.MoveEntityRadioButton.TabIndex = 1;
            this.MoveEntityRadioButton.Tag = "2";
            this.MoveEntityRadioButton.UseVisualStyleBackColor = true;
            this.MoveEntityRadioButton.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            // 
            // AddEntityRadioButton
            // 
            this.AddEntityRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AddEntityRadioButton.AutoSize = true;
            this.AddEntityRadioButton.Image = global::Cg_SixthProject.Properties.Resources.AddNode;
            this.AddEntityRadioButton.Location = new System.Drawing.Point(6, 25);
            this.AddEntityRadioButton.Name = "AddEntityRadioButton";
            this.AddEntityRadioButton.Size = new System.Drawing.Size(22, 22);
            this.AddEntityRadioButton.TabIndex = 2;
            this.AddEntityRadioButton.Tag = "0";
            this.AddEntityRadioButton.UseVisualStyleBackColor = true;
            this.AddEntityRadioButton.CheckedChanged += new System.EventHandler(this.AddEntityRadioButton_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyToolStripMenuItem,
            this.toolStripMenuItem2,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 94);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.propertyToolStripMenuItem.Text = "Add Text";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 30);
            this.toolStripMenuItem2.Text = "Information";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // BasicPictureBox
            // 
            this.BasicPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BasicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BasicPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicPictureBox.Location = new System.Drawing.Point(0, 31);
            this.BasicPictureBox.Name = "BasicPictureBox";
            this.BasicPictureBox.Size = new System.Drawing.Size(1924, 1019);
            this.BasicPictureBox.TabIndex = 6;
            this.BasicPictureBox.TabStop = false;
            this.BasicPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BasicPictureBox_MouseDown);
            this.BasicPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BasicPictureBox_MouseMove);
            this.BasicPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BasicPictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BasicPictureBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlfaBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlfaPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BasicPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.PictureBox BasicPictureBox;
        private System.Windows.Forms.ToolStripMenuItem nodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.RadioButton DeleteEntityRadioButton;
        private System.Windows.Forms.RadioButton AddEntityRadioButton;
        private System.Windows.Forms.RadioButton DeleteLineRadioButton;
        private System.Windows.Forms.RadioButton AddLineRadioButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AlfaBrush;
        private System.Windows.Forms.NumericUpDown AlfaPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEndCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGradMode;
        private System.Windows.Forms.ComboBox comboBoxHatchStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDashStyle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColorDialog MainColorDialog;
        private System.Windows.Forms.Button SetColorBrush;
        private System.Windows.Forms.Button SetColorPen;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.RadioButton Pointer;
        private System.Windows.Forms.RadioButton Text;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.RadioButton MoveEntityRadioButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

