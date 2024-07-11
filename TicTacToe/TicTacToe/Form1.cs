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
//Date: 1/5/21
//TicTacToe

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean onOff = false;

        private decimal p1X = 0;
        private decimal p2X = 0;
        private decimal p3X = 0;
        private decimal p4X = 0;
        private decimal p5X = 0;
        private decimal p6X = 0;
        private decimal p7X = 0;
        private decimal p8X = 0;
        private decimal p9X = 0;
        private decimal p1O = 0;
        private decimal p2O = 0;
        private decimal p3O = 0;
        private decimal p4O = 0;
        private decimal p5O = 0;
        private decimal p6O = 0;
        private decimal p7O = 0;
        private decimal p8O = 0;
        private decimal p9O = 0;
        private decimal count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void p8_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p8.Image = o8.Image;
                p8.Enabled = false;
                p8O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p8.Image = x8.Image;
                p8.Enabled = false;
                p8X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p1.Image = o1.Image;
                p1.Enabled = false;
                p1O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p1.Image = x1.Image;
                p1.Enabled = false;
                p1X = 1;
                onOff = false;
                count += 1;
            }
            //player O
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p2.Image = o2.Image;
                p2.Enabled = false;
                p2O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p2.Image = x2.Image;
                p2.Enabled = false;
                p2X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p3.Image = o3.Image;
                p3.Enabled = false;
                p3O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p3.Image = x3.Image;
                p3.Enabled = false;
                p3X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {

            if (onOff == false)
            {
                p4.Image = o4.Image;
                p4.Enabled = false;
                p4O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p4.Image = x4.Image;
                p4.Enabled = false;
                p4X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p5_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p5.Image = o5.Image;
                p5.Enabled = false;
                p5O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p5.Image = x5.Image;
                p5.Enabled = false;
                p5X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p6_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p6.Image = o6.Image;
                p1.Enabled = false;
                p6O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p6.Image = x6.Image;
                p6.Enabled = false;
                p6X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p7_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p7.Image = o7.Image;
                p7.Enabled = false;
                p7O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p7.Image = x7.Image;
                p7.Enabled = false;
                p7X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void p9_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                p9.Image = o9.Image;
                p9.Enabled = false;
                p9O = 1;
                onOff = true;
                count += 1;
            }
            else if (onOff == true)
            {
                p9.Image = x9.Image;
                p9.Enabled = false;
                p9X = 1;
                onOff = false;
                count += 1;
            }
            if (p1O == 1 && p2O == 1 && p3O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4O == 1 && p5O == 1 && p6O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7O == 1 && p8O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p4O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2O == 1 && p5O == 1 && p8O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p6O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1O == 1 && p5O == 1 && p9O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3O == 1 && p5O == 1 && p7O == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //player X
            if (p1X == 1 && p2X == 1 && p3X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p4X == 1 && p5X == 1 && p6X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p7X == 1 && p8X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p4X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2X == 1 && p5X == 1 && p8X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p6X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1X == 1 && p5X == 1 && p9X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p3X == 1 && p5X == 1 && p7X == 1)
            {
                MessageBox.Show("You Win!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (count == 9)
            {
                MessageBox.Show("Tie Game!", "Tie!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            p1.Image = null;
            p2.Image = null;
            p3.Image = null;
            p4.Image = null;
            p5.Image = null;
            p6.Image = null;
            p7.Image = null;
            p8.Image = null;
            p9.Image = null;
            p1.Enabled = true;
            p2.Enabled = true;
            p3.Enabled = true;
            p4.Enabled = true;
            p5.Enabled = true;
            p6.Enabled = true;
            p7.Enabled = true;
            p8.Enabled = true;
            p9.Enabled = true;
            p1O = 0;
            p2O = 0;
            p3O = 0;
            p4O = 0;
            p5O = 0;
            p6O = 0;
            p7O = 0;
            p8O = 0;
            p9O = 0;
            p1X = 0;
            p2X = 0;
            p3X = 0;
            p4X = 0;
            p5X = 0;
            p6X = 0;
            p7X = 0;
            p8X = 0;
            p9X = 0;
            onOff = false;
            count = 0;
        }
    }
}
