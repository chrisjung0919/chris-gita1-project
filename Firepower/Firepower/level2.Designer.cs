namespace Firepower
{
    partial class level2
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
            this.lblMyhealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMyhealth
            // 
            this.lblMyhealth.BackColor = System.Drawing.Color.Lime;
            this.lblMyhealth.Location = new System.Drawing.Point(269, 213);
            this.lblMyhealth.Name = "lblMyhealth";
            this.lblMyhealth.Size = new System.Drawing.Size(262, 24);
            this.lblMyhealth.TabIndex = 2;
            // 
            // level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMyhealth);
            this.Name = "level2";
            this.Text = "level2";
            this.Load += new System.EventHandler(this.level2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMyhealth;
    }
}