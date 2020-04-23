using System;
using System.IO;
using System.Windows.Forms;


namespace Ping_Pong
{
    public partial class Gameover : Form
    {
        private static string filename = "Rangliste.txt";
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
        //Funktion um sich in die Rangliste eintragen zu können
        private void btnEintragen_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            
            //Eintrag in die Rangliste
            string text = String.Format("{0}, {1}, {2},", lblPunkte.Text, name, DateTime.Today.ToString("dd-MM-yy")) +
                Environment.NewLine;
            File.AppendAllText(path, text);
            lblErgebnisse.Text = File.ReadAllText(Application.StartupPath + filename);

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