using System;
using System.IO;
using System.Windows.Forms;


namespace Ping_Pong
{
    public partial class Gameover : Form
    {
        

        public Gameover()
        {
            InitializeComponent();
        }

        //Zurück zum Spiel
        private void btnzurück_Click(object sender, EventArgs e)
        {
            Hide();
        }
        //Funktion um sich in die Rangliste eintragen zu können
        private void btnEintragen_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            //Eintrag in die Rangliste
            lblErgebnisse.Text +=
                String.Format("{0}, {1}, {2},", lblPunkte.Text, name, DateTime.Today.ToString("dd-MM-yy")) +
                Environment.NewLine;
            
            //Rangliste sortieren
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
        
        //Punkte sind als int definiert, werden zum darstellen in String konvertiert.
        public void SetPoints(int points)
        {
            lblPunkte.Text = Convert.ToString(points);
        }

        //die zuvor eingegebenen Einträge in der Rangliste werden angezeigt, sofern eine Liste vorhanden ist.
        private void Gameover_Load(object sender, EventArgs e)
        {
            //Wenn ein File schon existiert auf folgendem Pfad, dann soll er es öffnen im lblErgebnisse
            if (File.Exists(Application.StartupPath + "\\Rangliste.txt"))
            {
                lblErgebnisse.Text = File.ReadAllText(Application.StartupPath + "\\Rangliste.txt");
            }

        }
    }
}