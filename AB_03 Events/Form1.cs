using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AB_03_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtausgabe_Click(object sender, EventArgs e)
        {
            txtausgabe.Enabled = true;
            txtausgabe.Text += "Klick" + Environment.NewLine;
        }
    }
}