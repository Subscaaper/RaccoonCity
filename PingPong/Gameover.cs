using System;
using System.Windows.Forms;
using System.IO;

namespace Ping_Pong
{
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }


        private void btnzurück_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnEintragen_Click(object sender, EventArgs e)
        {
           
            lblErgebnisse.Text += String.Format("{0}, {1}, {2},", lblPunkte.Text, txtName, DateTime.Now);
        
            string[] rangliste = lblErgebnisse.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            string[] punkte = new string[rangliste.Length / 3];
            string[] textinhalt = new string[rangliste.Length];
            int p = 0;
            lblErgebnisse.Text = "";
            for (int j = 0; j < punkte.Length; j++)
            {
                punkte[j] = rangliste[j * 3];
            }
            Array.Sort(punkte);
            Array.Reverse(punkte);
            for (int j = 0; j < punkte.Length; j++)
            {
                for (int i = 0; i < rangliste.Length - 2; i++)
                {
                    if (String.Equals(punkte[j], rangliste[i]))
                    {
                        textinhalt[p] = rangliste[i];
                        textinhalt[p + 1] = rangliste[i + 1];
                        textinhalt[p + 2] = rangliste[i + 2];
                        p += 3;
                        rangliste[i] = "";
                        i += 2;                    }
                }
            }
            for (int i = 0; i < textinhalt.Length-1; i++)
            {
                lblErgebnisse.Text += String.Format("{0,6} {1,15}   {2:d}\n", textinhalt[i++], textinhalt[i++], textinhalt[i]);
            }
        }
        
         

        public void SetPoints(int points)
        {
            lblPunkte.Text = Convert.ToString(points);
        }

       
    }
}