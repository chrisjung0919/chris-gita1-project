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
//Date: 11/16
//Description: Rock Paper Sissor Program

namespace RockSissorPaper
{
    public partial class Form1 : Form
    {
        //declare our global level variables
        private decimal rock1;
        private decimal paper1;
        private decimal sissor1;
        private decimal rock2;
        private decimal paper2;
        private decimal sissor2;
        private decimal p1choice;
        private decimal p2choice;
        private decimal player1win = 0;
        private decimal player2win = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //step 1 declare the local variable
            if (P1Rock.Checked)
            {
                picblank1.Image = Rock1.Image;
                pictureBox1.Visible = true;
                p1choice = 1;
            }
            else if (P1Paper.Checked)
            {
                picblank1.Image = Paper1.Image;
                pictureBox1.Visible = true;
                p1choice = 2;
            }
            else if (P1Sissors.Checked)
            {
                picblank1.Image = Sissor1.Image;
                pictureBox1.Visible = true;
                p1choice = 3;
            }
            if (P2Rock.Checked)
            {
                picblank2.Image = Rock2.Image;
                pictureBox2.Visible = true;
                p2choice = 1;
            }
            else if (P2Paper.Checked)
            {
                picblank2.Image = Paper2.Image;
                pictureBox2.Visible = true;
                p2choice = 2;
            }
            else if (P2Sissors.Checked)
            {
                picblank2.Image = Sissor2.Image;
                pictureBox2.Visible = true;
                p2choice = 3;
            }
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            if (p1choice == 1 && p2choice == 1)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("It's a tie!", "Tie!",
                MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1choice == 2 && p2choice == 2)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("It's a tie!", "Tie!",
                MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1choice == 3 && p2choice == 3)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("It's a tie!", "Tie!",
                MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p1choice == 1 && p2choice == 2)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player2 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player2win += 1;
            }
            if (p1choice == 1 && p2choice == 3)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player1 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player1win += 1;
            }
            if (p1choice == 2 && p2choice == 1)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player1 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player1win += 1;
            }
            if (p1choice == 2 && p2choice == 3)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player2 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player2win += 1;
            }
            if (p1choice == 3 && p2choice == 1)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player2 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player2win += 1;
            }
            if (p1choice == 3 && p2choice == 2)
            {
                player1choice.Visible = false;
                player2choice.Visible = false;
                MessageBox.Show("Player1 wins!", "Winner!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                player1win += 1;
            }
            //Store Summary Output
            Player1wins.Text = player1win.ToString();
            Player2wins.Text = player2win.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //This clears the data
            player1choice.Visible = true;
            player2choice.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            P1Rock.Checked = false;
            P1Paper.Checked = false;
            P1Sissors.Checked = false;
            P2Rock.Checked = false;
            P2Paper.Checked = false;
            P2Sissors.Checked = false;
            picblank1.Image = null;
            picblank2.Image = null;
        }
    }
}