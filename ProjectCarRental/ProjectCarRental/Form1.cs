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
//Date: 9/15/20
//Car Rental Program

namespace ProjectCarRental
{
    public partial class Form1 : Form
    {
        private decimal returnedCars = 0;
        private decimal totalSales = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This close the program
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This button concatenates the text form
            //the textboxes
            lblCustomerInfo.Text = textName.Text + "\n" + textAddress.Text +

            "\n" + textCity.Text + "," + textState.Text + " " +

            textZipCode.Text;
            //step 1 Declare variables for storing data
            decimal beginningOdometer;
            decimal endingOdometer;
            decimal numDaysRented;
            decimal milesDriven;
            decimal totalCharge;
            decimal averageSale;

            try
            {
                //step2 Get information from the textboxes
                beginningOdometer = Decimal.Parse(textBeginningOdometer.Text);
                endingOdometer = Decimal.Parse(textEndingOdometer.Text);

                numDaysRented = Decimal.Parse(textNumDaysRent.Text);
                //step3 Calculations
                milesDriven = endingOdometer - beginningOdometer;
                totalCharge = milesDriven * numDaysRented;
                //manager calculations
                returnedCars += 1;
                totalSales = milesDriven * numDaysRented;
                averageSale = totalSales / returnedCars;
                //step4 - output your information
                lblMilesDriven.Text = milesDriven.ToString();
                lblTotalCharge.Text = totalCharge.ToString("C");
                //Store Summary Output
                lblTotalSales.Text = totalSales.ToString("C");
                lblReturnedCars.Text = returnedCars.ToString();
                lblAverageSales.Text = averageSale.ToString("C");


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
            textName.Clear();
            textAddress.Clear();
            textCity.Clear();
            textState.Clear();
            textZipCode.Clear();
            textBeginningOdometer.Clear();
            textEndingOdometer.Clear();
            textNumDaysRent.Clear();
            lblCustomerInfo.Text = "";
            lblMilesDriven.Text = "";
            lblTotalCharge.Text = "";
        }
    }
 }
