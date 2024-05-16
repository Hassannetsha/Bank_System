namespace WindowsFormsApp1
{
    partial class Customer
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
            this.btn_Request = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Request
            // 
            this.btn_Request.Location = new System.Drawing.Point(189, 45);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(435, 139);
            this.btn_Request.TabIndex = 0;
            this.btn_Request.Text = "Request Loan";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(189, 242);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(435, 160);
            this.btn_Account.TabIndex = 1;
            this.btn_Account.Text = "Account Info";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_Request);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.Button btn_Account;
    }
}

