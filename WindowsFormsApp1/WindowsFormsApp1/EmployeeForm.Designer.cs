namespace WindowsFormsApp1
{
    partial class EmployeeForm
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
            this.btn_manageCust = new System.Windows.Forms.Button();
            this.btn_manageLoans = new System.Windows.Forms.Button();
            this.bankSystemDataSet1 = new WindowsFormsApp1.BankSystemDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(179, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! Choose what you want to do";
            // 
            // btn_manageCust
            // 
            this.btn_manageCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_manageCust.Location = new System.Drawing.Point(270, 126);
            this.btn_manageCust.Name = "btn_manageCust";
            this.btn_manageCust.Size = new System.Drawing.Size(251, 85);
            this.btn_manageCust.TabIndex = 1;
            this.btn_manageCust.Text = "Manage Customers";
            this.btn_manageCust.UseVisualStyleBackColor = true;
            this.btn_manageCust.Click += new System.EventHandler(this.btn_manageCust_Click);
            // 
            // btn_manageLoans
            // 
            this.btn_manageLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_manageLoans.Location = new System.Drawing.Point(270, 266);
            this.btn_manageLoans.Name = "btn_manageLoans";
            this.btn_manageLoans.Size = new System.Drawing.Size(251, 85);
            this.btn_manageLoans.TabIndex = 2;
            this.btn_manageLoans.Text = "Manage Loans";
            this.btn_manageLoans.UseVisualStyleBackColor = true;
            this.btn_manageLoans.Click += new System.EventHandler(this.btn_manageLoans_Click);
            // 
            // bankSystemDataSet1
            // 
            this.bankSystemDataSet1.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_manageLoans);
            this.Controls.Add(this.btn_manageCust);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_manageCust;
        private System.Windows.Forms.Button btn_manageLoans;
        private BankSystemDataSet bankSystemDataSet1;
    }
}