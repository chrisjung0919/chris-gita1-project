namespace FinalProject
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.bullet1 = new System.Windows.Forms.Label();
            this.bullet2 = new System.Windows.Forms.Label();
            this.moving = new System.Windows.Forms.Timer(this.components);
            this.Ammo = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.playerR = new System.Windows.Forms.PictureBox();
            this.playerL = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 55;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Red;
            this.bullet1.Location = new System.Drawing.Point(549, 448);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(25, 5);
            this.bullet1.TabIndex = 20;
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Red;
            this.bullet2.Location = new System.Drawing.Point(549, 448);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(25, 5);
            this.bullet2.TabIndex = 21;
            // 
            // moving
            // 
            this.moving.Enabled = true;
            this.moving.Tick += new System.EventHandler(this.moving_Tick);
            // 
            // Ammo
            // 
            this.Ammo.BackColor = System.Drawing.Color.White;
            this.Ammo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ammo.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ammo.Location = new System.Drawing.Point(12, 9);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(82, 34);
            this.Ammo.TabIndex = 27;
            this.Ammo.Text = "0";
            this.Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goal
            // 
            this.goal.BackColor = System.Drawing.Color.SkyBlue;
            this.goal.Location = new System.Drawing.Point(10, 62);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(44, 40);
            this.goal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goal.TabIndex = 30;
            this.goal.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(-5, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(113, 22);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Orange;
            this.enemy3.Location = new System.Drawing.Point(140, 376);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(24, 29);
            this.enemy3.TabIndex = 28;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Orange;
            this.enemy2.Location = new System.Drawing.Point(361, 19);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(24, 29);
            this.enemy2.TabIndex = 26;
            this.enemy2.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Black;
            this.block3.Location = new System.Drawing.Point(230, 48);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(155, 22);
            this.block3.TabIndex = 25;
            this.block3.TabStop = false;
            this.block3.Tag = "platform";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Orange;
            this.enemy1.Location = new System.Drawing.Point(281, 402);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(24, 29);
            this.enemy1.TabIndex = 24;
            this.enemy1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(507, 102);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(330, 22);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Black;
            this.block1.Location = new System.Drawing.Point(249, 136);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(120, 22);
            this.block1.TabIndex = 22;
            this.block1.TabStop = false;
            this.block1.Tag = "platform";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Black;
            this.block2.Location = new System.Drawing.Point(281, 431);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(293, 22);
            this.block2.TabIndex = 13;
            this.block2.TabStop = false;
            this.block2.Tag = "platform";
            // 
            // playerR
            // 
            this.playerR.BackColor = System.Drawing.Color.SkyBlue;
            this.playerR.Location = new System.Drawing.Point(305, 690);
            this.playerR.Name = "playerR";
            this.playerR.Size = new System.Drawing.Size(40, 42);
            this.playerR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerR.TabIndex = 19;
            this.playerR.TabStop = false;
            this.playerR.Visible = false;
            // 
            // playerL
            // 
            this.playerL.BackColor = System.Drawing.Color.SkyBlue;
            this.playerL.Location = new System.Drawing.Point(305, 690);
            this.playerL.Name = "playerL";
            this.playerL.Size = new System.Drawing.Size(40, 42);
            this.playerL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerL.TabIndex = 18;
            this.playerL.TabStop = false;
            this.playerL.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.Location = new System.Drawing.Point(401, 229);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(268, 22);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(249, 283);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(106, 22);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Black;
            this.block4.Location = new System.Drawing.Point(12, 405);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(171, 22);
            this.block4.TabIndex = 14;
            this.block4.TabStop = false;
            this.block4.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(115, 509);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 22);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(198, 567);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 22);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(308, 639);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 22);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(6, 700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 22);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.SkyBlue;
            this.player.Location = new System.Drawing.Point(24, 652);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 42);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 17;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(834, 731);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.Ammo);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.playerR);
            this.Controls.Add(this.playerL);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = ".";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.goal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox playerL;
        private System.Windows.Forms.PictureBox playerR;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.Label bullet1;
        private System.Windows.Forms.Label bullet2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Timer moving;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label Ammo;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox goal;
    }
}

