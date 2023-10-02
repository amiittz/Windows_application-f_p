using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinalProject
{
    public partial class Form1 : Form
    {
        bool go_l;
        bool go_r;
        bool go_u;//לתזוזה של הכדור
        bool go_d;
        bool is_game_over;

        int count;
        int ballx;//בזה צריך לעשות תזוזה אמיתית
        int bally;
        int speed;

        public Form1()
        {
            InitializeComponent();
            start_game();
        }

        private void start_game()
        {
            count = 12;
            label1.Text = "count: " + count;
            speed = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (go_l)
            {
                ball.Left -= speed;
            }
            if (go_r)
            {
                ball.Left += speed;
            }
            if (go_u)
            {
                ball.Top -= speed;
            }
            if (go_d)
            {
                ball.Top += speed;
            }

            if(ball.Bounds.IntersectsWith(end.Bounds))//בדיקת נצחון
            {
                timer1.Stop();
                MessageBox.Show("win in: " + count + " moves!");
            }

            foreach(Control x in this.Controls)
            {
                if((string)x.Tag=="wall")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        MessageBox.Show("wall");
                        ball.Left -= speed;

                    }
                }
            }

        }
        private void key_is_done(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                go_l = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                go_r = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                go_u = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                go_d = true;
            }
        }
        private void key_is_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                go_l = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                go_r = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                go_u = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                go_d = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            /*Graphics g = this.CreateGraphics();
            Wall w1 = new Wall(50, 50, 50, 300);
            w1.Draw(g);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)//wall
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)//ball
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)//end
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
