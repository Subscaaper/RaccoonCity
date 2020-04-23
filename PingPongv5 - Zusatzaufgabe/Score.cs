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
        public void SetPointsCPU(int pointsCPU)
        {
           
            lblPunkteCPU.Text = Convert.ToString(pointsCPU);
        }
        
        public void SetPointsCPlayer(int pointsPlayer)
        {
            lblPunktePlayer.Text = Convert.ToString(pointsPlayer);
        }


        private void btnretry_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
         
        }
    }
}