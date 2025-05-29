using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirHockeyGame
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(185, 385, 65, 65);
        Rectangle player2 = new Rectangle(185, 105, 65, 65);
        Rectangle puck = new Rectangle(200, 262, 35, 35);
        Rectangle invline1 = new Rectangle(150, 550, 130, 550);
        Rectangle invline2 = new Rectangle(150, 6, 130, 6);

        int playerSpeed = 6;
        int puckXSpeed = 12;
        int puckYSpeed = 12;

        int player1Score = 0;
        int player2Score = 0;

        Random randGen = new Random();
        SoundPlayer player = new SoundPlayer();
        Pen bluePen = new Pen(Color.Blue, 18);
        Pen redPen = new Pen(Color.Red, 18);
        Pen greenPen = new Pen(Color.Green, 18);
        Pen orangePen = new Pen(Color.Orange, 18);
        Pen blackPen = new Pen(Color.Black, 18);
        Pen whitePen = new Pen(Color.White, 2);
        SolidBrush lightblueBrush = new SolidBrush(Color.LightSkyBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush lightgreenBrush = new SolidBrush(Color.LightGreen);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool rightArrowDown = false;
        bool leftArrowDown = false;



        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(450, 600);
            player = new SoundPlayer(Properties.Resources.theme_song);
            player.Play();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            gameTitlePicture.Visible = false;
            startButton.Visible = false;
            quitButton.Visible = false;
            textBox.Visible = false;
            this.BackgroundImage = null;
            player2Label.Visible = true;
            player1Label.Visible = true;
            gameTimer.Enabled = true;
            //this.Paint += new PaintEventHandler(Form1_Paint);
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            //this.StartPosition = FormStartPosition.CenterScreen;
            //Timer timer = new Timer();
            //timer.Interval = 16;
            //timer.Tick += new EventHandler(OnTimerClick);
            //timer.Start();
            this.Focus();   

        }


        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (gameTimer.Enabled)
            {
                e.Graphics.DrawRectangle(blackPen, 0, 0, 450, 600);
                e.Graphics.FillRectangle(blackBrush,0, 0,450,600); 
                e.Graphics.DrawArc(whitePen, 143, -73, 148, 148, 0, 180);
                e.Graphics.DrawArc(whitePen, 143, 485, 148, 148, 0, -180);
                e.Graphics.DrawArc(whitePen, 143, 206, 148, 148, 0, 360);
                e.Graphics.DrawLine(whitePen, 0, 280, 450, 280);

                //player 1
                e.Graphics.FillEllipse(lightblueBrush, player1);
                //player2
                e.Graphics.FillEllipse(redBrush, player2);
                //puck
                e.Graphics.FillEllipse(lightgreenBrush, puck);

                //borderlines
                e.Graphics.DrawLine(greenPen, 0, 0, (this.Width /2) - 80, 0);
                e.Graphics.DrawLine(greenPen, 0, 0, 0, this.Height / 2);
                e.Graphics.DrawLine(orangePen, 0, 560, (this.Width / 2) - 80, 560);
                e.Graphics.DrawLine(orangePen, 0, 600, 0, (this.Height / 2) - 20);
                e.Graphics.DrawLine(redPen, this.Width, 0, (this.Width / 2) + 65, 0);
                e.Graphics.DrawLine(redPen, 432, 0, 432, this.Height / 2);
                e.Graphics.DrawLine(bluePen, 450, 560, (this.Width / 2) + 65, 560);
                e.Graphics.DrawLine(bluePen, 432, 600, 432, (this.Height / 2) - 20);
            }
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            //move player1
            if (wDown == true && player1.Y >= 285)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < 480)
            {
                player1.Y += playerSpeed;
            }

            if (aDown == true && player1.X >= 15)
            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X <= 353)
            {
                player1.X += playerSpeed;
            }

            //move  player 2 
            if (upArrowDown == true && player2.Y > 10)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y <= 205)
            {
                player2.Y += playerSpeed;
            }

            if (rightArrowDown == true && player2.X <= 353)
            {
                player2.X += playerSpeed;
            }

            if (leftArrowDown == true && player2.X >= 15)
            {
                player2.X -= playerSpeed;
            }

            //move puck
            puck.X += puckXSpeed;
            puck.Y += puckYSpeed;

            //check if ball hit the side walls and change direction if it does
            if (puck.X <= 5 || puck.X > this.Width - puck.Width - 20)
            {
                player = new SoundPlayer(Properties.Resources.puck_hit);
                player.Play();
                puckXSpeed *= -1; 
            }

            //check if ball hit the top and bottom walls and change direction if it does
            if (puck.Y <= 10 || puck.Y > this.Height - puck.Height - 50)
            {
                player = new SoundPlayer(Properties.Resources.puck_hit);
                player.Play();
                puckYSpeed *= -1;
            }


            //check if ball hits either player. If it does change the direction 
            //and place the ball in front of the player hit 
            if (player1.IntersectsWith(puck))
            {
                puckXSpeed *= -1;
                player = new SoundPlayer(Properties.Resources.puck_hit);
                player.Play();
            }
            else if (player2.IntersectsWith(puck))
            {
                puckXSpeed *= -1;
                player = new SoundPlayer(Properties.Resources.puck_hit);
                player.Play();
            }




            //check if a player missed the ball and if true add 1 to score of other player  
            if (puck.IntersectsWith(invline2))
            {
            player1Score++;
            player1Label.Text = $"{player1Score}";

            }
            else if (puck.Y > 600)
            {
                player2Score++;
                player2Label.Text = $"{player2Score}";

            }

            if (puck.IntersectsWith(invline1))
            {
                player2Score++;
                player2Label.Text = $"{player2Score}";

            }
            // check score and stop game if either player is at 3 
            if (player2Score == 5)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                player1Label.Visible = false;
                player2Label.Visible = false;
                winLabel.Text = "Player  2 Wins!!";
            }
            else if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                player1Label.Visible = false;
                player2Label.Visible = false;
                winLabel.Text = "Player  1 Wins!!";
            }

            Refresh();

        }


        private void Form1_KeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
            }
        }
    }
}
