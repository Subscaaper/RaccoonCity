using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        private int directionX;
        private int directionY;
        public int CPUdirectionY;
        private int pointsPlayer;
        private int pointsCpu;

        Gameover gameover = new Gameover();
        private Random rand = new Random();

        //Ausführung des Programms Form1
        public Form1()
        {
            InitializeComponent();
        }

        //wird der Timer aktiviert, Spiel startet
        public void btnStart_Click(object sender, EventArgs e)
        {
            SetDirection();
            tmrSpiel.Start();
            picBall.Location = new Point(pnlSpiel.Width / 2,
                pnlSpiel.Height / 2);

            pointsPlayer = 0;
            pointsCpu = 0;
            btnSetBall.Visible = true;
        }

        //Continues the game by clicking on the button, after a point is made, ball spawns in the middle
        private void btnSetBall_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
            SetDirection();
            picBall.Location = new Point(pnlSpiel.Width / 2,
                pnlSpiel.Height / 2);
        }

        public void SetDirection()
        {
            directionX = rand.Next(-4, 4);
            directionY = rand.Next(-4, 4);

            if (directionX == 0 || directionY == 0)
            {
                SetDirection();
            }
        }

        public void SetCpuDirection(int direction)
        {
            CPUdirectionY = direction;
        }

        //Im Timer läuft das Spiel ab
        public void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //Bewegung des Balles
            picBall.Location = new Point(picBall.Location.X + directionX,
                picBall.Location.Y + directionY);

            //Ball trifft auf Schläger
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picPlayer.Width //>= 540
                && picBall.Location.Y + picBall.Height >= picPlayer.Location.Y //Ball Punkt unten links gleich Y oben links von Player 
                && picBall.Location.Y <= picPlayer.Location.Y + picPlayer.Height) //Ball Punkt oben links gleich Y unten links von Player
            {
                directionX = -directionX;
            }

            //Wenn der Ball den CPUSchläger trifft
            if (picBall.Location.X <= picCPU.Width
                && picBall.Location.Y + picBall.Height >= picCPU.Location.Y
                && picBall.Location.Y <= picCPU.Location.Y + picCPU.Height)
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
                pointsCpu += 10;
            }

            //Ball trifft auf unteren Spielrand 
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                directionY = -directionY;
            }

            //Ball trifft auf oberen Spielrand 
            if (picBall.Location.Y < 0)
            {
                directionY = -directionY;
            }

            /*CPU Player position, if the ball is in the top half of the panel it goes up, otherwise down*/
            if (picBall.Location.Y >= 0 && picBall.Location.Y <= pnlSpiel.Height / 2)
            {
                SetCpuDirection(3);
                picCPU.Location = new Point(1, picCPU.Location.Y - CPUdirectionY);
            }

            //Bottom half
            if (picBall.Location.Y >= pnlSpiel.Height / 2 && picBall.Location.Y < pnlSpiel.Height)
            {
                SetCpuDirection(3);
                picCPU.Location = new Point(1, picCPU.Location.Y + CPUdirectionY);
            }

            //If CPU is at the top
            if (picCPU.Location.Y <= 0)
            {
                if (picBall.Location.Y >= 0 && picBall.Location.Y <= (pnlSpiel.Height - pnlSpiel.Height) + picBall.Height)
                {
                  SetCpuDirection(0);  
                  picCPU.Location = picCPU.Location;
                }
                else
                {
                    SetCpuDirection(3);
                                    picCPU.Location = new Point(1, picCPU.Location.Y + CPUdirectionY);
                }
                
            }

            //If CPU is at the bottom
            if (picCPU.Location.Y + picCPU.Height >= pnlSpiel.Height)
            {
                picCPU.Location = new Point(1, picCPU.Location.Y + CPUdirectionY);
            }

            //Wenn 50 Punkte erreicht worden sind, dann ist das Spiel fertig, und das andere Formular öffnet sich
            if (pointsPlayer == 50 || pointsCpu == 50)
            {
                tmrSpiel.Stop();
                gameover.Show();
                gameover.SetPointsPlayer(pointsPlayer);
                gameover.SetPointsCPU(pointsCpu);
            }

            txtPlayerPoints.Text = Convert.ToString(pointsPlayer);
            txtCpuPoints.Text = Convert.ToString(pointsCpu);
        }

        /*
         * Schläger ganz rechts ins Panel setzen
         * Ausgangsposition vom Schläger X und Y Koordinaten festlegen
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            picPlayer.Location = new Point(pnlSpiel.Width - picPlayer.Width, pnlSpiel.Height / 2);

            picCPU.Location = new Point(pnlSpiel.Location.Y - pnlSpiel.Location.Y, pnlSpiel.Height / 2);

            vsbScrollbarrechts.Height = pnlSpiel.Height;
            vsbScrollbarrechts.Location =
                new Point(pnlSpiel.Location.X + pnlSpiel.Width,
                    pnlSpiel.Location.Y);
            vsbScrollbarrechts.Minimum = 0;
            vsbScrollbarrechts.Maximum =
                pnlSpiel.Height - picPlayer.Height +
                vsbScrollbarrechts.LargeChange;
            vsbScrollbarrechts.Value = picPlayer.Location.Y;
        }

        //Scrollbar neben den Schläger setzen
        private void vsbScrollbarrechts_Scroll(object sender, ScrollEventArgs e)
        {
            picPlayer.Location =
                new Point(picPlayer.Location.X,
                    vsbScrollbarrechts.Value);
            vsbScrollbarrechts.Value =
                picPlayer.Location.Y;
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
}