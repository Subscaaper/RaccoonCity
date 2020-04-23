using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schachbrett
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Chessboard((int) nudAnzahlZahlen.Value);
        }

        private void Chessboard(int anzahl)
        {
            int brettbreite = pnlSchachbrett.Width;
            int bretthoehe = pnlSchachbrett.Height;
            int zellenbreite = brettbreite / anzahl;
            int zellenhoehe = bretthoehe / anzahl;
            bool geradeZeile = true;

            //Schachbrett leeren um neue labels zu generieren
            pnlSchachbrett.Controls.Clear(); 
            for (var y = 0; y + zellenhoehe <= bretthoehe; y = y + zellenhoehe)
            {
                var startpunktx = geradeZeile ? zellenbreite : 0;
                geradeZeile = !geradeZeile;
                for (var x = startpunktx; x + zellenbreite <= brettbreite; x = x + (2 * zellenbreite))
                {
                    var zelle = new Label
                    {
                        BackColor = Color.Black,
                        Location = new Point(x, y),
                        Width = zellenbreite,
                        Height = zellenhoehe
                    };
                    pnlSchachbrett.Controls.Add(zelle);
                }
            }
        }
    }
}