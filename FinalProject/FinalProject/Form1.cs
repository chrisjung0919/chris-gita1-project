using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        bool goleft, goright, jumping, shootleft, shootright;

        int jumpspeed;
        int force;
        int playerspeed = 7;
        int enemyspeed = 5;
        int enemyspeed2 = 5;
        int enemyspeed3 = 5;

        private int xSpeed = 10;

        private int countbullet = 30;

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            player.Top += jumpspeed;

            if (goleft == true)
            {
                player.Left -= playerspeed;
                player.Image = playerL.Image;
            }
            if (goright == true)
            {
                player.Left += playerspeed;
                player.Image = playerR.Image;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpspeed = -8;
                force -= 1;
            }
            else
            {
                jumpspeed = 10;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }
                }
            }
            enemy1.Left -= enemyspeed;

            if (enemy1.Left < block2.Left || enemy1.Left + enemy1.Width > block2.Left + block2.Width)
            {
                enemyspeed *= -1;
            }
            enemy2.Left -= enemyspeed2;

            if (enemy2.Left < block3.Left || enemy2.Left + enemy2.Width > block3.Left + block3.Width)
            {
                enemyspeed2 *= -1;
            }

            enemy3.Left -= enemyspeed3;

            if (enemy3.Left < block4.Left || enemy3.Left + enemy3.Width > block4.Left + block4.Width)
            {
                enemyspeed3 *= -1;
            }
            Ammo.Text = countbullet.ToString();

        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if (shootleft == true)
            {
                bullet1.Visible = true;
                bullet1.Left = bullet1.Left - 50;
            }
            if (shootright == true)
            {
                bullet2.Visible = true;
                bullet2.Left = bullet2.Left + 50;
            }
        }

        private void moving_Tick(object sender, EventArgs e)
        {
            int xCoord = block1.Left;

            if (block1.Left > this.Width - block1.Width)
            {
                xSpeed *= -1;
            }
            else if (block1.Left < 0)
            {
                xSpeed *= -1;
            }

            xCoord += xSpeed;

            block1.Left = xCoord;
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Space && player.Image == playerL.Image && countbullet > 0)
            {       
                Update.Enabled = true;
                countbullet -= 1;
                if (countbullet > 0)
                {
                shootleft = true;
                bullet1.Location = new Point(player.Left + 3, player.Top + 20);
                }
                if (countbullet == 0)
                {
                    shootleft = false;
                    shootright = false;
                    bullet1.Visible = false;
                    bullet2.Visible = false;
                    
                }
                
            }
            if (e.KeyCode == Keys.Space && player.Image == playerR.Image && countbullet > 0)
            {
                Update.Enabled = true;
                countbullet -= 1;
                
                if (countbullet > 0)
                {
                    shootright = true;
                    bullet2.Location = new Point(player.Left + 8, player.Top + 20);
                }
                if (countbullet == 0)
                {
                    shootright = false;
                    shootleft = false;
                    bullet1.Visible = false;
                    bullet2.Visible = false;
                    
                }
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void RestartGame()
        {
            jumping = false;
            goleft = false;
            goright = false;
            countbullet = 30;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }


        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
