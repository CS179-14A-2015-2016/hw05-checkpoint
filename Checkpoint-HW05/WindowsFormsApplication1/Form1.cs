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
    public partial class Form1 : Form
    {
        Vector ball1Velocity = new Vector(0, 0);
        Vector ball2Velocity = new Vector(0, 0);
        Vector paddle1Velocity = new Vector(0, 0);
        Vector paddle2Velocity = new Vector(0, 0);
        bool up1 = false, up2 = false, down1 = false, down2 = false;
        public Form1()
        {
            InitializeComponent();
            ball1.Location = new System.Drawing.Point(220, 130);
            ball2.Location = new System.Drawing.Point(250, 130);
            paddle1.X1 = 20;
            paddle1.X2 = 20;
            paddle1.Y1 = 100;
            paddle1.Y2 = 200;
            paddle2.X1 = 480;
            paddle2.X2 = 480;
            paddle2.Y1 = 100;
            paddle2.Y2 = 200;
            Random random = new Random();
            int randomX = random.Next(2, 5);
            ball1Velocity.X = randomX;
            ball1Velocity.Y = 2 - randomX;
            ball2Velocity.X = randomX * -1;
            ball2Velocity.Y = (2 - randomX) * -1;
            timer1.Enabled = true;

            this.FormBorderStyle = FormBorderStyle.None;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ball1.Location.X <= 24 && ball1.Location.Y <= paddle1.Y2 && ball1.Location.Y >= paddle1.Y1)
            {
                if (up1 == true)
                {
                    ball1Velocity.X = (ball1Velocity.X * -1) / (6 / 5);
                    ball1Velocity.Y += paddle1Velocity.Y/2;
                }
                else if (down1 == true)
                {
                    ball1Velocity.X = (ball1Velocity.X * -1) / (6 / 5);
                    ball1Velocity.Y += paddle1Velocity.Y/2;
                }
                else
                {
                    int X = ball1Velocity.X * -1;
                    ball1Velocity.X = X;
                }
            }

            if (ball2.Location.X <= 24 && ball2.Location.Y <= paddle1.Y2 && ball2.Location.Y >= paddle1.Y1)
            {
                if (up1 == true)
                {
                    ball2Velocity.X = (ball2Velocity.X * -1) / (6 / 5);
                    ball2Velocity.Y += paddle1Velocity.Y/2;
                }
                else if (down1 == true)
                {
                    ball2Velocity.X = (ball2Velocity.X * -1) / (6 / 5);
                    ball2Velocity.Y += paddle1Velocity.Y/2;
                }
                else
                {
                    int X = ball2Velocity.X * -1;
                    ball2Velocity.X = X;
                }
            }
            if (ball1.Location.X >= 460 && ball1.Location.Y <= paddle2.Y2 && ball1.Location.Y >= paddle2.Y1)
            {
                if (up2 == true)
                {
                    ball1Velocity.X = (ball1Velocity.X * -1) / (6 / 5);
                    ball1Velocity.Y += paddle2Velocity.Y/2;
                }
                else if (down2 == true)
                {
                    ball1Velocity.X = (ball1Velocity.X * -1) / (6 / 5);
                    ball1Velocity.Y += paddle2Velocity.Y/2;
                }
                else
                {
                    int X = ball1Velocity.X * -1;
                    ball1Velocity.X = X;
                }
            }
            if (ball2.Location.X >= 460 && ball2.Location.Y <= paddle2.Y2 && ball2.Location.Y >= paddle2.Y1)
            {
                if (up2 == true)
                {
                    ball2Velocity.X = (ball2Velocity.X * -1) / (6 / 5);
                    ball2Velocity.Y += paddle2Velocity.Y/2;
                }
                else if (down2 == true)
                {
                    ball2Velocity.X = (ball2Velocity.X * -1) / (6 / 5);
                    ball2Velocity.Y += paddle2Velocity.Y/2;
                }
                else
                {
                    int X = ball2Velocity.X * -1;
                    ball2Velocity.X = X;
                }
            }
            if (ball1.Top < 280 && ball1.Top > 01)
            {
                ball1.Location = new Point(ball1.Location.X + ball1Velocity.X, ball1.Location.Y + ball1Velocity.Y);
                
            }
            if (ball2.Top < 280 && ball2.Top > 01)
            {
                ball2.Location = new Point(ball2.Location.X + ball2Velocity.X, ball2.Location.Y + ball2Velocity.Y);
            }
            else
            {
                ball1Velocity.Y = ball1Velocity.Y * -1;
                ball2Velocity.Y = ball2Velocity.Y * -1;
                ball1.Location = new Point(ball1.Location.X + ball1Velocity.X, ball1.Location.Y + ball1Velocity.Y);
                ball2.Location = new Point(ball2.Location.X + ball2Velocity.X, ball2.Location.Y + ball2Velocity.Y);
            }
            if (up1 == true && paddle1.Y1 > 0) { paddle1.Y1 += paddle1Velocity.Y; paddle1.Y2 += paddle1Velocity.Y; }
            if (down1 == true && paddle1.Y2 < 280) { paddle1.Y1 += paddle1Velocity.Y; paddle1.Y2 += paddle1Velocity.Y; }
            if (up2 == true && paddle2.Y1 > 0) { paddle2.Y1 += paddle2Velocity.Y; paddle2.Y2 += paddle2Velocity.Y; }
            if (down2 == true && paddle2.Y2 < 280) { paddle2.Y1 += paddle2Velocity.Y; paddle2.Y2 += paddle2Velocity.Y; }
            if (ball1.Location.X > 500 || ball1.Location.X < 0 || ball2.Location.X > 500 || ball2.Location.X < 0)
            {
                label1.Text = "Game Over.";
                timer1.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K) { down2 = true; paddle2Velocity.Y = 5; }
            if (e.KeyCode == Keys.I) { up2 = true; paddle2Velocity.Y = -5; }
            if (e.KeyCode == Keys.S) { down1 = true; paddle1Velocity.Y = 5; }
            if (e.KeyCode == Keys.W) { up1 = true; paddle1Velocity.Y = -5; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K) { down2 = false; }
            if (e.KeyCode == Keys.I) { up2 = false; }
            if (e.KeyCode == Keys.S) { down1 = false; }
            if (e.KeyCode == Keys.W) { up1 = false; }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }
    }

}
