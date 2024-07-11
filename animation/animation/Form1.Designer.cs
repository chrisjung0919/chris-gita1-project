namespace animation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblspaceship = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.bullet = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // picHappy
            // 
            this.picHappy.Image = global::animation.Properties.Resources.DeadCharacter;
            this.picHappy.Location = new System.Drawing.Point(80, 73);
            this.picHappy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(125, 152);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHappy.TabIndex = 0;
            this.picHappy.TabStop = false;
            this.picHappy.Click += new System.EventHandler(this.picHappy_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblspaceship
            // 
            this.lblspaceship.BackColor = System.Drawing.Color.Black;
            this.lblspaceship.Location = new System.Drawing.Point(55, 595);
            this.lblspaceship.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblspaceship.Name = "lblspaceship";
            this.lblspaceship.Size = new System.Drawing.Size(239, 33);
            this.lblspaceship.TabIndex = 1;
            this.lblspaceship.Text = "label1";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbloutput.Location = new System.Drawing.Point(620, 53);
            this.lbloutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(167, 62);
            this.lbloutput.TabIndex = 2;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Red;
            this.bullet.Location = new System.Drawing.Point(149, 523);
            this.bullet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(13, 17);
            this.bullet.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(620, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 62);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblspaceship);
            this.Controls.Add(this.picHappy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblspaceship;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label bullet;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}

