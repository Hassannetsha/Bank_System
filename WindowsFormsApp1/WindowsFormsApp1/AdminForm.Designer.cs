namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.btnBank = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // btnBank
            // 
            this.btnBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Location = new System.Drawing.Point(180, 109);
            this.btnBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(153, 52);
            this.btnBank.TabIndex = 1;
            this.btnBank.Text = "Bank";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranch.Location = new System.Drawing.Point(180, 214);
            this.btnBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(153, 48);
            this.btnBranch.TabIndex = 2;
            this.btnBranch.Text = "Branch";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.Location = new System.Drawing.Point(180, 316);
            this.btnManageEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(153, 54);
            this.btnManageEmployees.TabIndex = 3;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 446);
            this.Controls.Add(this.btnManageEmployees);
            this.Controls.Add(this.btnBranch);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnManageEmployees;
    }
}