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
//Date: 10/2/20
//Dice Program

namespace DiceGame
{
    public partial class btnReset : Form
    {
        //generate random numbers
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
       

        private decimal NumRolls = 0;
        private decimal num2 = 0;
        private decimal num3 = 0;
        private decimal num4 = 0;
        private decimal num5 = 0;
        private decimal num6 = 0;
        private decimal num7 = 0;
        private decimal num8 = 0;
        private decimal num9 = 0;
        private decimal num10 = 0;
        private decimal num11 = 0;
        private decimal num12 = 0;
        private decimal proba2 = 0;
        private decimal proba3 = 0;
        private decimal proba4 = 0;
        private decimal proba5 = 0;
        private decimal proba6 = 0;
        private decimal proba7 = 0;
        private decimal proba8 = 0;
        private decimal proba9 = 0;
        private decimal proba10 = 0;
        private decimal proba11 = 0;
        private decimal proba12 = 0;
        public btnReset()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This close the program
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                    picboxdice1.Image = picdice1.Image;
                    diceRoll1 = 1;
                    lbldiceroll1.Text = "1";
                    
                }
                else if(diceRandom == 2)
                {
                    picboxdice1.Image = picdice2.Image;
                    diceRoll1 = 2;
                    lbldiceroll1.Text = "2";
                    
                }
                else if(diceRandom == 3)
                {
                    picboxdice1.Image = picdice3.Image;
                    diceRoll1 = 3;
                    lbldiceroll1.Text = "3";
                    
                }
                else if(diceRandom == 4)
                {
                    picboxdice1.Image = picdice4.Image;
                    diceRoll1 = 4;
                    lbldiceroll1.Text = "4";
                    
                }
                else if (diceRandom == 5)
                {
                    picboxdice1.Image = picdice5.Image;
                    diceRoll1 = 5;
                    lbldiceroll1.Text = "5";
                    
                }
                else if (diceRandom == 6)
                {
                    picboxdice1.Image = picdice6.Image;
                    diceRoll1 = 6;
                    lbldiceroll1.Text = "6";
                    
                }


                if (diceRandom2 == 1)
                {
                    picboxdice2.Image = dice1.Image;
                    diceRoll2 = 1;
                    lbldiceroll2.Text = "1";
                    
                }
                else if (diceRandom2 == 2)
                {
                    picboxdice2.Image = dice2.Image;
                    diceRoll2 = 2;
                    lbldiceroll2.Text = "2";
                    
                }
                else if (diceRandom2 == 3)
                {
                    picboxdice2.Image = dice3.Image;
                    diceRoll2 = 3;
                    lbldiceroll2.Text = "3";
                    
                }
                else if (diceRandom2 == 4)
                {
                    picboxdice2.Image = dice4.Image;
                    diceRoll2 = 4;
                    lbldiceroll2.Text = "4";
                    
                }
                else if (diceRandom2 == 5)
                {
                    picboxdice2.Image = dice5.Image;
                    diceRoll2 = 5;
                    lbldiceroll2.Text = "5";
                    
                }
                else if (diceRandom2 == 6)
                {
                    picboxdice2.Image = dice6.Image;
                    diceRoll2 = 6;
                    lbldiceroll2.Text = "6";
                    
                }

                //step2 Calculations
                SumofDice = diceRoll1 + diceRoll2;
                if (SumofDice == 2)
                {
                    num2 += 1;
                    proba2 = num2 / NumRolls * 100;
                    lbl2.Text = num2.ToString();
                    prob2.Text = proba2.ToString("N");
                }
                if (SumofDice == 3)
                {
                    num3 += 1;
                    proba3 = num3 / NumRolls * 100;
                    lbl3.Text = num3.ToString();
                    prob3.Text = proba3.ToString("N");
                }
                if (SumofDice == 4)
                {
                    num4 += 1;
                    proba4 = num4 / NumRolls * 100;
                    lbl4.Text = num4.ToString();
                    prob4.Text = proba4.ToString("N");
                }
                if (SumofDice == 5)
                {
                    num5 += 1;
                    proba5 = num5 / NumRolls * 100;
                    lbl5.Text = num5.ToString();
                    prob5.Text = proba5.ToString("N");
                }
                if (SumofDice == 6)
                {
                    num6 += 1;
                    proba6 = num6 / NumRolls * 100;
                    lbl6.Text = num6.ToString();
                    prob6.Text = proba6.ToString("N");
                }
                if (SumofDice == 7)
                {
                    num7 += 1;
                    proba7 = num7 / NumRolls * 100;
                    lbl7.Text = num7.ToString();
                    prob7.Text = proba7.ToString("N");
                }
                if (SumofDice == 8)
                {
                    num8 += 1;
                    proba8 = num8 / NumRolls * 100;
                    lbl8.Text = num8.ToString();
                    prob8.Text = proba8.ToString("N");
                }
                if (SumofDice == 9)
                {
                    num9 += 1;
                    proba9 = num9 / NumRolls * 100;
                    lbl9.Text = num9.ToString();
                    prob9.Text = proba9.ToString("N");
                }
                if (SumofDice == 10)
                {
                    num10 += 1;
                    proba10 = num10 / NumRolls * 100;
                    lbl10.Text = num10.ToString();
                    prob10.Text = proba10.ToString("N");
                }
                if (SumofDice == 11)
                {
                    num11 += 1;
                    proba11 = num11 / NumRolls * 100;
                    lbl11.Text = num11.ToString();
                    prob11.Text = proba11.ToString("N");
                }
                if (SumofDice == 12)
                {
                    num12 += 1;
                    proba12 = num12 / NumRolls * 100;
                    lbl12.Text = num12.ToString();
                    prob12.Text = proba12.ToString("N");
                }
                //Store Summary Output
                lblSumDice.Text = SumofDice.ToString();
                lblNumRolls.Text = NumRolls.ToString();
                lbl2.Text = num2.ToString();
                lbl3.Text = num3.ToString();
                lbl4.Text = num4.ToString();
                lbl5.Text = num5.ToString();
                lbl6.Text = num6.ToString();
                lbl7.Text = num7.ToString();
                lbl8.Text = num8.ToString();
                lbl9.Text = num9.ToString();
                lbl10.Text = num10.ToString();
                lbl11.Text = num11.ToString();
                lbl12.Text = num12.ToString();
                prob2.Text = proba2.ToString("N");
                prob3.Text = proba3.ToString("N");
                prob4.Text = proba4.ToString("N");
                prob5.Text = proba5.ToString("N");
                prob6.Text = proba6.ToString("N");
                prob7.Text = proba7.ToString("N");
                prob8.Text = proba8.ToString("N");
                prob9.Text = proba9.ToString("N");
                prob10.Text = proba10.ToString("N");
                prob11.Text = proba11.ToString("N");
                prob12.Text = proba12.ToString("N");
                lbldiceroll1.Text = diceRoll1.ToString();
                lbldiceroll2.Text = diceRoll2.ToString();
            }
            catch
            {
                MessageBox.Show("Enter Data", "Data Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //This clears the data
            clearData();
        }

        private void clearData()
        {
            lbldiceroll1.Text = "";
            lbldiceroll2.Text = "";
            lblSumDice.Text = "";
            lblNumRolls.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            prob2.Text = "";
            prob3.Text = "";
            prob4.Text = "";
            prob5.Text = "";
            prob6.Text = "";
            prob7.Text = "";
            prob8.Text = "";
            prob9.Text = "";
            prob10.Text = "";
            prob11.Text = "";
            prob12.Text = "";
            picboxdice1.Image = null;
            picboxdice2.Image = null;
        }
    }
}
