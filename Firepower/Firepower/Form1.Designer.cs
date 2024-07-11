namespace Firepower
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
            this.lblSpaceship = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltarget = new System.Windows.Forms.Label();
            this.lblOpenform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpaceship
            // 
            this.lblSpaceship.BackColor = System.Drawing.Color.Red;
            this.lblSpaceship.Location = new System.Drawing.Point(266, 378);
            this.lblSpaceship.Name = "lblSpaceship";
            this.lblSpaceship.Size = new System.Drawing.Size(262, 24);
            this.lblSpaceship.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltarget
            // 
            this.lbltarget.BackColor = System.Drawing.Color.Lime;
            this.lbltarget.Location = new System.Drawing.Point(266, 173);
            this.lbltarget.Name = "lbltarget";
            this.lbltarget.Size = new System.Drawing.Size(262, 24);
            this.lbltarget.TabIndex = 1;
            // 
            // lblOpenform
            // 
            this.lblOpenform.BackColor = System.Drawing.Color.Lime;
            this.lblOpenform.Location = new System.Drawing.Point(22, 9);
            this.lblOpenform.Name = "lblOpenform";
            this.lblOpenform.Size = new System.Drawing.Size(116, 24);
            this.lblOpenform.TabIndex = 2;
            this.lblOpenform.Text = "Open form";
            this.lblOpenform.Click += new System.EventHandler(this.lblOpenform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpenform);
            this.Controls.Add(this.lbltarget);
            this.Controls.Add(this.lblSpaceship);
            this.Name = "Form1";
            this.Text = "Fire Power";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSpaceship;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltarget;
        private System.Windows.Forms.Label lblOpenform;
    }
}

