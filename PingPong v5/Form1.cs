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
        public int CpuDirectionY = -3;
        private int pointsPlayer;
        private int pointsCpu;

        Gameover gameover = new Gameover();
        private Random rand = new Random();

        //Initiating of the program Form1
        public Form1()
        {
            InitializeComponent();
        }

        //When timer is activated, the game starts
        public void btnStart_Click(object sender, EventArgs e)
        {
            SetDirection();
            tmrSpiel.Start();
            picBall.Location = new Point(pnlSpiel.Width / 2,
                pnlSpiel.Height / 2);

            pointsPlayer = 0;
            pointsCpu = 0;
            btnSetBall.Visible = true;

            picCPU.Location = new Point(0, pnlSpiel.Height / 2 - picCPU.Height / 2);
            
            picLine.Location = new Point((pnlSpiel.Width / 2) - (picLine.Width / 2), 0);
        }

        //Continues the game by clicking on the button, after a point is made, ball spawns in the middle
        private void btnSetBall_Click(object sender, EventArgs e)
        {
            ContinueGame();
        }

        public void ContinueGame()
        {
            tmrSpiel.Start();
            SetDirection();
            picBall.Location = new Point(pnlSpiel.Width / 2,
                pnlSpiel.Height / 2);

            picCPU.Location = new Point(1, pnlSpiel.Height / 2 - picCPU.Height / 2);

            SetCpuDirection(-3);
        }

        //Setter for directionX and directionY for the ball, for a random start
        public void SetDirection()
        {
            directionX = rand.Next(-6, 6);

            if (!(directionX == 5 || directionX == -5))
            {
                SetDirection();
            }

            Console.WriteLine(directionX);

            directionY = rand.Next(-6, 6);

            if (!(directionY != 5 || directionY != -5))
            {
                SetDirection();
            }

            Console.WriteLine(directionY);
        }

        //Setter for CpuDirectionY
        public void SetCpuDirection(int direction)
        {
            if ((pointsPlayer >= 20 && pointsPlayer <= 40) && (pointsCpu >= 0 && pointsCpu <= 40))
            {
                if (pointsPlayer >= 30)
                {
                    CpuDirectionY = 8 * direction;
                    directionX = directionX + (directionX / 2);
                    directionY = directionY + (directionY / 2);
                }
                else
                {
                    CpuDirectionY = 4 * direction;
                    directionX = directionX + (directionX / 2);
                    directionY = directionY + (directionY / 2);
                }
            }
            else
            {
                CpuDirectionY = direction;
            }
        }

        //Runtime of the game
        public void tmrSpiel_Tick(object sender, EventArgs e)
        {
            picCPU.Location = new Point(0, picCPU.Location.Y + CpuDirectionY);

            picBall.Location = new Point(picBall.Location.X + directionX,
                picBall.Location.Y + directionY);


            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picPlayer.Width
                && picBall.Location.Y + picBall.Height >= picPlayer.Location.Y
                && picBall.Location.Y <= picPlayer.Location.Y + picPlayer.Height)
            {
                directionX = -directionX;
            }

            if (picBall.Location.X <= picCPU.Width
                && picBall.Location.Y + picBall.Height >= picCPU.Location.Y
                && picBall.Location.Y <= picCPU.Location.Y + picCPU.Height)
            {
                directionX = -directionX;
            }

            //Ball hits left wall 
            if (picBall.Location.X <= 0)
            {
                tmrSpiel.Stop();
                pointsPlayer += 10;
            }

            //Ball hits right wall
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                tmrSpiel.Stop();
                pointsCpu += 10;
            }

            //Ball hits bottom
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                directionY = -directionY;
            }

            //Ball hits top
            if (picBall.Location.Y < 0)
            {
                directionY = -directionY;
            }

            //If CPU is at the top, it goes back down
            if (picCPU.Location.Y <= 0)
            {
                SetCpuDirection(3);
                picCPU.Location = new Point(0, picCPU.Location.Y + CpuDirectionY);
            }

            //If CPU is at the bottom, it goes back up
            if (picCPU.Location.Y >= pnlSpiel.Height - picCPU.Height)
            {
                SetCpuDirection(-3);
                picCPU.Location = new Point(0, picCPU.Location.Y + CpuDirectionY);
            }

            //if either Player scores 50 points, game is finished and the GameOver Form will open
            if (pointsPlayer == 50 || pointsCpu == 50)
            {
                tmrSpiel.Stop();
                gameover.Show();
                gameover.SetPointsPlayer(pointsPlayer);
                gameover.SetPointsCpu(pointsCpu);
            }

            txtPlayerPoints.Text = Convert.ToString(pointsPlayer);
            txtCpuPoints.Text = Convert.ToString(pointsCpu);
        }

        /*
         * Set Player and CPU Position, X an Y Coordinates
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

        //set Scrollbar next to Player
        private void vsbScrollbarrechts_Scroll(object sender, ScrollEventArgs e)
        {
            picPlayer.Location =
                new Point(picPlayer.Location.X,
                    vsbScrollbarrechts.Value);
            vsbScrollbarrechts.Value =
                picPlayer.Location.Y;
        }

        //Close Game
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.F:
                    tmrSpiel.Start();
                    break;
                case Keys.G:
                    ContinueGame();
                    break;
            }
        }
    }
}