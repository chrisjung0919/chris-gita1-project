using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish1
{
    public partial class Fish1 : Form
    {
        //set up array for fish tank
        PictureBox[] theTank = new PictureBox[8];
        int fishPos = 0;
        Boolean onOff = false;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        private decimal TimesMoved = 0;
        private decimal BumpLeft = 0;
        private decimal BumpRight = 0;
        public Fish1()
        {
            InitializeComponent();
        }

        private void Fish1_Load(object sender, EventArgs e)
        {
            //set up the tank
            theTank[0] = pictureBox0;
            theTank[1] = pictureBox1;
            theTank[2] = pictureBox2;
            theTank[3] = pictureBox3;
            theTank[4] = pictureBox4;
            theTank[5] = pictureBox5;
            theTank[6] = pictureBox6;
            theTank[7] = pictureBox7;
            fishPos = r.Next(0, 8);

            theTank[fishPos].Image = picR.Image;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            TimesMoved += 1;
            moveFish();
            lblTimesMoved.Text = TimesMoved.ToString();
        }

        private void moveFish()
        {
            int whichway = r.Next(0, 2);

            if (whichway == 0)
            {
                if (fishPos > 0)
                {
                    theTank[fishPos].Image = null;
                    fishPos += -1;
                    theTank[fishPos].Image = picL.Image;
                }
                else
                {
                    BumpLeft += 1;
                    lblBumpLeft.Text = BumpLeft.ToString();
                }
            }
            
            if (whichway == 1)
            {
                if (fishPos < 7)
                {
                    theTank[fishPos].Image = null;
                    fishPos += 1;
                    theTank[fishPos].Image = picR.Image;
                }
                else
                {
                    BumpRight += 1;
                    lblBumpRight.Text = BumpRight.ToString();
                }
            }
            
            
        }

        private void timerFish_Tick(object sender, EventArgs e)
        {
            //auto moves fish
            moveFish();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                timerFish.Enabled = true;
                onOff = true;
            }
            else if (onOff == true)
            {
                timerFish.Enabled = false;
                onOff = false;
            }
        }

        private void btnFaster_Click(object sender, EventArgs e)
        {
            //This makes fish to move faster
            timerFish.Interval -= 5;
        }

        private void btnSlower_Click(object sender, EventArgs e)
        {
            //This makes fish to move slower
            timerFish.Interval += 5;
        }
    }
}
