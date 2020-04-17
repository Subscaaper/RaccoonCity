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
        public int pointsPlayer;
        public int pointsCPU;
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

            pointsPlayer = 0;
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
            }

            //Ball trifft auf linken Spielrand 
            if (picBall.Location.X <= 0)
            {
                directionX = -directionX;
                pointsPlayer += 10;
            }

            //Ball trifft auf unteren Spielrand 
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height
            )
            {
                directionY = -directionY;
            }

            //Ball trifft auf oberen Spielrand 
            if (picBall.Location.Y < 0
            )
            {
                directionY = -directionY;
            }

            //Ball trifft auf rechten Spielrand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                pointsCPU += 10;
            }


            if (picBall.Location.Y < pnlSpiel.Height / 2)
            {
                picCPU.Location = new Point(pnlSpiel.Width - picCPU.Width,
                    rand.Next(pnlSpiel.Height - picCPU.Height));
            }

            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picCPU.Width
                && picBall.Location.Y + picBall.Height >= picCPU.Location.Y
                && picBall.Location.Y <= picCPU.Location.Y + picCPU.Height)
            {
            }

            txtPunkte.Text =
                Convert.ToString(
                    pointsCPU); //Punkte sind als int definiert, werden zum darstellen in String konvertiert.
            txtPunktePlayer.Text =
                Convert.ToString(pointsPlayer);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Schläger ganz rechts ins Panel setzen //Ausgangsposition vom Schläger X und Y Koordinaten 489, 128
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


        //override, dass man nicht über die elemente fährt
         
        protected override bool ProcessDialogKey(Keys keyData)
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

            return base.ProcessDialogKey(keyData);
        }
        
        //Spiel pausieren und fortsetzen
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.F:
                    tmrSpiel.Start();
                    break;
            }

           
    }
}

