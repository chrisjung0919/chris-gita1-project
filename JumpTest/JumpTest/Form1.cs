using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpTest
{
    public partial class Form1 : Form
    {

        bool goleft, goright, jumping;

        int jumpspeed;
        int force;
        int playerspeed = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            player.Top += jumpspeed;

            if (goleft == true)
            {
                player.Left -= playerspeed;
            }
            if (goright == true)
            {
                player.Left += playerspeed;
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
            if(e.KeyCode == Keys.Up && jumping == false)
            {
                jumping = true;
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

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }


        }
    }
}
