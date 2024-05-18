namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.CustmID = new System.Windows.Forms.TextBox();
            this.NatID = new System.Windows.Forms.TextBox();
            this.F_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "National ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_btn.Font = new System.Drawing.Font("Neo Tech Alt Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(264, 231);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(123, 43);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustmID
            // 
            this.CustmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustmID.Location = new System.Drawing.Point(322, 74);
            this.CustmID.Name = "CustmID";
            this.CustmID.Size = new System.Drawing.Size(181, 26);
            this.CustmID.TabIndex = 3;
            // 
            // NatID
            // 
            this.NatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NatID.Location = new System.Drawing.Point(322, 121);
            this.NatID.Name = "NatID";
            this.NatID.Size = new System.Drawing.Size(181, 26);
            this.NatID.TabIndex = 4;
            // 
            // F_name
            // 
            this.F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_name.Location = new System.Drawing.Point(322, 171);
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(181, 26);
            this.F_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "First name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_name);
            this.Controls.Add(this.NatID);
            this.Controls.Add(this.CustmID);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox CustmID;
        private System.Windows.Forms.TextBox NatID;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Label label3;
    }
}

