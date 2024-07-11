namespace Firepower
{
    partial class level3
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
            this.lblspaceship = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblspaceship
            // 
            this.lblspaceship.BackColor = System.Drawing.Color.Aqua;
            this.lblspaceship.Location = new System.Drawing.Point(418, 238);
            this.lblspaceship.Name = "lblspaceship";
            this.lblspaceship.Size = new System.Drawing.Size(70, 69);
            this.lblspaceship.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(509, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 69);
            this.label1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblspaceship);
            this.Name = "level3";
            this.Text = "level3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.level3_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblspaceship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}