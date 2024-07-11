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
//Date: 1/15/21
//N!

namespace N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSequence_Click(object sender, EventArgs e)
        {
            int sequence = 0;
            int howmanysequence = int.Parse(txtSequence.Text);

            string messageStringsequence = "";

            int totalvaluesequence = 0;

            //Create a for loop to generate the numbers
            for (int theCounter = 0; theCounter < howmanysequence; theCounter++)
            {
                sequence += 1;
                totalvaluesequence += sequence;

                messageStringsequence += sequence + "\n";
            }
            lblSequence.Text = messageStringsequence;
            resultSequence.Text = "Total: " + totalvaluesequence;

        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int even = 0;
            int howmanyeven = int.Parse(txtEven.Text);

            string messageStringeven = "";

            int totalvalueeven = 0;

            //Create a for loop to generate the numbers
            for (int theCounter2 = 0; theCounter2 < howmanyeven; theCounter2++)
            {
                even += 2;
                totalvalueeven += even;

                messageStringeven += even + "\n";
            }
            lblEven.Text = messageStringeven;
            resultEven.Text = "Total: " + totalvalueeven;

        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            int odd = -1;
            int howmanyodd = int.Parse(txtOdd.Text);

            string messageStringodd = "";

            int totalvalueodd = 0;

            //Create a for loop to generate the numbers
            for (int theCounter3 = 0; theCounter3 < howmanyodd; theCounter3++)
            {
                odd += 2;
                totalvalueodd += odd;

                messageStringodd += odd + "\n";
            }
            lblOdd.Text = messageStringodd;
            resultOdd.Text = "Total: " + totalvalueodd;

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int fact = 0;
            int howmanyfact = int.Parse(txtFactorial.Text);

            string messageStringfact = "";

            int totalvaluefact = 1;

            //Create a for loop to generate the numbers
            for (int theCounter4 = 0; theCounter4 < howmanyfact; theCounter4++)
            {
                fact += 1;
                totalvaluefact *= fact;

                messageStringfact += fact + "\n";
            }
            lblFactorial.Text = messageStringfact;
            resultFactorial.Text = "Total: " + totalvaluefact;

        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int fibon;
            int first = 0;
            int second = 1;
            
            int howmanyfibon = int.Parse(txtFibonacci.Text);

            string messageStringfibon = "";

            int totalvaluefibon = 0;

            //Create a for loop to generate the numbers
            for (int theCounter5= 0; theCounter5 < howmanyfibon; theCounter5++)
            {
                if (theCounter5 <= 1)
                {
                    fibon = theCounter5;
                }
                else
                {
                    fibon = first + second;
                    first = second;
                    second = fibon;
                }
                totalvaluefibon += fibon;

                messageStringfibon += fibon + "\n";
            }
            lblFibonacci.Text = messageStringfibon;
            resultFibonacci.Text = "Total: " + totalvaluefibon;

        }
    }
}
