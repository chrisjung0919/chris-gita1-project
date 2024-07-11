using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Programmer: Christopher Jung
//Date: 2/16/2021
//Aquarium

namespace Aquarium
{
    public partial class Form1 : Form
    {
        private int xSpeed = 10;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        PictureBox[] Bubble = new PictureBox[11];
        PictureBox[] Fish = new PictureBox[10];
        Boolean[] deadfish = new Boolean[10]; 
        Boolean[] deadfish2 = new Boolean[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the bubble
            Bubble[0] = b0;
            Bubble[1] = b1;
            Bubble[2] = b2;
            Bubble[3] = b3;
            Bubble[4] = b4;
            Bubble[5] = b5;
            Bubble[6] = b6;
            Bubble[7] = b7;
            Bubble[8] = b8;
            Bubble[9] = b9;
            Bubble[10] = b10;

            //set up the fish
            Fish[0] = f0;
            Fish[1] = f1;
            Fish[2] = f2;
            Fish[3] = f3;
            Fish[4] = f4;
            Fish[5] = f5;
            Fish[6] = f6;
            Fish[7] = f7;
            Fish[8] = f8;
            Fish[9] = f9;

            //randomly place fish
            for (int n = 0; n < Fish.Length; n++)
            {
                Fish[n].Left = r.Next(0, this.Width);
                Fish[n].Top = r.Next(0, this.Height);
                deadfish[n] = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movebubble();
        }

        private void movebubble()
        {
            //move bubbles
            for (int i = 0; i < Bubble.Length; i++)
            {
                if (Bubble[i].Top < this.Height)
                {
                    Bubble[i].Top -= 10;
                }
                
                if (Bubble[i].Top < 0 || Bubble[i].Top > this.Height)
                {
                    Bubble[i].Top = r.Next(0, this.Height);
                    int theWidth = 20;
                    Bubble[i].Width = theWidth;
                    Bubble[i].Height = theWidth;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moveboat();
        }
        private void moveboat()
        {
            //get the coordinates of where object is.
            int xCoord = picboat.Left;

            if (picboat.Left > this.Width - picboat.Width)
            {
                xSpeed *= -1;
            }
            else if (picboat.Left < 0)
            {
                xSpeed *= -1;
            }

            xCoord += xSpeed;

            picboat.Left = xCoord;

            fishingnet.Left = picboat.Left + picboat.Width / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            moveshark();
        }
        private void moveshark()
        {
            int whichway = r.Next(0, 4);

            if (whichway == 0)
            {
                picshark.Left -= 50;
                picshark.Image = picsharkLeft.Image;
                
            }
            if (whichway == 1)
            {
                picshark.Left += 50;
                picshark.Image = picsharkRight.Image;
            }
            if (whichway == 2)
            {
                picshark.Top -= 50;
            }
            if (whichway == 3)
            {
                picshark.Top += 50;
            }


            if (picshark.Left > this.Width - picshark.Width)
            {
                picshark.Left -= 50;
            }
            else if (picshark.Left < 0)
            {
                picshark.Left = 0;
            }

            if (picshark.Top > this.Height - picshark.Height)
            {
                picshark.Top -= 50;
            }
            else if (picshark.Top < 0)
            {
                picshark.Top = 0;
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            movefish();
        }
        private void movefish()
        {
            for (int i = 0; i < Fish.Length; i++)
            {
                if(deadfish[i] == false) {
                //move fish
                int whichway = r.Next(0, 4);

                if (whichway == 0)
                {
                    Fish[i].Left -= 10;
                    Fish[i].Image = picfishleft.Image;

                }
                if (whichway == 1)
                {
                    Fish[i].Left += 10;
                    Fish[i].Image = picfishright.Image;
                }
                if (whichway == 2)
                {
                    Fish[i].Top -= 10;
                }
                if (whichway == 3)
                {
                    Fish[i].Top += 10;
                }

                if (Fish[i].Left > this.Width - Fish[i].Width)
                {
                    Fish[i].Left -= 10;
                }
                else if (Fish[i].Left < 0)
                {
                    Fish[i].Left = 0;
                }

                if (Fish[i].Top > this.Height - 41 - Fish[i].Height)
                {
                    Fish[i].Top -= 10;
                }
                else if (Fish[i].Top < 0)
                {
                    Fish[i].Top = 0;
                }
            }   
                for (int n = 0; n < Fish.Length; n++)
                {
                    if (Fish[n].Bounds.IntersectsWith(picshark.Bounds))
                    {
                        deadfish[n] = true;
                    }
                    if (deadfish[n] == true)
                    {
                        Fish[n].Top = Bottom.Top;
                        Fish[n].Image = dead.Image;
                        
                    }
                    if (Fish[n].Bounds.IntersectsWith(fishingnet.Bounds))
                    {
                        deadfish2[n] = true;
                    }
                    if (deadfish2[n] == true)
                    {
                        Fish[n].Image = dead.Image;
                        Fish[n].Left = fishingnet.Left;
                        Fish[n].Top = fishingnet.Top + 100;
                        deadfish[n] = false;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picshark_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < Fish.Length; n++)
            {
                Fish[n].Left = r.Next(0, this.Width);
                Fish[n].Top = r.Next(0, this.Height);
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                Fish[n].Image = picfishleft.Image;
                deadfish[n] = false;
            }
        }
    }
}
