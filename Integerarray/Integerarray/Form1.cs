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
//Date: 3/8/21
//Integer array

namespace Integerarray
{
    public partial class Form1 : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        int[] Numbers = new int[5000];

        private decimal numcount = 0;
        private decimal totalnum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string messageString = "";
            decimal average = 0;
            int maxvalue = 0;
            int minvalue = 5000;
            
            //find average
            for(int i = 0; i < 5000; i++)
            {
                numcount += 1;
                Numbers[i] = r.Next(0, 5001);
                messageString += Numbers[i] + "\t";
                totalnum += Numbers[i];
                average = totalnum / numcount;

                //find highest number
                if (Numbers[i] > maxvalue)
                {
                    maxvalue = Numbers[i];
                }

                //find lowest number
                if (Numbers[i] < minvalue)
                {
                    minvalue = Numbers[i];
                }

            }
            Message.Text = messageString;
            lblaverage.Text = average.ToString();
            lblhighest.Text = maxvalue.ToString();
            lbllowest.Text = minvalue.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
