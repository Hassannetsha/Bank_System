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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Loan Type :\t\t\t\tInterestrate:",
            "Mortgage Loans\t\t\t\t14.4%",
            "Auto Loans\t\t\t\t17.3%",
            "Home Equity Loan\t\t\t\t14.2%",
            "Personal Loans\t\t\t\t23.6%"});
            this.listBox1.Location = new System.Drawing.Point(33, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 94);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Loans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interestrate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan Type :";
            // 
            // text_LoanType
            // 
            this.text_LoanType.Location = new System.Drawing.Point(646, 98);
            this.text_LoanType.Name = "text_LoanType";
            this.text_LoanType.Size = new System.Drawing.Size(192, 22);
            this.text_LoanType.TabIndex = 4;
            // 
            // text_Interestrate
            // 
            this.text_Interestrate.Location = new System.Drawing.Point(646, 147);
            this.text_Interestrate.Name = "text_Interestrate";
            this.text_Interestrate.Size = new System.Drawing.Size(192, 22);
            this.text_Interestrate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loan Amount :";
            // 
            // text_LoanAmount
            // 
            this.text_LoanAmount.Location = new System.Drawing.Point(183, 224);
            this.text_LoanAmount.Name = "text_LoanAmount";
            this.text_LoanAmount.Size = new System.Drawing.Size(252, 22);
            this.text_LoanAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Origination Date :";
            // 
            // text_OriginationDate
            // 
            this.text_OriginationDate.Location = new System.Drawing.Point(646, 225);
            this.text_OriginationDate.Name = "text_OriginationDate";
            this.text_OriginationDate.Size = new System.Drawing.Size(192, 22);
            this.text_OriginationDate.TabIndex = 9;
            // 
            // btn_Request
            // 
            this.btn_Request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Request.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Request.Location = new System.Drawing.Point(291, 290);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(252, 60);
            this.btn_Request.TabIndex = 11;
            this.btn_Request.Text = "Request Loan";
            this.btn_Request.UseVisualStyleBackColor = true;
            // 
            // Request_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 395);
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
    }
}