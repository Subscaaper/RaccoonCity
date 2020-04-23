using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        Gameover frmGameover = new Gameover();
        public int directionX = 2;
        public int directionY = 1;
        public int points;

        public Random rand = new Random();

        //Ausführung des Programms Form1
        public Form1()
        {
            InitializeComponent();
        }

        //wird der Timer aktiviert, Spiel startet
        public void btnStart_Click(object sender, EventArgs e)
        {
            directionX = 2;
            directionY = 1;
            tmrSpiel.Start();
            picBall.Location = new Point(rand.Next(0, pnlSpiel.Width - picBall.Width),
                rand.Next(0, pnlSpiel.Height - picBall.Height));

            points = 0;
        }

        //Im Timer läuft das Spiel ab
        public void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //Bewegung des Balles
            picBall.Location = new Point(picBall.Location.X + directionX,
                picBall.Location.Y + directionY);

            //(If-Erklärung) Wenn  (0-407 >= 398) && (0-253 >= 0-223) && (0-238 <= 0-263) wenn alle 3 true sind 
            //Ball trifft auf Schläger
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerrechts.Width
                && picBall.Location.Y + picBall.Height >= picSchlägerrechts.Location.Y
                && picBall.Location.Y <= picSchlägerrechts.Location.Y + picSchlägerrechts.Height)
            {
                //directionX bekommt einen neuen Wert zugewiesen
                directionX = -directionX;
                points += 10;
                //Wenn die Ballsteuerung aktiviert ist, dann springt der Schlägerrechts an eine Zufällige Position, sobald er vom Ball getroffen wurde
                if (rdbBall.Checked)
                {
                    picSchlägerrechts.Location = new Point(pnlSpiel.Width - picSchlägerrechts.Width,
                        rand.Next(pnlSpiel.Height - picSchlägerrechts.Height));
                }
            }

            //Ball trifft auf linken Spielrand 
            if (picBall.Location.X <= 0)
                //directionX bekommt einen neuen Wert zugewiesen
            {
                directionX = -directionX;
            }

            //Ball trifft auf unteren Spielrand 
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height
            )
            {
                directionY = -directionY;
            }

            //Ball trifft auf oberen Spielrand 
            if (picBall.Location.Y < 0
            ) /*Wenn die Distanz Y des Balls kleiner als 0 ist, dann ist DistanzY gleich -DistanzY */
            {
                directionY = -directionY;
            }

            //Ball trifft auf rechten Spielrand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                tmrSpiel.Stop();
                frmGameover.Show();
                frmGameover.SetPoints(points);
            }


            if (points % 50 == 0)
            {
                tmrSpiel.Interval = Math.Max(tmrSpiel.Interval - 20, 20);
                picBall.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }


            txtPunkte.Text =
                Convert.ToString(points); //Punkte sind als int definiert, werden zum darstellen in String konvertiert.
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Schläger ganz rechts ins Panel setzen
            //Ausgangsposition vom Schläger X und Y Koordinaten festlegen
            picSchlägerrechts.Location = new Point(pnlSpiel.Width - picSchlägerrechts.Width, pnlSpiel.Height / 2);

            //Scrollbar rechts Werte setzen
            vsbScrollbarrechts.Height = pnlSpiel.Height; //Höhe des Scrollbalkens = Höhe des Spielfeldes
            vsbScrollbarrechts.Location =
                new Point(pnlSpiel.Location.X + pnlSpiel.Width,
                    pnlSpiel.Location.Y); //Start Location wo die Scrollbar ist, wenn sich das 'Formular' öffnet
            vsbScrollbarrechts.Minimum = 0;
            vsbScrollbarrechts.Maximum =
                pnlSpiel.Height - picSchlägerrechts.Height +
                vsbScrollbarrechts.LargeChange; //Wie gross der Balken ist im Scrollbalken zum scrollen
            vsbScrollbarrechts.Value = picSchlägerrechts.Location.Y; //Wo der Balken ist zum Scrollen
        }

        //Scrollbar neben den Schläger setzen
        private void vsbScrollbarrechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerrechts.Location =
                new Point(picSchlägerrechts.Location.X,
                    vsbScrollbarrechts.Value); //Location ist 421,128 neue Location ist 428,0 
            vsbScrollbarrechts.Value =
                picSchlägerrechts.Location.Y; //Wert von value wird definiert, auf den Location Y Wert vom Schläger
        }

        // Spiel wird geschlossen
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Wenn Ballsteuerung ausgewählt ist, dann sind folgende Tasten aktiviert
        private void rdbBall_KeyDown(object sender, KeyEventArgs e)
        {
            if (rdbBall.Checked)
            {
                switch (e.KeyData)
                {
                    case Keys.P:
                        tmrSpiel.Stop();
                        break;
                    case Keys.S:
                        tmrSpiel.Start();
                        break;
                    case Keys.V:
                        if (directionY > directionX)
                        {
                            directionX = +directionX;
                            directionY = -directionY;
                        }
                        else
                        {
                            directionX = -directionX;
                            directionY = +directionY;
                        }

                        break;
                    case Keys.H:
                        if (directionX > directionY)
                        {
                            directionX = -directionX;
                            directionY = -directionY;
                        }
                        else
                        {
                            directionX = +directionX;
                            directionY = +directionY;
                        }

                        break;
                }
            }
        }

        /*override, das erste if aktiviert die Ballsteuerung mit Pfeiltasten bei der Ballsteuerung,
         das zweite if aktiviert die Ballsteuerung mit Pfeiltasten bei der Schlägersteuerung und das else, dass man mit den 
         Pfeiltasten nicht über die Elemente bewegt
         */
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (rdbSchläger.Checked)
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

            if (rdbBall.Checked)
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

            return base.ProcessDialogKey(keyData);
        }

        /*Wenn Radio Button markiert ist bei Schlägersteuerung,
        dann kann mit P und F das Spiel pausiert und wieder fortgesetzt werden */
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

        /*Wenn Radio Button markiert ist bei Schlägersteuerung,
        dann sind die RichtungsButtons unsichtbar und die Scrollbar sichtbar */
        private void rdbSchläger_CheckedChanged(object sender, EventArgs e)
        {
            vsbScrollbarrechts.Enabled = true;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnRight.Visible = false;
            btnLeft.Visible = false;
        }

        //Wenn Radio Button markiert ist bei Ballsteuerung, dann sind die RichtungsButtons sichtbar
        private void rdbBall_CheckedChanged(object sender, EventArgs e)
        {
            vsbScrollbarrechts.Enabled = false;
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnRight.Visible = true;
            btnLeft.Visible = true;
        }

        //Richtungsänderung wenn einer der Buttons geklickt wird, Up, Down, Right, Left

        private void btnUp_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y - 25);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y + 0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y + 0);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y + 25);
        }
    }
}