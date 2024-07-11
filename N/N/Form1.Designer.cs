namespace N
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.txtEven = new System.Windows.Forms.TextBox();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.txtOdd = new System.Windows.Forms.TextBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.btnSequence = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.lblSequence = new System.Windows.Forms.Label();
            this.lblEven = new System.Windows.Forms.Label();
            this.lblOdd = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.resultSequence = new System.Windows.Forms.Label();
            this.resultEven = new System.Windows.Forms.Label();
            this.resultFactorial = new System.Windows.Forms.Label();
            this.resultOdd = new System.Windows.Forms.Label();
            this.resultFibonacci = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "N!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sequence";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(172, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Even";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(331, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odd";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(488, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Factorial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(646, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fibonacci";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSequence
            // 
            this.txtSequence.BackColor = System.Drawing.Color.White;
            this.txtSequence.Location = new System.Drawing.Point(12, 121);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(128, 21);
            this.txtSequence.TabIndex = 6;
            this.txtSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEven
            // 
            this.txtEven.BackColor = System.Drawing.Color.White;
            this.txtEven.Location = new System.Drawing.Point(172, 121);
            this.txtEven.Name = "txtEven";
            this.txtEven.Size = new System.Drawing.Size(128, 21);
            this.txtEven.TabIndex = 7;
            this.txtEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFactorial
            // 
            this.txtFactorial.BackColor = System.Drawing.Color.White;
            this.txtFactorial.Location = new System.Drawing.Point(488, 121);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(128, 21);
            this.txtFactorial.TabIndex = 8;
            this.txtFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFactorial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOdd
            // 
            this.txtOdd.BackColor = System.Drawing.Color.White;
            this.txtOdd.Location = new System.Drawing.Point(331, 121);
            this.txtOdd.Name = "txtOdd";
            this.txtOdd.Size = new System.Drawing.Size(128, 21);
            this.txtOdd.TabIndex = 9;
            this.txtOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.BackColor = System.Drawing.Color.White;
            this.txtFibonacci.Location = new System.Drawing.Point(646, 121);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(128, 21);
            this.txtFibonacci.TabIndex = 10;
            this.txtFibonacci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSequence
            // 
            this.btnSequence.BackColor = System.Drawing.Color.White;
            this.btnSequence.Location = new System.Drawing.Point(12, 159);
            this.btnSequence.Name = "btnSequence";
            this.btnSequence.Size = new System.Drawing.Size(128, 27);
            this.btnSequence.TabIndex = 11;
            this.btnSequence.Text = "Enter";
            this.btnSequence.UseVisualStyleBackColor = false;
            this.btnSequence.Click += new System.EventHandler(this.btnSequence_Click);
            // 
            // btnEven
            // 
            this.btnEven.BackColor = System.Drawing.Color.White;
            this.btnEven.Location = new System.Drawing.Point(172, 159);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(128, 27);
            this.btnEven.TabIndex = 12;
            this.btnEven.Text = "Enter";
            this.btnEven.UseVisualStyleBackColor = false;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.BackColor = System.Drawing.Color.White;
            this.btnOdd.Location = new System.Drawing.Point(331, 159);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(128, 27);
            this.btnOdd.TabIndex = 13;
            this.btnOdd.Text = "Enter";
            this.btnOdd.UseVisualStyleBackColor = false;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.White;
            this.btnFactorial.Location = new System.Drawing.Point(488, 159);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(128, 27);
            this.btnFactorial.TabIndex = 14;
            this.btnFactorial.Text = "Enter";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.BackColor = System.Drawing.Color.White;
            this.btnFibonacci.Location = new System.Drawing.Point(646, 159);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(128, 27);
            this.btnFibonacci.TabIndex = 15;
            this.btnFibonacci.Text = "Enter";
            this.btnFibonacci.UseVisualStyleBackColor = false;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // lblSequence
            // 
            this.lblSequence.BackColor = System.Drawing.Color.White;
            this.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSequence.Location = new System.Drawing.Point(12, 199);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(128, 305);
            this.lblSequence.TabIndex = 16;
            // 
            // lblEven
            // 
            this.lblEven.BackColor = System.Drawing.Color.White;
            this.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEven.Location = new System.Drawing.Point(172, 199);
            this.lblEven.Name = "lblEven";
            this.lblEven.Size = new System.Drawing.Size(128, 305);
            this.lblEven.TabIndex = 17;
            // 
            // lblOdd
            // 
            this.lblOdd.BackColor = System.Drawing.Color.White;
            this.lblOdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOdd.Location = new System.Drawing.Point(331, 199);
            this.lblOdd.Name = "lblOdd";
            this.lblOdd.Size = new System.Drawing.Size(128, 305);
            this.lblOdd.TabIndex = 18;
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.BackColor = System.Drawing.Color.White;
            this.lblFibonacci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFibonacci.Location = new System.Drawing.Point(646, 199);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(128, 305);
            this.lblFibonacci.TabIndex = 19;
            // 
            // lblFactorial
            // 
            this.lblFactorial.BackColor = System.Drawing.Color.White;
            this.lblFactorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFactorial.Location = new System.Drawing.Point(488, 199);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(128, 305);
            this.lblFactorial.TabIndex = 20;
            // 
            // resultSequence
            // 
            this.resultSequence.BackColor = System.Drawing.Color.White;
            this.resultSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultSequence.Location = new System.Drawing.Point(12, 521);
            this.resultSequence.Name = "resultSequence";
            this.resultSequence.Size = new System.Drawing.Size(128, 36);
            this.resultSequence.TabIndex = 21;
            this.resultSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultEven
            // 
            this.resultEven.BackColor = System.Drawing.Color.White;
            this.resultEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultEven.Location = new System.Drawing.Point(172, 521);
            this.resultEven.Name = "resultEven";
            this.resultEven.Size = new System.Drawing.Size(128, 36);
            this.resultEven.TabIndex = 22;
            this.resultEven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultFactorial
            // 
            this.resultFactorial.BackColor = System.Drawing.Color.White;
            this.resultFactorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultFactorial.Location = new System.Drawing.Point(488, 521);
            this.resultFactorial.Name = "resultFactorial";
            this.resultFactorial.Size = new System.Drawing.Size(128, 36);
            this.resultFactorial.TabIndex = 23;
            this.resultFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultOdd
            // 
            this.resultOdd.BackColor = System.Drawing.Color.White;
            this.resultOdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOdd.Location = new System.Drawing.Point(331, 521);
            this.resultOdd.Name = "resultOdd";
            this.resultOdd.Size = new System.Drawing.Size(128, 36);
            this.resultOdd.TabIndex = 24;
            this.resultOdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultFibonacci
            // 
            this.resultFibonacci.BackColor = System.Drawing.Color.White;
            this.resultFibonacci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultFibonacci.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultFibonacci.Location = new System.Drawing.Point(646, 521);
            this.resultFibonacci.Name = "resultFibonacci";
            this.resultFibonacci.Size = new System.Drawing.Size(128, 36);
            this.resultFibonacci.TabIndex = 25;
            this.resultFibonacci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Christopher Jung";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultFibonacci);
            this.Controls.Add(this.resultOdd);
            this.Controls.Add(this.resultFactorial);
            this.Controls.Add(this.resultEven);
            this.Controls.Add(this.resultSequence);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.lblOdd);
            this.Controls.Add(this.lblEven);
            this.Controls.Add(this.lblSequence);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnSequence);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.txtOdd);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.txtEven);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "N";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.TextBox txtEven;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.TextBox txtOdd;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Button btnSequence;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Label lblEven;
        private System.Windows.Forms.Label lblOdd;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Label resultSequence;
        private System.Windows.Forms.Label resultEven;
        private System.Windows.Forms.Label resultFactorial;
        private System.Windows.Forms.Label resultOdd;
        private System.Windows.Forms.Label resultFibonacci;
        private System.Windows.Forms.Label label7;
    }
}

