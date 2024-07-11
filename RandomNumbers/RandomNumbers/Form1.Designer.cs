namespace RandomNumbers
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnforloop = new System.Windows.Forms.Button();
            this.txthowmany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage.Location = new System.Drawing.Point(506, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(247, 407);
            this.lblMessage.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(312, 47);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 64);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnforloop
            // 
            this.btnforloop.Location = new System.Drawing.Point(127, 115);
            this.btnforloop.Name = "btnforloop";
            this.btnforloop.Size = new System.Drawing.Size(130, 51);
            this.btnforloop.TabIndex = 2;
            this.btnforloop.Text = "For loop";
            this.btnforloop.UseVisualStyleBackColor = true;
            this.btnforloop.Click += new System.EventHandler(this.btnforloop_Click);
            // 
            // txthowmany
            // 
            this.txthowmany.Location = new System.Drawing.Point(312, 128);
            this.txthowmany.Name = "txthowmany";
            this.txthowmany.Size = new System.Drawing.Size(129, 21);
            this.txthowmany.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 537);
            this.Controls.Add(this.txthowmany);
            this.Controls.Add(this.btnforloop);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnforloop;
        private System.Windows.Forms.TextBox txthowmany;
    }
}

