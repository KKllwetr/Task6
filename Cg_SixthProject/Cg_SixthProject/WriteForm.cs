using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cg_SixthProject
{
    public partial class WriteForm : Form
    {
        public WriteForm()
        {
            InitializeComponent();
            
        }
        public TextBox TextSend { get { return textBox1; } }
    }
}
