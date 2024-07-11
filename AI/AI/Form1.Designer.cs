namespace AI
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPDown = new System.Windows.Forms.PictureBox();
            this.picPUp = new System.Windows.Forms.PictureBox();
            this.picPRight = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPLeft = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblhealth = new System.Windows.Forms.Label();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picPDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPDown
            // 
            this.picPDown.Image = global::AI.Properties.Resources.ppp;
            this.picPDown.Location = new System.Drawing.Point(810, 427);
            this.picPDown.Name = "picPDown";
            this.picPDown.Size = new System.Drawing.Size(113, 103);
            this.picPDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPDown.TabIndex = 5;
            this.picPDown.TabStop = false;
            this.picPDown.Visible = false;
            // 
            // picPUp
            // 
            this.picPUp.Image = global::AI.Properties.Resources.pp;
            this.picPUp.Location = new System.Drawing.Point(810, 427);
            this.picPUp.Name = "picPUp";
            this.picPUp.Size = new System.Drawing.Size(113, 103);
            this.picPUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPUp.TabIndex = 4;
            this.picPUp.TabStop = false;
            this.picPUp.Visible = false;
            // 
            // picPRight
            // 
            this.picPRight.Image = global::AI.Properties.Resources.p;
            this.picPRight.Location = new System.Drawing.Point(810, 427);
            this.picPRight.Name = "picPRight";
            this.picPRight.Size = new System.Drawing.Size(113, 103);
            this.picPRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPRight.TabIndex = 3;
            this.picPRight.TabStop = false;
            this.picPRight.Visible = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::AI.Properties.Resources.unnamed;
            this.picPlayer.Location = new System.Drawing.Point(74, 359);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(113, 103);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // picEnemy
            // 
            this.picEnemy.Image = global::AI.Properties.Resources._90d2e3ff2856032d36fcc7dc49334191;
            this.picEnemy.Location = new System.Drawing.Point(423, 194);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(113, 103);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemy.TabIndex = 0;
            this.picEnemy.TabStop = false;
            // 
            // picPLeft
            // 
            this.picPLeft.Image = global::AI.Properties.Resources.unnamed;
            this.picPLeft.Location = new System.Drawing.Point(810, 427);
            this.picPLeft.Name = "picPLeft";
            this.picPLeft.Size = new System.Drawing.Size(113, 103);
            this.picPLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPLeft.TabIndex = 6;
            this.picPLeft.TabStop = false;
            this.picPLeft.Visible = false;
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Black;
            this.bullet1.Location = new System.Drawing.Point(-3, 81);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(51, 7);
            this.bullet1.TabIndex = 7;
            this.bullet1.TabStop = false;
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Black;
            this.bullet2.Location = new System.Drawing.Point(10, 81);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(51, 7);
            this.bullet2.TabIndex = 8;
            this.bullet2.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.BackColor = System.Drawing.Color.Black;
            this.bullet3.Location = new System.Drawing.Point(21, 57);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(7, 51);
            this.bullet3.TabIndex = 9;
            this.bullet3.TabStop = false;
            // 
            // bullet4
            // 
            this.bullet4.BackColor = System.Drawing.Color.Black;
            this.bullet4.Location = new System.Drawing.Point(-3, 57);
            this.bullet4.Name = "bullet4";
            this.bullet4.Size = new System.Drawing.Size(7, 51);
            this.bullet4.TabIndex = 10;
            this.bullet4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 61);
            this.label1.TabIndex = 11;
            // 
            // lblPoint
            // 
            this.lblPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoint.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPoint.Location = new System.Drawing.Point(779, 9);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(144, 25);
            this.lblPoint.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(684, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(618, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Playerhealth:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.newGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblhealth
            // 
            this.lblhealth.BackColor = System.Drawing.Color.Lime;
            this.lblhealth.Location = new System.Drawing.Point(779, 46);
            this.lblhealth.Name = "lblhealth";
            this.lblhealth.Size = new System.Drawing.Size(100, 23);
            this.lblhealth.TabIndex = 19;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.lblhealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bullet4);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.picPLeft);
            this.Controls.Add(this.picPDown);
            this.Controls.Add(this.picPUp);
            this.Controls.Add(this.picPRight);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPRight;
        private System.Windows.Forms.PictureBox picPUp;
        private System.Windows.Forms.PictureBox picPDown;
        private System.Windows.Forms.PictureBox picPLeft;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox bullet4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblhealth;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

