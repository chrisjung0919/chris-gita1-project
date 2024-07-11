using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation
{
    public partial class Form1 : Form
    {

        //declare global variables
        private int xSpeed = 10;
        private int ySpeed = 10;
        private decimal point = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void moveHappy()
        {
            //get the coordinates of where object is.
            int xCoord = picHappy.Left;
            int yCoord = picHappy.Top;

            if(picHappy.Left > this.Width - picHappy.Width)
            {
                xSpeed *= -1;
            }
            else if(picHappy.Left < 0)
            {
                xSpeed *= -1;
            }

            xCoord += xSpeed;

            picHappy.Left = xCoord;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveHappy();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lbloutput.Text = e.KeyValue.ToString();

            int whichkey = e.KeyValue;

            //left arrow 37
            if (whichkey == 37)
            {
                lblspaceship.Left -= 10;
            }
            //right arrow 39
            else if (whichkey == 39)
            {
                lblspaceship.Left += 10;
            }

            if (whichkey == 32)
            {
                timer2.Enabled = true;
            }

            if (timer2.Enabled == false)
            {
                bullet.Left = lblspaceship.Left + lblspaceship.Width/2;
                bullet.Top = lblspaceship.Top - 1;
            }
        }

        private void movebullet()
        {
            bullet.Top -= 10;

            if (bullet.Top < 0)
            {
                bullet.Left = lblspaceship.Left + lblspaceship.Width / 2;
                bullet.Top = lblspaceship.Top - 1;
                timer2.Enabled = false;
            }
            //collision check
            
            
                if (bullet.Bounds.IntersectsWith(picHappy.Bounds))
                {
                //if (bullet.Left > picHappy.Left && bullet.Right < picHappy.Right && bullet.Top > picHappy.Top &&
                //bullet.Bottom < picHappy.Bottom)
                //{
                    bullet.Left = lblspaceship.Left + lblspaceship.Width / 2;
                    bullet.Top = lblspaceship.Top - 1;
                    timer2.Enabled = false;
                    picHappy.Top -= 10;
                    point += 1;
                }
            label1.Text = point.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            movebullet();
        }

        private void picHappy_Click(object sender, EventArgs e)
        {

        }
    }
}
