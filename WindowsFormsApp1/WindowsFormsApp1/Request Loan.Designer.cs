namespace WindowsFormsApp1
{
    partial class Request_Loan
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_LoanType = new System.Windows.Forms.TextBox();
            this.text_Interestrate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_LoanAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_OriginationDate = new System.Windows.Forms.TextBox();
            this.btn_Request = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Loan Type :\t\t\t\tInterestrate:",
            "Mortgage Loans\t\t\t\t14.4%",
            "Auto Loans\t\t\t\t17.3%",
            "Home Equity Loan\t\t\t\t14.2%",
            "Personal Loans\t\t\t\t23.6%"});
            this.listBox1.Location = new System.Drawing.Point(25, 71);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 64);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Loans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interestrate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan Type :";
            // 
            // text_LoanType
            // 
            this.text_LoanType.Location = new System.Drawing.Point(484, 80);
            this.text_LoanType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_LoanType.Name = "text_LoanType";
            this.text_LoanType.Size = new System.Drawing.Size(145, 20);
            this.text_LoanType.TabIndex = 4;
            this.text_LoanType.TextChanged += new System.EventHandler(this.text_LoanType_TextChanged);
            // 
            // text_Interestrate
            // 
            this.text_Interestrate.Location = new System.Drawing.Point(484, 119);
            this.text_Interestrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Interestrate.Name = "text_Interestrate";
            this.text_Interestrate.Size = new System.Drawing.Size(145, 20);
            this.text_Interestrate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loan Amount :";
            // 
            // text_LoanAmount
            // 
            this.text_LoanAmount.Location = new System.Drawing.Point(137, 182);
            this.text_LoanAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_LoanAmount.Name = "text_LoanAmount";
            this.text_LoanAmount.Size = new System.Drawing.Size(190, 20);
            this.text_LoanAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Origination Date :";
            // 
            // text_OriginationDate
            // 
            this.text_OriginationDate.Location = new System.Drawing.Point(484, 183);
            this.text_OriginationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_OriginationDate.Name = "text_OriginationDate";
            this.text_OriginationDate.Size = new System.Drawing.Size(145, 20);
            this.text_OriginationDate.TabIndex = 9;
            // 
            // btn_Request
            // 
            this.btn_Request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Request.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Request.Location = new System.Drawing.Point(218, 236);
            this.btn_Request.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(189, 49);
            this.btn_Request.TabIndex = 11;
            this.btn_Request.Text = "Request Loan";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3am bavly",
            "7oda el makhsy",
            "mestive el 3antel"});
            this.comboBox1.Location = new System.Drawing.Point(484, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Request_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 321);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Request);
            this.Controls.Add(this.text_OriginationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_LoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Interestrate);
            this.Controls.Add(this.text_LoanType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Request_Loan";
            this.Text = "Request_Loan";
            this.Load += new System.EventHandler(this.Request_Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_LoanType;
        private System.Windows.Forms.TextBox text_Interestrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_LoanAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_OriginationDate;
        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}