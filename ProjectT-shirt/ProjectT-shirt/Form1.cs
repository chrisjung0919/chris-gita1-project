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
//Date: 10/23
//Description: T-shirt Program

namespace ProjectT_shirt
{
    public partial class Form1 : Form
    {
        //declare our global level variables
        //declare constants- these hold the prices of the T-shirts

        const decimal SMALL_PRICE = 10m;
        const decimal MEDIUM_PRICE = 10m;
        const decimal LARGE_PRICE = 10m;
        const decimal XL_PRICE = 11m;
        const decimal XXL_PRICE = 12m;
        const decimal MONOGRAM_Rate = 2m;
        const decimal POCKET_Rate = 1m;

        private decimal subTotal = 0m;
        private decimal totalSales = 0m;
        private int totalCustomer = 0;
        private decimal totalDecimal = 0m;
        private decimal averageSale = 0m;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This exits the program
            this.Close();
        }

        private void btnAddtoCurrent_Click(object sender, EventArgs e)
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

                quantityInteger = int.Parse(textQuantity.Text);

                if (quantityInteger > 0)
                {
                    //step 3 calculations
                    if (RBS.Checked)
                    {
                        priceDecimal = SMALL_PRICE;
                    }
                    else if (RBM.Checked)
                    {
                        priceDecimal = MEDIUM_PRICE;
                    }
                    else if (RBL.Checked)
                    {
                        priceDecimal = LARGE_PRICE;
                    }
                    else if (RBXL.Checked)
                    {
                        priceDecimal = XL_PRICE;
                    }
                    else
                    {
                        priceDecimal = XXL_PRICE;
                    }

                    itemAmount = priceDecimal * quantityInteger;

                    subTotal += itemAmount;

                    if (CBMonogram.Checked)
                    {
                        taxDecimal += MONOGRAM_Rate;
                    }
                    if (CBPocket.Checked)
                    {
                        taxDecimal += POCKET_Rate;
                    }

                    totalDecimal = subTotal + taxDecimal;
                    //step 4 output your data
                    lblPrice.Text = itemAmount.ToString("C");
                    lblSubtotal.Text = subTotal.ToString("C");
                    lblTax.Text = taxDecimal.ToString("C");
                    lblTotal.Text = totalDecimal.ToString("C");
                    btnSummary.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Missing Data!", "Data Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //finalizes the order
            DialogResult resultAnswer = DialogResult;
            string messageStirng = "";
            messageStirng = "Are you sure your finished?";
            resultAnswer = MessageBox.Show(messageStirng, "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            totalSales += totalDecimal;
            //totalCustomer += 1;
            totalCustomer++;
            averageSale = totalSales / totalCustomer;

            MessageBox.Show("Your complete order" + "\n" + "Your final price is: " + totalDecimal.ToString("C"));

            totalDecimal = 0;
            subTotal = 0;
            btnSummary.Enabled = true;
            btnCleartheCurrent_Click(sender, e);
        }

        private void btnCleartheCurrent_Click(object sender, EventArgs e)
        {
            //this clears out the previous information
            textName.Clear();
            textOrder.Clear();
            textQuantity.Clear();
            CBMonogram.Checked = false;
            CBPocket.Checked = false;
            RBS.Checked = true;
            lblPrice.Text = "";
            lblSubtotal.Text = "";
            lblTotal.Text = "";
            lblTax.Text = "";
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //manager stats
            string managerStats = "";
            managerStats = "total Sales: " + totalSales.ToString("C") + "\n" + "Average Sale: " + averageSale.ToString("C");

            MessageBox.Show(managerStats, "Store Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
