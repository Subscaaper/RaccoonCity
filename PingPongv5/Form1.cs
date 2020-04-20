using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        Gameover Score = new Gameover();
        public int directionX = 2;
        public int directionY = 1;
        public int pointsPlayer;
        public int pointsCPU;
        public int CPUdirectionX = 10;
        public int CPUdirectionY = 10;
        public Random rand = new Random();

        //Ausführung des Programms Form1
        public Form1()
        {
            InitializeComponent();
        }

        //wird der Timer aktiviert, Spiel startet
        public void btnStart_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(pnlSpiel.Width / 2, pnlSpiel.Height / 2);
            tmrSpiel.Start();
            pointsPlayer = 0;
            pointsCPU = 0;
        }

        //Nach dem ein Punkt erzielt wurde kann man weiter drücke um weiter zu spielen.
        private void button2_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
            picBall.Location = new Point(rand.Next(pnlSpiel.Width - picBall.Width),
                rand.Next(pnlSpiel.Height - picBall.Height));
        }

        // Spiel wird geschlossen
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Im Timer läuft das Spiel ab
        public void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //Bewegung des Balles
            picBall.Location = new Point(picBall.Location.X + directionX,
                picBall.Location.Y + directionY);

            //(If-Erklärung) Wenn  (0-466 >= 398) && (0-253 >= 0-223) && (0-311 <= 0-182) wenn alle 3 true sind 
            //Ball trifft auf Player Schläger
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerrechts.Width
                && picBall.Location.Y + picBall.Height >= picSchlägerrechts.Location.Y 
                && picBall.Location.Y <= picSchlägerrechts.Location.Y + picSchlägerrechts.Height)
            {
                directionX = -directionX;
            }

            //Wenn der Ball den CPUSchläger trifft
            if (picBall.Location.X <= picCPU.Width //trifft
                && picBall.Location.Y <= picCPU.Location.Y + picBall.Height //trifft
                && picBall.Location.Y >= picCPU.Location.Y - picCPU.Height - picBall.Height) //trifft
            {
                directionX = +directionX;
            }


            //Ball trifft auf linken Spielrand 
            if (picBall.Location.X <= 0)
            {
                tmrSpiel.Stop();
                pointsPlayer += 10;
            }

            //Ball trifft auf rechten Spielrand
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                tmrSpiel.Stop();
                pointsCPU += 10;
            }

            //Ball trifft auf unteren Spielrand 
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                directionY = -directionY;
            }

            //Ball trifft auf oberen Spielrand 
            if (picBall.Location.Y < 0
            )
            {
                directionY = -directionY;
            }

            //CPUSchläger an eine Random Position setzen während dem Spiel
            if (picBall.Location.Y >= 0 && picBall.Location.Y <= pnlSpiel.Height / 2)
            {
                picCPU.Location = new Point(pnlSpiel.Location.X, picBall.Location.Y - CPUdirectionY + picBall.Height);
            }

            if (picBall.Location.Y >= pnlSpiel.Height / 2 && picBall.Location.Y < pnlSpiel.Height)
            {
                picCPU.Location = new Point(pnlSpiel.Location.X , picBall.Location.Y + CPUdirectionY - picBall.Height);
            }

            //Wenn 100 Punkte erreicht worden sind, dann ist das Spiel fertig, und das andere Formular öffnet sich
            if (pointsPlayer == 50 || pointsCPU == 50)
            {
                tmrSpiel.Stop();
                Score.Show();
                Score.SetPointsCPlayer(pointsPlayer);
                Score.SetPointsCPU(pointsCPU);
            }

            txtPunkte.Text =
                Convert.ToString(pointsCPU);

            txtPunktePlayer.Text =
                Convert.ToString(pointsPlayer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Player Schläger ganz rechts ins Panel setzen
            picSchlägerrechts.Location = new Point(pnlSpiel.Width - picSchlägerrechts.Width, pnlSpiel.Height / 2);

            //CPU Schläger ganz links ins Panel setzen
            picCPU.Location = new Point(pnlSpiel.Location.X, pnlSpiel.Height / 2);


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
}