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
//Date: 10/30
//Description: Slot Machine Program

namespace SlotMachineProgram
{
    public partial class Form1 : Form
    {
        //generate random numbers
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        private decimal GrandPrice = 1000;
        private decimal MyCredit = 0;
        private decimal BetAmount = 0;
        private decimal CreditAdd = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This exit the program
            this.Close();
        }

        private void btnAddCredit_Click(object sender, EventArgs e)
        {
            CreditAdd = int.Parse(textCreditAdd.Text);
            MyCredit = CreditAdd;
            lblCredit.Text = MyCredit.ToString();
            lblGrandPrice.Text = GrandPrice.ToString();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //step 1 Declare variables for storing data
            decimal SlotRoll = 0;
            decimal SlotRoll2 = 0;
            decimal SlotRoll3 = 0;
            int SlotRandom = r.Next(1, 7);
            int SlotRandom2 = r.Next(1, 7);
            int SlotRandom3 = r.Next(1, 7);

            try
            {
                //step 2 get information from the text boxes

                CreditAdd = int.Parse(textCreditAdd.Text);
                MyCredit = CreditAdd;

                //step 3 calculations
                if (RAD1.Checked)
                    {
                        BetAmount += 1;
                        GrandPrice += 1;
                    }
                    else if (RAD2.Checked)
                    {
                        BetAmount += 2;
                        GrandPrice += 2;
                    }
                    else if (RAD3.Checked)
                    {
                        BetAmount += 3;
                        GrandPrice += 3;
                    }
                    else if (RAD4.Checked)
                    {
                        BetAmount += 4;
                        GrandPrice += 4;
                    }
                    else
                    {
                        BetAmount += 5;
                        GrandPrice += 5;
                    }
                    if (SlotRandom == 1)
                    {
                        pic1.Image = picCherry1.Image;
                        SlotRoll = 1;
                    }
                    else if (SlotRandom == 2)
                    {
                        pic1.Image = picGrape1.Image;
                        SlotRoll = 2;
                    }
                    else if (SlotRandom == 3)
                    {
                        pic1.Image = picMelon1.Image;
                        SlotRoll = 3;
                    }
                    else if (SlotRandom == 4)
                    {
                        pic1.Image = picOrange1.Image;
                        SlotRoll = 4;
                    }
                    else if (SlotRandom == 5)
                    {
                        pic1.Image = picPear1.Image;
                        SlotRoll = 5;
                    }
                    else if (SlotRandom == 6)
                    {
                        pic1.Image = picStrawberry1.Image;
                        SlotRoll = 6;
                    }
                    if (SlotRandom2 == 1)
                    {
                        pic2.Image = picCherry2.Image;
                        SlotRoll2 = 1;
                    }
                    else if (SlotRandom2 == 2)
                    {
                        pic2.Image = picGrape2.Image;
                        SlotRoll2 = 2;
                    }
                    else if (SlotRandom2 == 3)
                    {
                        pic2.Image = picMelon2.Image;
                        SlotRoll2 = 3;
                    }
                    else if (SlotRandom2 == 4)
                    {
                        pic2.Image = picOrange2.Image;
                        SlotRoll2 = 4;
                    }
                    else if (SlotRandom2 == 5)
                    {
                        pic2.Image = picPear2.Image;
                        SlotRoll2 = 5;
                    }
                    else if (SlotRandom2 == 6)
                    {
                        pic2.Image = picStrawberry2.Image;
                        SlotRoll2 = 6;
                    }
                    if (SlotRandom3 == 1)
                    {
                        pic3.Image = picCherry3.Image;
                        SlotRoll3 = 1;
                    }
                    else if (SlotRandom3 == 2)
                    {
                        pic3.Image = picGrape3.Image;
                        SlotRoll3 = 2;
                    }
                    else if (SlotRandom3 == 3)
                    {
                        pic3.Image = picMelon3.Image;
                        SlotRoll3 = 3;
                    }
                    else if (SlotRandom3 == 4)
                    {
                        pic3.Image = picOrange3.Image;
                        SlotRoll3 = 4;
                    }
                    else if (SlotRandom3 == 5)
                    {
                        pic3.Image = picPear3.Image;
                        SlotRoll3 = 5;
                    }
                    else if (SlotRandom3 == 6)
                    {
                        pic3.Image = picStrawberry3.Image;
                        SlotRoll3 = 6;
                    }

                    if (SlotRoll == 1 && SlotRoll2 == 1 && SlotRoll3 == 1)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (SlotRoll == 2 && SlotRoll2 == 2 && SlotRoll3 == 2)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (SlotRoll == 3 && SlotRoll2 == 3 && SlotRoll3 == 3)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (SlotRoll == 4 && SlotRoll2 == 4 && SlotRoll3 == 4)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (SlotRoll == 5 && SlotRoll2 == 5 && SlotRoll3 == 5)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (SlotRoll == 6 && SlotRoll2 == 6 && SlotRoll3 == 6)
                    {
                    MessageBox.Show("Grand Price:" + GrandPrice, "Congratulations!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    MyCredit -= BetAmount;
                    if (MyCredit < 0)
                    {
                    MessageBox.Show("Put in your credit", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    //Store Summary Output
                    lblCredit.Text = MyCredit.ToString();
                    lblGrandPrice.Text = GrandPrice.ToString();
                    }
            
            catch
            {
                MessageBox.Show("Enter Data", "Data Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RAD1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
