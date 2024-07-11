namespace ProjectT_shirt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textOrder = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddtoCurrent = new System.Windows.Forms.Button();
            this.btnCleartheCurrent = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBPocket = new System.Windows.Forms.CheckBox();
            this.CBMonogram = new System.Windows.Forms.CheckBox();
            this.RBXXL = new System.Windows.Forms.RadioButton();
            this.RBXL = new System.Windows.Forms.RadioButton();
            this.RBL = new System.Windows.Forms.RadioButton();
            this.RBM = new System.Windows.Forms.RadioButton();
            this.RBS = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.textQuantity);
            this.groupBox1.Controls.Add(this.textOrder);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textQuantity
            // 
            resources.ApplyResources(this.textQuantity, "textQuantity");
            this.textQuantity.Name = "textQuantity";
            // 
            // textOrder
            // 
            resources.ApplyResources(this.textOrder, "textOrder");
            this.textOrder.Name = "textOrder";
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnAddtoCurrent
            // 
            this.btnAddtoCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddtoCurrent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnAddtoCurrent, "btnAddtoCurrent");
            this.btnAddtoCurrent.Name = "btnAddtoCurrent";
            this.toolTip1.SetToolTip(this.btnAddtoCurrent, resources.GetString("btnAddtoCurrent.ToolTip"));
            this.btnAddtoCurrent.UseVisualStyleBackColor = false;
            this.btnAddtoCurrent.Click += new System.EventHandler(this.btnAddtoCurrent_Click);
            // 
            // btnCleartheCurrent
            // 
            this.btnCleartheCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCleartheCurrent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCleartheCurrent, "btnCleartheCurrent");
            this.btnCleartheCurrent.Name = "btnCleartheCurrent";
            this.toolTip1.SetToolTip(this.btnCleartheCurrent, resources.GetString("btnCleartheCurrent.ToolTip"));
            this.btnCleartheCurrent.UseVisualStyleBackColor = false;
            this.btnCleartheCurrent.Click += new System.EventHandler(this.btnCleartheCurrent_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComplete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnComplete, "btnComplete");
            this.btnComplete.Name = "btnComplete";
            this.toolTip1.SetToolTip(this.btnComplete, resources.GetString("btnComplete.ToolTip"));
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CBPocket);
            this.groupBox2.Controls.Add(this.CBMonogram);
            this.groupBox2.Controls.Add(this.RBXXL);
            this.groupBox2.Controls.Add(this.RBXL);
            this.groupBox2.Controls.Add(this.RBL);
            this.groupBox2.Controls.Add(this.RBM);
            this.groupBox2.Controls.Add(this.RBS);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // CBPocket
            // 
            resources.ApplyResources(this.CBPocket, "CBPocket");
            this.CBPocket.Name = "CBPocket";
            this.CBPocket.UseVisualStyleBackColor = true;
            // 
            // CBMonogram
            // 
            resources.ApplyResources(this.CBMonogram, "CBMonogram");
            this.CBMonogram.Name = "CBMonogram";
            this.CBMonogram.UseVisualStyleBackColor = true;
            // 
            // RBXXL
            // 
            resources.ApplyResources(this.RBXXL, "RBXXL");
            this.RBXXL.Name = "RBXXL";
            this.RBXXL.TabStop = true;
            this.RBXXL.UseVisualStyleBackColor = true;
            // 
            // RBXL
            // 
            resources.ApplyResources(this.RBXL, "RBXL");
            this.RBXL.Name = "RBXL";
            this.RBXL.TabStop = true;
            this.RBXL.UseVisualStyleBackColor = true;
            // 
            // RBL
            // 
            resources.ApplyResources(this.RBL, "RBL");
            this.RBL.Name = "RBL";
            this.RBL.TabStop = true;
            this.RBL.UseVisualStyleBackColor = true;
            // 
            // RBM
            // 
            resources.ApplyResources(this.RBM, "RBM");
            this.RBM.Name = "RBM";
            this.RBM.TabStop = true;
            this.RBM.UseVisualStyleBackColor = true;
            // 
            // RBS
            // 
            resources.ApplyResources(this.RBS, "RBS");
            this.RBS.Checked = true;
            this.RBS.Name = "RBS";
            this.RBS.TabStop = true;
            this.RBS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblSubtotal, "lblSubtotal");
            this.lblSubtotal.Name = "lblSubtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Lime;
            this.btnSummary.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnSummary, "btnSummary");
            this.btnSummary.Name = "btnSummary";
            this.toolTip1.SetToolTip(this.btnSummary, resources.GetString("btnSummary.ToolTip"));
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.White;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblTax, "lblTax");
            this.lblTax.Name = "lblTax";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddtoCurrent;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCleartheCurrent);
            this.Controls.Add(this.btnAddtoCurrent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textOrder;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddtoCurrent;
        private System.Windows.Forms.Button btnCleartheCurrent;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CBMonogram;
        private System.Windows.Forms.RadioButton RBXXL;
        private System.Windows.Forms.RadioButton RBXL;
        private System.Windows.Forms.RadioButton RBL;
        private System.Windows.Forms.RadioButton RBM;
        private System.Windows.Forms.RadioButton RBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.CheckBox CBPocket;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

