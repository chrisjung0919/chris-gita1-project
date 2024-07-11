using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Programmer: Christopher Jung
//Date: 9/21/20
//BMI Program

namespace ProjectBMI
{
    public partial class Form1 : Form
    {
        private decimal peopleCalculated = 0;
        private decimal totalBMI = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This closes the program
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //step 1 Declare variables for storing data
            decimal feet;
            decimal inches;
            decimal weight;
            decimal weight703;
            decimal totalSize;
            decimal doubletotalSize;
            decimal realaverageBMI;

            try
            {
                //step2 Get information from the textboxes
                feet = Decimal.Parse(textHeight.Text);
                inches = Decimal.Parse(textHeight2.Text);
                weight = Decimal.Parse(textWeight.Text);
                totalSize = feet * 12 + inches;
                weight703 = weight * 703;
                doubletotalSize = totalSize * totalSize;
                //find BMI
                totalBMI = weight703 / doubletotalSize;
                peopleCalculated += 1;
                realaverageBMI = totalBMI / peopleCalculated;
                //step4 - output your information
                lblAverBMI.Text = realaverageBMI.ToString("N");
                lblPeopleCalculated.Text = peopleCalculated.ToString();
                lblBMI.Text = totalBMI.ToString("N");
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
            textHeight.Clear();
            textHeight2.Clear();
            textWeight.Clear();
            lblBMI.Text = "";
            lblAverBMI.Text = "";
            lblPeopleCalculated.Text = "";
        }
    }
}
