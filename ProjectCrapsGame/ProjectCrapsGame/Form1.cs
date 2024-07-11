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
//Date: 10/9/20
//Craps Game

namespace ProjectCrapsGame
{
    public partial class form1 : Form
    {
        //generate random numbers
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);


        private decimal NumRolls = 0;
        private decimal Point = 0;

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This close the program
            this.Close();
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you get 7 or 11 you win the bet"+"\n"+"If you get 2 3 or 12 you lose the bet"+"\n"+
                "If you get other numbers you put a point and get a second roll", "Rule", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //step 1 Declare variables for storing data
            decimal SumofDice = 0;
            decimal diceRoll1 = 0;
            decimal diceRoll2 = 0;
            int diceRandom = r.Next(1, 7);
            int diceRandom2 = r.Next(1, 7);

            try
            {
                NumRolls += 1;

                if (diceRandom == 1)
                {
                    picBlank1.Image = picnum1.Image;
                    diceRoll1 = 1;
                    lblRoll1.Text = "1";

                }
                else if (diceRandom == 2)
                {
                    picBlank1.Image = picnum2.Image;
                    diceRoll1 = 2;
                    lblRoll1.Text = "2";

                }
                else if (diceRandom == 3)
                {
                    picBlank1.Image = picnum3.Image;
                    diceRoll1 = 3;
                    lblRoll1.Text = "3";

                }
                else if (diceRandom == 4)
                {
                    picBlank1.Image = picnum4.Image;
                    diceRoll1 = 4;
                    lblRoll1.Text = "4";

                }
                else if (diceRandom == 5)
                {
                    picBlank1.Image = picnum5.Image;
                    diceRoll1 = 5;
                    lblRoll1.Text = "5";

                }
                else if (diceRandom == 6)
                {
                    picBlank1.Image = picnum6.Image;
                    diceRoll1 = 6;
                    lblRoll1.Text = "6";

                }

                if (diceRandom2 == 1)
                {
                    picBlank2.Image = rollnum1.Image;
                    diceRoll2 = 1;
                    lblRoll2.Text = "1";

                }
                else if (diceRandom2 == 2)
                {
                    picBlank2.Image = rollnum2.Image;
                    diceRoll2 = 2;
                    lblRoll2.Text = "2";

                }
                else if (diceRandom2 == 3)
                {
                    picBlank2.Image = rollnum3.Image;
                    diceRoll2 = 3;
                    lblRoll2.Text = "3";

                }
                else if (diceRandom2 == 4)
                {
                    picBlank2.Image = rollnum4.Image;
                    diceRoll2 = 4;
                    lblRoll2.Text = "4";

                }
                else if (diceRandom2 == 5)
                {
                    picBlank2.Image = rollnum5.Image;
                    diceRoll2 = 5;
                    lblRoll2.Text = "5";

                }
                else if (diceRandom2 == 6)
                {
                    picBlank2.Image = rollnum6.Image;
                    diceRoll2 = 6;
                    lblRoll2.Text = "6";

                }
                //step2 Calculations
                SumofDice = diceRoll1 + diceRoll2;
                if (NumRolls == 1)
                {
                    if (SumofDice == 7)
                    {
                        MessageBox.Show("You Rolled a 7", "Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 11)
                    {
                        MessageBox.Show("You Rolled a 11", "Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 2)
                    {
                        MessageBox.Show("You Rolled a 2", "You Lost.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 3)
                    {
                        MessageBox.Show("You Rolled a 3", "You Lost.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 12)
                    {
                        MessageBox.Show("You Rolled a 12", "You Lost.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 4)
                    {
                        Point = 4;
                        lblPoint.Text = Point.ToString();
                        pic4.Visible = true;
                    }
                    if (SumofDice == 5)
                    {
                        Point = 5;
                        lblPoint.Text = Point.ToString();
                        pic5.Visible = true;
                    }
                    if (SumofDice == 6)
                    {
                        Point = 6;
                        lblPoint.Text = Point.ToString();
                        pic6.Visible = true;
                    }
                    if (SumofDice == 8)
                    {
                        Point = 8;
                        lblPoint.Text = Point.ToString();
                        pic8.Visible = true;
                    }
                    if (SumofDice == 9)
                    {
                        Point = 9;
                        lblPoint.Text = Point.ToString();
                        pic9.Visible = true;
                    }
                    if (SumofDice == 10)
                    {
                        Point = 10;
                        lblPoint.Text = Point.ToString();
                        pic10.Visible = true;
                    }

                }
                else if (NumRolls >= 1)
                {
                    if (SumofDice == Point)
                    {
                        MessageBox.Show("Lucky!", "Winner!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                    if (SumofDice == 7)
                    {
                        MessageBox.Show("Unlucky!", "You Lost.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblRoll1.Text = "";
                        lblRoll2.Text = "";
                        lblRollNum.Text = "";
                        lblSum.Text = "";
                        lblPoint.Text = "";
                        picBlank1.Image = null;
                        picBlank2.Image = null;
                        pic4.Visible = false;
                        pic5.Visible = false;
                        pic6.Visible = false;
                        pic8.Visible = false;
                        pic9.Visible = false;
                        pic10.Visible = false;
                        clearData();
                    }
                }
                
                //Store Summary Output
                lblSum.Text = SumofDice.ToString();
                lblRollNum.Text = NumRolls.ToString();
                lblRoll1.Text = diceRoll1.ToString();
                lblRoll2.Text = diceRoll2.ToString();
                lblPoint.Text = Point.ToString();
            }
            catch
            {
                
            }
        }

        private void clearData()
        {
            lblRoll1.Text = "";
            lblRoll2.Text = "";
            lblRollNum.Text = "";
            lblSum.Text = "";
            lblPoint.Text = "";
            picBlank1.Image = null;
            picBlank2.Image = null;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            pic10.Visible = false;
        }
    }
}
