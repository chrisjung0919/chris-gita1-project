using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firepower
{
    public partial class Form1 : Form
    {
        List<PictureBox> bulletList = new List<PictureBox>();
        int bulletCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //move ship left and right with arrow keys
            //37 is left and 39 is right
            KeyEventArgs key = e;
            lblSpaceship.Text = key.KeyValue.ToString();

            if(key.KeyValue == 37)
            {
                lblSpaceship.Left -= 10;
            }
            else if(key.KeyValue == 39)
            {
                lblSpaceship.Left += 10;
            }
            //space bar 32
            if (key.KeyValue == 32)
            {
                if (bulletCount < 10)
                {
                    bulletList.Add(new PictureBox());
                    //dynamically add picturebox to the form
                    this.Controls.Add(bulletList.ElementAt(bulletCount));
                    //set the pictureboxes properties
                    bulletList.ElementAt(bulletCount).Height = 10;
                    bulletList.ElementAt(bulletCount).Width = 10;
                    bulletList.ElementAt(bulletCount).Image =
                        Image.FromFile("DeadCharacter.png", true);
                    bulletList.ElementAt(bulletCount).Left =
                        lblSpaceship.Left + lblSpaceship.Width / 2;
                    bulletList.ElementAt(bulletCount).Top =
                    lblSpaceship.Top - 10;
                    bulletList.ElementAt(bulletCount).SizeMode =
                        PictureBoxSizeMode.StretchImage;
                    //how many bullets that we made
                    bulletCount++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //call a move function
            moveBullets();
        }

        private void moveBullets()
        {
            for(int i = 0; i < bulletList.Count; i++)
            {
                bulletList.ElementAt(i).Top -= 10;

            }
            //check for collision
            for(int j=0; j<bulletList.Count; j++)
            {
                if (lbltarget.Bounds.IntersectsWith(bulletList.ElementAt(j).Bounds))
                {
                    lbltarget.Width -= 10;
                }
            }

            //remove bullets when they go off the form
            for(int k = 0; k < bulletList.Count; k++)
            {
                if (bulletList.ElementAt(k).Top < 0)
                {
                    //remove picturebox from the form
                    this.Controls.Remove(bulletList.ElementAt(k));
                    //remove from array list
                    bulletList.Remove(bulletList.ElementAt(k));
                    bulletCount--;
                    if(bulletCount < 0)
                    {
                        bulletList = new List<PictureBox>();
                        bulletCount = 0;
                        break;
                    }

                }
            }
        }

        private void lblOpenform_Click(object sender, EventArgs e)
        {
            Class1.myhealth = 10;
            level2 openlevel = new level2();
            openlevel.ShowDialog();
        }
    }
}
