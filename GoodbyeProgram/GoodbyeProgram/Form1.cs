using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Christopher Jung
//Date: 9/1/20
//Project Description: This program demonstrates how to change the word "Good Bye" into other languages

namespace GoodbyeProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Spainish_Click(object sender, EventArgs e)
        {
            //change to Spanish
            GoodBye.Text = "Adiós";
        }

        private void French_Click(object sender, EventArgs e)
        {
            //change to French
            GoodBye.Text = "Au revoir";
        }

        private void Korean_Click(object sender, EventArgs e)
        {
            //change to Korean
            GoodBye.Text = "안녕히 계세요";
        }

        private void Chinese_Click(object sender, EventArgs e)
        {
            //change to Chinese
            GoodBye.Text = "再见";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close project
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //change to "Good Bye"
            GoodBye.Text = "Good Bye";
        }
    }
}
