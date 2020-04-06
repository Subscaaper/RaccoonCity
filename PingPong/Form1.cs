using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        Gameover frmGameover = new Gameover();
        public int directionX = 2;
        public int directionY = 1;
        public int points = 0;


        //Ausführung des Programms Form1
        public Form1()
        {
            InitializeComponent();
        }

        //Durch den Klick auf den Start Button, wird der Timer aktiviert
        public void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        //Im Timer läuft das Spiel ab
        public void tmrSpiel_Tick(object sender, EventArgs e)
        {
            /*Position wird berechnet, der Ort wo der Ball ist,(Location.X) plus die Distanz(directionX), ebenso
             (Location.Y) plus die Distanz(directionY), dadurch dass ein Timer läuft, bewegt sich der Ball immer nach diesem Grundprinzip*/
            picBall.Location = new Point(picBall.Location.X + directionX,
                picBall.Location.Y + directionY);

            /*(If-Erklärung) Wenn  0-407 >= 398 && 0-253 >= 0-223 && 0-238 <= 0-263*/

            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerrechts.Width
                && picBall.Location.Y + picBall.Height >= picSchlägerrechts.Location.Y
                && picBall.Location.Y <= picSchlägerrechts.Location.Y + picSchlägerrechts.Height)
            {
                //Hier wird der Wert für die Distanz X neu initialisiert, sprich DistanzX ist gleich -DistanzX, entspricht 0  und gibt 10 Punkte
                directionX =
                    -directionX; //Ball trifft auf rechten Spielrand (Schläger mit eingerechnet, aber noch nicht aktiviert)
                points += 10;
            }

            if (picBall.Location.X <= 0
            ) /*Wenn die Distanz X des Ball kleiner/gleich 0 ist, dann ist DistanzX gleich -DistanzX, entspricht 0 */
            {
                directionX = -directionX; //ball trifft auf linken Spielrand 
            }

            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height
            ) /*Wenn die Distanz Y des Balls grösser/gleich (Spielfeldhöhe - Ballhöhe),
            dann ist DistanzY gleich -DistanzY, entspricht 0 */
            {
                directionY = -directionY; //entspricht unterem Rand
            }

            if (picBall.Location.Y < 0
            ) /*Wenn die Distanz Y des Balls kleiner als 0 ist, dann ist DistanzY gleich -DistanzY, entspricht 0 */
            {
                directionY = -directionY; //entspricht oberem Rand
            }

            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                tmrSpiel.Stop();
                frmGameover.Show();
                frmGameover.SetPoints(points);
            }

            txtPunkte.Text =
                Convert.ToString(points); //Punkte sind als int definiert, werden zum darstellen in String konvertiert.
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Schläger ganz rechts ins Panel setzen //Ausgangsposition vom Schläger X und Y Koordinaten 422, 128
            picSchlägerrechts.Location = new Point(pnlSpiel.Width - picSchlägerrechts.Width, pnlSpiel.Height / 2);

            //Scrollbar rechts Werte setzen

            vsbScrollbarrechts.Height = pnlSpiel.Height; //Höhe des Scrollbalkens, Höhe des Spielfeldes
            vsbScrollbarrechts.Location =
                new Point(pnlSpiel.Location.X + pnlSpiel.Width,
                    pnlSpiel.Location.Y); //Start Location wird neu definiert, wenn das Spiel beginnt
            vsbScrollbarrechts.Minimum = 0;
            vsbScrollbarrechts.Maximum =
                pnlSpiel.Height - picSchlägerrechts.Height +
                vsbScrollbarrechts.LargeChange; //Wie gross der Balken ist im Scrollbalken zum scrollen
            vsbScrollbarrechts.Value = picSchlägerrechts.Location.Y; //Wo der Balken ist zum Scrollen
        }


        private void vsbScrollbarrechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerrechts.Location =
                new Point(picSchlägerrechts.Location.X,
                    vsbScrollbarrechts.Value); //Location ist 421,128 neue Location ist 428,0 
            vsbScrollbarrechts.Value =
                picSchlägerrechts.Location.Y; //Wert von value wird definiert, auf den Location Y Wert vom Schläger
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void rdbBall_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                    if (directionY > directionX)
                    {
                        directionX = 2;
                        directionY = -1;
                    }
                    else
                    {
                        directionX = -2;
                        directionY = 1;
                    }

                    break;
                case Keys.W:
                    if (directionX > directionY)
                    {
                        directionX = -2;
                        directionY = -1;
                    }
                    else
                    {
                        directionX = 2;
                        directionY = 1;
                    }

                    break;
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.F:
                    tmrSpiel.Start();
                    break;
            }
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (rdbBall.Checked == false)
            {
                switch (keyData)
                {
                    case Keys.Up:
                        return true;
                    case Keys.Down:
                        return true;
                    case Keys.Left:
                        return true;
                    case Keys.Right:
                        return true;
                }
            }

            else
            {
                switch (keyData)
                {
                    case Keys.Up:
                        picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y - 25);
                        return true;
                    case Keys.Down:
                        picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y + 25);
                        return true;
                    case Keys.Left:
                        picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y + 0);
                        return true;
                    case Keys.Right:
                        picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y + 0);
                        return true;
                    default:
                        return base.ProcessDialogKey(keyData);
                }
            }

            return base.ProcessDialogKey(keyData);
        }


        private void rdbSchläger_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.P:
                    tmrSpiel.Stop();
                    vsbScrollbarrechts.Enabled = false;
                    break;
                case Keys.F:
                    tmrSpiel.Start();
                    vsbScrollbarrechts.Enabled = true;
                    break;
            }
        }

        private void rdbSchläger_CheckedChanged(object sender, EventArgs e)
        {
            vsbScrollbarrechts.Enabled = true;
        }

        private void rdbBall_CheckedChanged(object sender, EventArgs e)
        {
            vsbScrollbarrechts.Enabled = false;
        }
    }
}