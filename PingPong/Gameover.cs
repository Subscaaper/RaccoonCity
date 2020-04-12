using System;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Gameover : Form
    {
        private static string filename = "scoreboard_pingpong.txt";
        private static string path = Application.StartupPath + filename;

        public Gameover()
        {
            InitializeComponent();
        }

        //Zurück zum Spiel
        private void btnzurück_Click(object sender, EventArgs e)
        {
            Hide();
        }
        //Text eintragen in Rangliste
        private void btnEintragen_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            //string createText = String.Format("{0}, {1}, {2},", lblPunkte.Text, name, DateTime.Now) + Environment.NewLine;
            lblErgebnisse.Text +=
                String.Format("{0}, {1}, {2},", lblPunkte.Text, name, DateTime.Today.ToString("dd-MM-yy")) +
                Environment.NewLine;

            /*File.AppendAllText(path, createText);
             lblErgebnisse.Text = File.ReadAllText(Application.StartupPath + filename);*/
        }

        public void SetPoints(int points)
        {
            lblPunkte.Text = Convert.ToString(points);
        }
    }
}