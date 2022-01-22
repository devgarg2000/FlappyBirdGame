using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int PipeSpeed = 9;
        int gravity = 10;
        int score=0;


        public Form1()
        {

            InitializeComponent();
            menuBox.Hide();

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                gravity = -12;
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 15;
            }


        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeBottom.Left -= PipeSpeed;
            PipeTop.Left -= PipeSpeed;
            Score.Text = "Score: " + score;

            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }


            if (PipeTop.Left < -250)
            {
                PipeTop.Left = 800;
                score++;

            }



            if(FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds)   ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds))
            {
                endGame();
            }

        
            if(score > 5)
            {
                PipeSpeed = 11;
            }

            
            if (score > 15)
            {
                PipeSpeed = 13;
            }

            if (score > 20)
            {
                PipeSpeed = 14;
            }

            if (score > 30)
            {
                PipeSpeed = 16;
            }
            
            if (score > 40)
            {
                PipeSpeed = 18;
            }



            if (FlappyBird.Top < -5 || FlappyBird.Bottom < -5)
            {
                endGame();
            }


        }


        private void endGame()
        {
            gameTimer.Stop();
            Score.Text += " Game over !";
            menuBox.Show();
            menuBoxScore.Text = "Score : " + score;


        }

        private void menuBoxPlayAgain_Click(object sender, EventArgs e)
        {

            FlappyBird.Location=new Point(71, 166);
            PipeBottom.Location = new Point(522, 346);
            PipeTop.Location = new Point(644, -4);
            gameTimer.Start();
            menuBox.Hide();
            score = 0;
            
            
           


        }

        private void menuBoxQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void menuBoxScore_Click(object sender, EventArgs e)
        {
            
        }

        private void menuBoxGameOver_Click(object sender, EventArgs e)
        {

        }

        private void menuBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
