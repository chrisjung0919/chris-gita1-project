using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2d
{
    public partial class Form1 : Form
    {
        //declare 2d array
        PictureBox[,] theTank = new PictureBox[3, 4];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        int fishRow = 1;
        int fishCol = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the tank
            //the first row
            theTank[0, 0] = pictureBox0;
            theTank[0, 1] = pictureBox1;
            theTank[0, 2] = pictureBox2;
            theTank[0, 3] = pictureBox3;
            //the second row
            theTank[1, 0] = pictureBox4;
            theTank[1, 1] = picBox5;
            theTank[1, 2] = picBox6;
            theTank[1, 3] = pictureBox7;
            //the third row
            theTank[2, 0] = pic8;
            theTank[2, 1] = pic9;
            theTank[2, 2] = pictureBox10;
            theTank[2, 3] = pictureBox11;

            fishRow = r.Next(0, 3);
            fishCol = r.Next(0, 4);

            theTank[fishRow, fishCol].Image = picFish.Image;

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //randomly move the fish about the boxes
            theTank[fishRow, fishCol].Image = null;
            fishRow = r.Next(0, 3);
            fishCol = r.Next(0, 4);

            theTank[fishRow, fishCol].Image = picFish.Image;

        }
    }
}
