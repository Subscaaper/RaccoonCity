using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Ping_Pong
{
    public partial class Gameover : Form 
    {
        public Gameover()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}