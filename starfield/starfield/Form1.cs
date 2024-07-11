using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starfield
{
    public partial class Form1 : Form
    {

        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Label[] Universe = new Label[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the universe
            Universe[0] = lblStar0;
            Universe[1] = lblStar1;
            Universe[2] = lblStar2;
            Universe[3] = lblStar3;
            Universe[4] = lblStar4;
            Universe[5] = lblStar5;
            Universe[6] = lblStar6;
            Universe[7] = lblStar7;

            //randomly place stars in the universe
            for(int n=0; n<Universe.Length; n++)
            {
                Universe[n].Left = r.Next(0, this.Width);
                Universe[n].Top = r.Next(0, this.Height);

                int theWidth = r.Next(1, 11);
                Universe[n].Width = theWidth;
                Universe[n].Height = theWidth;
            }

        }

        private void moveStars()
        {
            for(int i =0; i < Universe.Length; i++)
            {
                Universe[i].Width += 1;
                Universe[i].Height += 1;

                if(Universe[i].Width > 10)
                {
                    Universe[i].Left = r.Next(0, this.Width);
                    Universe[i].Top = r.Next(0, this.Height);

                    Universe[i].Width = 1;
                    Universe[i].Height = 1;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveStars();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens another form
            Form2 openform = new Form2();
            openform.ShowDialog();
        }
    }
}
