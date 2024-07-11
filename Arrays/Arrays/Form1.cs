using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        //set up array for fish tank
        PictureBox[] theTank = new PictureBox[4];
        int fishPos = 0;
        Boolean onOff = false;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the tank
            theTank[0] = picBox0;
            theTank[1] = picBox1;
            theTank[2] = picBox2;
            theTank[3] = picBox3;
            fishPos = r.Next(0, 4);

            theTank[fishPos].Image = Fish.Image;

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            moveFish();
        }

        private void moveFish()
        {
            theTank[fishPos].Image = null;
            fishPos = r.Next(0, 4);

            theTank[fishPos].Image = Fish.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //auto moves fish
            moveFish();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if(onOff == false)
            {
                timer1.Enabled = true;
                onOff = true;
            }
            else if (onOff == true)
            {
                timer1.Enabled = false;
                onOff = false;
            }
        }
    }
}
