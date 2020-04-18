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
        Informationen FrmInformationen = new Informationen();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            txtausgabe.Text += "Klick" + Environment.NewLine;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtausgabe.Text += "Doppelklick" + Environment.NewLine;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtausgabe.Text += "Linke Maustaste runter" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtausgabe.Text += "Rechte Maustaste runter" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtausgabe.Text += "Mittlere Maustaste drücken" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtausgabe.Text += "Linke Maustaste hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtausgabe.Text += "Rechte Maustaste hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtausgabe.Text += "Mittlere Maustaste loslassen" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            txtausgabe.Text += e.KeyData + "Taste runter" + Environment.NewLine;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            txtausgabe.Text += "Taste hoch" + Environment.NewLine;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmInformationen.Show();
        }
    }
}