namespace ProjectBMI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPeopleCalculated = new System.Windows.Forms.Label();
            this.lblAverBMI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textHeight2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight(lbs):";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(103, 139);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(107, 21);
            this.textHeight.TabIndex = 3;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(148, 181);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(236, 21);
            this.textWeight.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(171, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(565, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total BMI:";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBMI.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMI.Location = new System.Drawing.Point(569, 160);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(233, 65);
            this.lblBMI.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPeopleCalculated);
            this.groupBox1.Controls.Add(this.lblAverBMI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(16, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI:";
            // 
            // lblPeopleCalculated
            // 
            this.lblPeopleCalculated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeopleCalculated.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPeopleCalculated.Location = new System.Drawing.Point(258, 73);
            this.lblPeopleCalculated.Name = "lblPeopleCalculated";
            this.lblPeopleCalculated.Size = new System.Drawing.Size(135, 21);
            this.lblPeopleCalculated.TabIndex = 13;
            // 
            // lblAverBMI
            // 
            this.lblAverBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverBMI.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAverBMI.Location = new System.Drawing.Point(258, 28);
            this.lblAverBMI.Name = "lblAverBMI";
            this.lblAverBMI.Size = new System.Drawing.Size(135, 21);
            this.lblAverBMI.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "People Calculated:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Average BMI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(216, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "ft";
            // 
            // textHeight2
            // 
            this.textHeight2.Location = new System.Drawing.Point(246, 139);
            this.textHeight2.Name = "textHeight2";
            this.textHeight2.Size = new System.Drawing.Size(107, 21);
            this.textHeight2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(359, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "in";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Lime;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(635, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Underweight<18.5";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(635, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 48);
            this.label10.TabIndex = 14;
            this.label10.Text = "Normal 18.5 - 24.9";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(635, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 48);
            this.label11.TabIndex = 15;
            this.label11.Text = "Overweight 25 - 29.9";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(635, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Obese>30";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(805, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textHeight2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPeopleCalculated;
        private System.Windows.Forms.Label lblAverBMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHeight2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
    }
}

