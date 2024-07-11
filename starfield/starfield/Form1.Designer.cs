namespace starfield
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
            this.lblStar0 = new System.Windows.Forms.Label();
            this.lblStar1 = new System.Windows.Forms.Label();
            this.lblStar2 = new System.Windows.Forms.Label();
            this.lblStar3 = new System.Windows.Forms.Label();
            this.lblStar4 = new System.Windows.Forms.Label();
            this.lblStar5 = new System.Windows.Forms.Label();
            this.lblStar6 = new System.Windows.Forms.Label();
            this.lblStar7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStar0
            // 
            this.lblStar0.BackColor = System.Drawing.Color.Yellow;
            this.lblStar0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar0.Location = new System.Drawing.Point(39, 30);
            this.lblStar0.Name = "lblStar0";
            this.lblStar0.Size = new System.Drawing.Size(52, 46);
            this.lblStar0.TabIndex = 0;
            // 
            // lblStar1
            // 
            this.lblStar1.BackColor = System.Drawing.Color.Yellow;
            this.lblStar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar1.Location = new System.Drawing.Point(117, 30);
            this.lblStar1.Name = "lblStar1";
            this.lblStar1.Size = new System.Drawing.Size(52, 46);
            this.lblStar1.TabIndex = 1;
            // 
            // lblStar2
            // 
            this.lblStar2.BackColor = System.Drawing.Color.Yellow;
            this.lblStar2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar2.Location = new System.Drawing.Point(192, 30);
            this.lblStar2.Name = "lblStar2";
            this.lblStar2.Size = new System.Drawing.Size(52, 46);
            this.lblStar2.TabIndex = 2;
            // 
            // lblStar3
            // 
            this.lblStar3.BackColor = System.Drawing.Color.Yellow;
            this.lblStar3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar3.Location = new System.Drawing.Point(269, 30);
            this.lblStar3.Name = "lblStar3";
            this.lblStar3.Size = new System.Drawing.Size(52, 46);
            this.lblStar3.TabIndex = 3;
            // 
            // lblStar4
            // 
            this.lblStar4.BackColor = System.Drawing.Color.Yellow;
            this.lblStar4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar4.Location = new System.Drawing.Point(337, 30);
            this.lblStar4.Name = "lblStar4";
            this.lblStar4.Size = new System.Drawing.Size(52, 46);
            this.lblStar4.TabIndex = 4;
            // 
            // lblStar5
            // 
            this.lblStar5.BackColor = System.Drawing.Color.Yellow;
            this.lblStar5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar5.Location = new System.Drawing.Point(421, 30);
            this.lblStar5.Name = "lblStar5";
            this.lblStar5.Size = new System.Drawing.Size(52, 46);
            this.lblStar5.TabIndex = 5;
            // 
            // lblStar6
            // 
            this.lblStar6.BackColor = System.Drawing.Color.Yellow;
            this.lblStar6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar6.Location = new System.Drawing.Point(495, 30);
            this.lblStar6.Name = "lblStar6";
            this.lblStar6.Size = new System.Drawing.Size(52, 46);
            this.lblStar6.TabIndex = 6;
            // 
            // lblStar7
            // 
            this.lblStar7.BackColor = System.Drawing.Color.Yellow;
            this.lblStar7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStar7.Location = new System.Drawing.Point(572, 30);
            this.lblStar7.Name = "lblStar7";
            this.lblStar7.Size = new System.Drawing.Size(52, 46);
            this.lblStar7.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStar7);
            this.Controls.Add(this.lblStar6);
            this.Controls.Add(this.lblStar5);
            this.Controls.Add(this.lblStar4);
            this.Controls.Add(this.lblStar3);
            this.Controls.Add(this.lblStar2);
            this.Controls.Add(this.lblStar1);
            this.Controls.Add(this.lblStar0);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "How to do arrays of objects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStar0;
        private System.Windows.Forms.Label lblStar1;
        private System.Windows.Forms.Label lblStar2;
        private System.Windows.Forms.Label lblStar3;
        private System.Windows.Forms.Label lblStar4;
        private System.Windows.Forms.Label lblStar5;
        private System.Windows.Forms.Label lblStar6;
        private System.Windows.Forms.Label lblStar7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

