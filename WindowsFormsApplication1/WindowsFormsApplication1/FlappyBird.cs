using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }

        int gravity = 5;
        int pipeSpeed = 10;
        int scores = 0;
        Boolean running = false;
        Random rand = new Random();
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            running = true;

            bird.Top += gravity;

            upper1.Left -= pipeSpeed;
            upper2.Left -= pipeSpeed;
            upper3.Left -= pipeSpeed;
            lower1.Left -= pipeSpeed;
            lower2.Left -= pipeSpeed;
            lower3.Left -= pipeSpeed;

            upperPipePosition(upper1, -70, 130);
            upperPipePosition(upper2, -70, 110);
            upperPipePosition(upper3, -70, 110);
            lowerPipePosition(lower1, -100, 220, 300);
            lowerPipePosition(lower2, -100, 220, 300);
            lowerPipePosition(lower3, -100, 220, 330);

            checkCollide();
            label1.Text = "Scores : " + scores;
        }

        private void upperPipePosition(PictureBox pic, int left, int top)
        {
            if (pic.Left < left)
            {
                scores++;
                pic.Left = 600;
                pic.Top = rand.Next(top) * -1;
            }
        }
        private void lowerPipePosition(PictureBox pic, int left, int topFrom, int topTo)
        {
            if (pic.Left < left)
            {
                scores++;
                pic.Left = 600;
                pic.Top = rand.Next(topFrom, topTo);
            }
        }
        private void checkCollide()
        {
            if (bird.Bounds.IntersectsWith(upper1.Bounds) ||
                bird.Bounds.IntersectsWith(upper2.Bounds) ||
                bird.Bounds.IntersectsWith(upper3.Bounds) ||
                bird.Bounds.IntersectsWith(lower1.Bounds) ||
                bird.Bounds.IntersectsWith(lower2.Bounds) ||
                bird.Bounds.IntersectsWith(lower3.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -1)
            {
                gameOver();
            }
        }
        private void gameOver()
        {
            running = false;
            label3.Text = "Game Over";
            label3.BackColor = Color.OrangeRed;
            label4.Text = "Press ENTER To Replay";
            timer1.Stop();
        }
        private void FlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!running)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    scores = 0;
                    bird.Top = 170;
                    label3.Text = "";
                    label3.BackColor = Color.Transparent;
                    label4.Text = "";
                    upper1.Left = 275;
                    upper2.Left = 525;
                    upper3.Left = 775;
                    lower1.Left = 225;
                    lower2.Left = 475;
                    lower3.Left = 725;
                    timer1.Start();
                }
            }
        }
        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (running)
            {
                if (e.KeyCode == Keys.Space)
                {
                    bird.Top -= gravity + 25;
                }
            }
        }
    }
}
