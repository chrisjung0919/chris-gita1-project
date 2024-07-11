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
    public partial class level3 : Form
    {
        List<PictureBox> bulletList = new List<PictureBox>();
        int bulletCount = 0;
        public level3()
        {
            InitializeComponent();
        }

        private void level3_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs key = e;
            lblspaceship.Text = key.KeyValue.ToString();
            if (key.KeyValue == 37)
            {
                lblspaceship.Left -= 10;
            }
            else if (key.KeyValue == 39)
            {
                lblspaceship.Left += 10;
            }
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
                    bulletList.ElementAt(bulletCount).Location = new Point(lblspaceship.Left + 25, lblspaceship.Top + 25);
                    bulletList.ElementAt(bulletCount).Left =
                    lblspaceship.Left - 10;
                    bulletList.ElementAt(bulletCount).SizeMode =
                        PictureBoxSizeMode.StretchImage;
                    //how many bullets that we made
                    bulletCount++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveBullets();
        }
        private void moveBullets()
        {
            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList.ElementAt(i).Left -= 10;

            }
            //check for collision
            for (int j = 0; j < bulletList.Count; j++)
            {
                if (label1.Bounds.IntersectsWith(bulletList.ElementAt(j).Bounds))
                {
                    label1.Width -= 10;
                }
            }

            //remove bullets when they go off the form
            for (int k = 0; k < bulletList.Count; k++)
            {
                if (bulletList.ElementAt(k).Top < 0)
                {
                    //remove picturebox from the form
                    this.Controls.Remove(bulletList.ElementAt(k));
                    //remove from array list
                    bulletList.Remove(bulletList.ElementAt(k));
                    bulletCount--;
                    if (bulletCount < 0)
                    {
                        bulletList = new List<PictureBox>();
                        bulletCount = 0;
                        break;
                    }

                }
            }
        }
    }
}
