namespace Arrays
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
            this.btnMove = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox0 = new System.Windows.Forms.PictureBox();
            this.Fish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMove.Location = new System.Drawing.Point(134, 191);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(112, 51);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAuto.Location = new System.Drawing.Point(372, 191);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(112, 51);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(554, 49);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(114, 104);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 4;
            this.picBox3.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(372, 49);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(114, 104);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 3;
            this.picBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(198, 49);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(114, 104);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // picBox0
            // 
            this.picBox0.Location = new System.Drawing.Point(25, 49);
            this.picBox0.Name = "picBox0";
            this.picBox0.Size = new System.Drawing.Size(114, 104);
            this.picBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox0.TabIndex = 1;
            this.picBox0.TabStop = false;
            // 
            // Fish
            // 
            this.Fish.Image = global::Arrays.Properties.Resources._7b8b9cbc22da0f51cc6710d470a70abd;
            this.Fish.Location = new System.Drawing.Point(13, 342);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(110, 95);
            this.Fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish.TabIndex = 0;
            this.Fish.TabStop = false;
            this.Fish.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox0);
            this.Controls.Add(this.Fish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Fish;
        private System.Windows.Forms.PictureBox picBox0;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Timer timer1;
    }
}

