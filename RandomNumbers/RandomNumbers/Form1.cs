using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {

        //generate random numbers
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        String numberString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int myRandom = r.Next(1, 11);

            lblMessage.Text = myRandom.ToString() + "\n";
            numberString += myRandom + "\n";


            //decision making

            if(myRandom == 7)
            {
                MessageBox.Show("Lucky 7", "WInner!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(myRandom > 0 && myRandom < 7)
            {
                MessageBox.Show("You like small numbers", "Not seven", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (myRandom == 8 || myRandom == 10)
            {
                MessageBox.Show("Good Gaming numbers!", "Like It!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lblMessage.Text = numberString;
        }

        private void btnforloop_Click(object sender, EventArgs e)
        {
            //generate multiple random numbers
            int randomInteger;
            System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

            string messageString = "";

            int Howmanynumber = int.Parse(txthowmany.Text);

            int maxvalue = 0;
            int totalvalue = 0;

            //Create a for loop to generate the numbers
            for(int theCounter = 0; theCounter < Howmanynumber; theCounter++)
            {
                randomInteger = r.Next(1, 11);

                totalvalue += randomInteger;

                if(randomInteger > maxvalue)
                {
                    maxvalue = randomInteger;
                }


                messageString += randomInteger + "\n";

            }

            lblMessage.Text = messageString + "\n" + "Largest Number= " + maxvalue + "Total= " + totalvalue;

        }
    }
}
