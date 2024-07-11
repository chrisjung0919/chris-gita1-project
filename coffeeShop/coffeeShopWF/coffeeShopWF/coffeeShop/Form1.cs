using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Programmer: Christopher Jung
//Date: 10/20
//Description: This program teaches how to do subtotals

namespace coffeeShop
{
    public partial class frmMain : Form
    {

        //declare our global level variables
        //declare constants- these hold the prices of the coffees

        const decimal CAPPUCCINO_PRICE = 2m;
        const decimal ESPRESSO_PRICE = 2.5m;
        const decimal LATTE_PRICE= 1.75m;
        const decimal ICED_LATTE = 2.5m;
        const decimal ICED_CAPPUCCINO = 2.5m;
        const decimal TAX_RATE = 0.08m;

        private decimal subtTotal = 0m;
        private decimal totalSales = 0m;
        private int totalCustomer = 0;
        private decimal totalDecimal = 0m;
        private decimal averageSale = 0m;




        public frmMain()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //calculate and display the current amounts and totals

            //step 1 declare the local variable
            decimal priceDecimal = 0m;

            int quantityInteger = 0;
            decimal taxDecimal = 0m;
            decimal itemAmount = 0m;
            try
            {
            //step 2 get information from the text boxes

            quantityInteger = int.Parse(quantityTextBox.Text);

            if(quantityInteger > 0)
             {

             
            //step 3 calculations

            if (cappuccinoRadioButton.Checked)
            {
                priceDecimal = CAPPUCCINO_PRICE;
            }
            else if (espressoRadioButton.Checked)
            {
                priceDecimal = ESPRESSO_PRICE;
            }
            else if (LatteRadioButton.Checked)
            {
                priceDecimal = LATTE_PRICE;
            }
            else if (icedLatteRadioButton.Checked)
            {
                priceDecimal = ICED_LATTE;
            }
            else
            {
                priceDecimal = ICED_CAPPUCCINO;
            }

            itemAmount = priceDecimal * quantityInteger;

             subtTotal += itemAmount;

            if (taxCheckBox.Checked)
             {
                    taxDecimal = subtTotal * TAX_RATE;
             }
            else
             {
                    taxDecimal = 0;
             }

             totalDecimal = subtTotal + taxDecimal;
            //step 4 output your data
            itemAmountLabel.Text = itemAmount.ToString("C");

                subtotalLabel.Text = subtTotal.ToString("C");
                taxLabel.Text = taxDecimal.ToString("C");
                totalLabel.Text = totalDecimal.ToString("C");
                summaryButton.Enabled = false;
                }
            else
                {
                    //put message for quantity greater than zero
                    MessageBox.Show("Quantity needs to be greater than 0", "Data Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Missing Data!", "Data Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //finalizes the order
            DialogResult resultAnswer = DialogResult;
            string messageStirng = "";
            messageStirng = "Are you sure your finished?";
            resultAnswer = MessageBox.Show(messageStirng, "Complete Order",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultAnswer == DialogResult.Yes)
            {
                totalSales += totalDecimal;
                //totalCustomer += 1;
                totalCustomer++;
                averageSale = totalSales / totalCustomer;

                MessageBox.Show("Your complete order"+"\n"+"Your final price is: "+ totalDecimal.ToString("C"));

                totalDecimal = 0;
                subtTotal = 0;
                summaryButton.Enabled = true;
                clearButton_Click(sender, e);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this clears out the previous information
            quantityTextBox.Clear();
            //puts cursor in the textbox
            quantityTextBox.Focus();

            taxCheckBox.Checked = false;
            cappuccinoRadioButton.Checked = true;
            itemAmountLabel.Text = "";
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            //manager stats
            string managerStats = "";
            managerStats = "total Sales: " + totalSales.ToString("C")+"\n"+"Average Sale: "+averageSale.ToString("C");

            MessageBox.Show(managerStats, "Store Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This exits the program
            this.Close();

        }
    }
}
