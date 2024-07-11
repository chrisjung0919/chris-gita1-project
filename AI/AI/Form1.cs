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
//Date: 1/17/21
//Basic AI

namespace AI
{
    public partial class Form1 : Form
    {
        //declare global variables
        private int xSpeedleft = 10;
        private int ySpeedtop = 10;
        private int countbulletleft = 0;
        private int countbulletright = 0;
        private int countbullettop = 0;
        private int countbulletbottom = 0;
        private decimal playerpoint = 0;
        private decimal playerhealth = 100;
        bool fireleft = false;
        bool fireright = false;
        bool firetop = false;
        bool firebottom = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moveEnemy()
        {
            //get the coordinates of where object is.
            int xCoordleft = picEnemy.Left;
            int yCoordtop = picEnemy.Top;
            lblPoint.Text = playerpoint.ToString();
            if (Math.Abs(picPlayer.Left - picEnemy.Left) > Math.Abs(picPlayer.Top - picEnemy.Top))
            {
                if (picEnemy.Left > picPlayer.Left)
                {
                    xSpeedleft = -10;
                    ySpeedtop = 0;
                }
                else if (picEnemy.Left < picPlayer.Left)
                {
                    xSpeedleft = 10;
                    ySpeedtop = 0;
                }
            }
            else if (Math.Abs(picPlayer.Top - picEnemy.Top) > Math.Abs(picPlayer.Left - picEnemy.Left))
            {
                if (picEnemy.Top > picPlayer.Top)
                {
                    ySpeedtop = -10;
                    xSpeedleft = 0;
                }
                else if (picEnemy.Top < picPlayer.Top)
                {
                    ySpeedtop = 10;
                    xSpeedleft = 0;
                }
            }
                    yCoordtop += ySpeedtop;
                    picEnemy.Top = yCoordtop;
                    xCoordleft += xSpeedleft;
                    picEnemy.Left = xCoordleft;

            //add points
            if (picEnemy.Bounds.IntersectsWith(bullet1.Bounds))
            {
                playerpoint += 1;
                picEnemy.Left += 15;
            }
            if (picEnemy.Bounds.IntersectsWith(bullet2.Bounds))
            {
                playerpoint += 1;
                picEnemy.Left -= 15;
            }
            if (picEnemy.Bounds.IntersectsWith(bullet3.Bounds))
            {
                playerpoint += 1;
                picEnemy.Top -= 15;
            }
            if (picEnemy.Bounds.IntersectsWith(bullet4.Bounds))
            {
                playerpoint += 1;
                picEnemy.Top += 15;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveEnemy();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int whichkey = e.KeyValue;

            //left arrow 37
            if (whichkey == 37)
            {
                picPlayer.Left -= 10;
                picPlayer.Image = picPRight.Image;
            }
            //right arrow 39
            else if (whichkey == 39)
            {
                picPlayer.Left += 10;
                picPlayer.Image = picPLeft.Image;
            }
            //up arrow 38
            else if (whichkey == 38)
            {
                picPlayer.Top -= 10;
                picPlayer.Image = picPUp.Image;
            }
            //down arrow 40
            else if (whichkey == 40)
            {
                picPlayer.Top += 10;
                picPlayer.Image = picPDown.Image;
            }
            //shoot bullet
            else if (whichkey == 32 && picPlayer.Image == picPLeft.Image)
            {
                Update.Enabled = true;
                countbulletleft++;

                if (countbulletleft == 1)
                {
                    fireleft = true;
                    bullet1.Location = new Point(picPlayer.Left + 110, picPlayer.Top + 50);
                }
                if (countbulletleft == 2)
                {
                    countbulletleft = 0;
                }
            }
            else if (whichkey == 32 && picPlayer.Image == picPRight.Image)
            {
                Update.Enabled = true;
                countbulletright++;

                if (countbulletright == 1)
                {
                    fireright = true;
                    bullet2.Location = new Point(picPlayer.Left + 60, picPlayer.Top + 50);
                }
                if (countbulletright == 2)
                {
                    countbulletright = 0;
                }
            }
            else if (whichkey == 32 && picPlayer.Image == picPUp.Image)
            {
                Update.Enabled = true;
                countbullettop++;

                if (countbullettop == 1)
                {
                    firetop = true;
                    bullet3.Location = new Point(picPlayer.Left + 50, picPlayer.Top + 50);
                }
                if (countbullettop == 2)
                {
                    countbullettop = 0;
                }
            }
            else if (whichkey == 32 && picPlayer.Image == picPDown.Image)
            {
                Update.Enabled = true;
                countbulletbottom++;

                if (countbulletbottom == 1)
                {
                    firebottom = true;
                    bullet4.Location = new Point(picPlayer.Left + 60, picPlayer.Top + 50);
                }
                if (countbulletbottom == 2)
                {
                    countbulletbottom = 0;
                }
            }
            if (picPlayer.Left > this.Width - picPlayer.Width)
            {
                picPlayer.Left -= 10;
            }
            else if (picPlayer.Left < 0)
            {
                picPlayer.Left = 0;
            }

            if (picPlayer.Top > this.Height - picPlayer.Height)
            {
                picPlayer.Top -= 10;
            }
            else if (picPlayer.Top < 0)
            {
                picPlayer.Top = 0;
            }

            if (Update.Enabled == false)
            {
                
            }

            if (picPlayer.Bounds.IntersectsWith(picEnemy.Bounds))
            {
                playerhealth -= 1;
                lblhealth.Width -= 1;
            }
            if (playerhealth == 0)
            {
                timer1.Enabled = false;
                Update.Enabled = false;
                lblhealth.Width = 0;
                MessageBox.Show("You died!", "RIP",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if (fireleft == true)
            {
                bullet1.Left += 50;
            }
            if (fireright == true)
            {
                bullet2.Left -= 50;
            }
            if (firetop == true)
            {
                bullet3.Top -= 50;
            }
            if (firebottom == true)
            {
                bullet4.Top += 50;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerhealth = 100;
            Update.Enabled = false;
            timer1.Enabled = true;
            playerpoint = 0;
            lblhealth.Width = 100;
        }
    }
}
