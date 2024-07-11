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
//Date: 9/29/20
//Test Score Program

namespace TestScoreProject
{
    public partial class TestScore : Form
    {
        public TestScore()
        {
            InitializeComponent();
        }

        private void Tboxleft1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This close the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //step 1 Declare variables for storing data
            decimal TestScoreLeft1;
            decimal TestScoreRight1;
            decimal TestScoreLeft2;
            decimal TestScoreRight2;
            decimal Grade1;
            decimal Grade2;
            decimal AverGrade;

            try
            {

                //step2 Get information from the textboxes
                TestScoreLeft1 = Decimal.Parse(Tboxleft1.Text);
                TestScoreRight1 = Decimal.Parse(Tboxright1.Text);
                TestScoreLeft2 = Decimal.Parse(Tboxleft2.Text);
                TestScoreRight2 = Decimal.Parse(Tboxright2.Text);
                //step3 Calculations
                Grade1 = (TestScoreLeft1 / TestScoreRight1) * 100;
                Grade2 = (TestScoreLeft2 / TestScoreRight2) * 100;
                AverGrade = (Grade1 + Grade2) / 2;
                if (Grade1 == 100)
                {
                    lblGrade1.Text = "A+";
                }
                else if (Grade1 <= 99 && Grade1 >= 90)
                {
                    lblGrade1.Text = "A";
                }
                else if (Grade1 <= 89 && Grade1 >= 80)
                {
                    lblGrade1.Text = "B";
                }
                else if (Grade1 <= 79 && Grade1 >= 70)
                {
                    lblGrade1.Text = "C";
                }
                else if (Grade1 <= 69 && Grade1 >= 60)
                {
                    lblGrade1.Text = "D";
                }
                else if (Grade1 <= 59 && Grade1 >= 50)
                {
                    lblGrade1.Text = "F";
                }
                if (Grade2 == 100)
                {
                    lblGrade2.Text = "A+";
                }
                else if (Grade2 <= 99 && Grade2 >= 90)
                {
                    lblGrade2.Text = "A";
                }
                else if (Grade2 <= 89 && Grade2 >= 80)
                {
                    lblGrade2.Text = "B";
                }
                else if (Grade2 <= 79 && Grade2 >= 70)
                {
                    lblGrade2.Text = "C";
                }
                else if (Grade2 <= 69 && Grade2 >= 60)
                {
                    lblGrade2.Text = "D";
                }
                else if (Grade2 <= 59 && Grade2 >= 50)
                {
                    lblGrade2.Text = "F";
                }

                if (Grade1 > Grade2)
                {
                    lblHigherGrade.Text = "Test 1";
                }
                else
                {
                    lblHigherGrade.Text = "Test 2";
                }
                //Store Summary Output
                lblAverGrade.Text = AverGrade.ToString("N");
                
            }
            catch
            {
                MessageBox.Show("Enter Data", "Data Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //This clears the data
            clearData();
        }

        private void clearData()
        {
            Tboxleft1.Clear();
            Tboxright1.Clear();
            Tboxleft2.Clear();
            Tboxright2.Clear();
            lblAverGrade.Text = "";
            lblHigherGrade.Text = "";
            lblGrade1.Text = "";
            lblGrade2.Text = "";

        }
    }
}
