namespace WindowsFormsApp1
{
    partial class ManageEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Branch_Number = new System.Windows.Forms.TextBox();
            this.txt_EmpFname = new System.Windows.Forms.TextBox();
            this.txt_EmpLname = new System.Windows.Forms.TextBox();
            this.txt_EmpAddress = new System.Windows.Forms.TextBox();
            this.txt_EmpPhoneNum = new System.Windows.Forms.TextBox();
            this.txt_EmpJobTitle = new System.Windows.Forms.TextBox();
            this.txt_EmpEmail = new System.Windows.Forms.TextBox();
            this.btn_insert_employees = new System.Windows.Forms.Button();
            this.btn_Update_employees = new System.Windows.Forms.Button();
            this.btn_Delete_employees = new System.Windows.Forms.Button();
            this.btn_show_employees = new System.Windows.Forms.Button();
            this.EmployeeGridVIew = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARNCHNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.eMPLOYEETableAdapter = new WindowsFormsApp1.BankSystemDataSetTableAdapters.EMPLOYEETableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee\'s First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee\'s Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee\'s Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee\'s Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee\'s Job Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employee\'s Email";
            // 
            // txt_Branch_Number
            // 
            this.txt_Branch_Number.Location = new System.Drawing.Point(186, 10);
            this.txt_Branch_Number.Name = "txt_Branch_Number";
            this.txt_Branch_Number.Size = new System.Drawing.Size(155, 22);
            this.txt_Branch_Number.TabIndex = 7;
            // 
            // txt_EmpFname
            // 
            this.txt_EmpFname.Location = new System.Drawing.Point(186, 53);
            this.txt_EmpFname.Name = "txt_EmpFname";
            this.txt_EmpFname.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpFname.TabIndex = 8;
            // 
            // txt_EmpLname
            // 
            this.txt_EmpLname.Location = new System.Drawing.Point(186, 101);
            this.txt_EmpLname.Name = "txt_EmpLname";
            this.txt_EmpLname.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpLname.TabIndex = 9;
            // 
            // txt_EmpAddress
            // 
            this.txt_EmpAddress.Location = new System.Drawing.Point(186, 149);
            this.txt_EmpAddress.Name = "txt_EmpAddress";
            this.txt_EmpAddress.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpAddress.TabIndex = 10;
            // 
            // txt_EmpPhoneNum
            // 
            this.txt_EmpPhoneNum.Location = new System.Drawing.Point(186, 200);
            this.txt_EmpPhoneNum.Name = "txt_EmpPhoneNum";
            this.txt_EmpPhoneNum.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpPhoneNum.TabIndex = 11;
            // 
            // txt_EmpJobTitle
            // 
            this.txt_EmpJobTitle.Location = new System.Drawing.Point(186, 252);
            this.txt_EmpJobTitle.Name = "txt_EmpJobTitle";
            this.txt_EmpJobTitle.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpJobTitle.TabIndex = 12;
            // 
            // txt_EmpEmail
            // 
            this.txt_EmpEmail.Location = new System.Drawing.Point(186, 300);
            this.txt_EmpEmail.Name = "txt_EmpEmail";
            this.txt_EmpEmail.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpEmail.TabIndex = 13;
            // 
            // btn_insert_employees
            // 
            this.btn_insert_employees.Location = new System.Drawing.Point(8, 356);
            this.btn_insert_employees.Name = "btn_insert_employees";
            this.btn_insert_employees.Size = new System.Drawing.Size(191, 39);
            this.btn_insert_employees.TabIndex = 14;
            this.btn_insert_employees.Text = "Insert New Employee";
            this.btn_insert_employees.UseVisualStyleBackColor = true;
            this.btn_insert_employees.Click += new System.EventHandler(this.btn_insert_employees_Click);
            // 
            // btn_Update_employees
            // 
            this.btn_Update_employees.Location = new System.Drawing.Point(590, 335);
            this.btn_Update_employees.Name = "btn_Update_employees";
            this.btn_Update_employees.Size = new System.Drawing.Size(191, 38);
            this.btn_Update_employees.TabIndex = 15;
            this.btn_Update_employees.Text = "Update Employee Details";
            this.btn_Update_employees.UseVisualStyleBackColor = true;
            this.btn_Update_employees.Click += new System.EventHandler(this.btn_Update_employees_Click);
            // 
            // btn_Delete_employees
            // 
            this.btn_Delete_employees.Location = new System.Drawing.Point(590, 379);
            this.btn_Delete_employees.Name = "btn_Delete_employees";
            this.btn_Delete_employees.Size = new System.Drawing.Size(191, 38);
            this.btn_Delete_employees.TabIndex = 16;
            this.btn_Delete_employees.Text = "Remove Employee";
            this.btn_Delete_employees.UseVisualStyleBackColor = true;
            this.btn_Delete_employees.Click += new System.EventHandler(this.btn_Delete_employees_Click);
            // 
            // btn_show_employees
            // 
            this.btn_show_employees.Location = new System.Drawing.Point(590, 266);
            this.btn_show_employees.Name = "btn_show_employees";
            this.btn_show_employees.Size = new System.Drawing.Size(191, 32);
            this.btn_show_employees.TabIndex = 17;
            this.btn_show_employees.Text = "Show Employees";
            this.btn_show_employees.UseVisualStyleBackColor = true;
            this.btn_show_employees.Click += new System.EventHandler(this.btn_show_employees_Click);
            // 
            // EmployeeGridVIew
            // 
            this.EmployeeGridVIew.AutoGenerateColumns = false;
            this.EmployeeGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridVIew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.bARNCHNUMBERDataGridViewTextBoxColumn,
            this.eMPFNAMEDataGridViewTextBoxColumn,
            this.eMPLNAMEDataGridViewTextBoxColumn,
            this.eMPADDRESSDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.jOBTITLEDataGridViewTextBoxColumn,
            this.eMPEMAILDataGridViewTextBoxColumn});
            this.EmployeeGridVIew.DataSource = this.eMPLOYEEBindingSource;
            this.EmployeeGridVIew.Location = new System.Drawing.Point(367, 10);
            this.EmployeeGridVIew.Name = "EmployeeGridVIew";
            this.EmployeeGridVIew.RowHeadersWidth = 51;
            this.EmployeeGridVIew.RowTemplate.Height = 24;
            this.EmployeeGridVIew.Size = new System.Drawing.Size(414, 246);
            this.EmployeeGridVIew.TabIndex = 18;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEEID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEEID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bARNCHNUMBERDataGridViewTextBoxColumn
            // 
            this.bARNCHNUMBERDataGridViewTextBoxColumn.DataPropertyName = "BARNCH_NUMBER";
            this.bARNCHNUMBERDataGridViewTextBoxColumn.HeaderText = "BARNCH_NUMBER";
            this.bARNCHNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bARNCHNUMBERDataGridViewTextBoxColumn.Name = "bARNCHNUMBERDataGridViewTextBoxColumn";
            this.bARNCHNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPFNAMEDataGridViewTextBoxColumn
            // 
            this.eMPFNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_FNAME";
            this.eMPFNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_FNAME";
            this.eMPFNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPFNAMEDataGridViewTextBoxColumn.Name = "eMPFNAMEDataGridViewTextBoxColumn";
            this.eMPFNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPLNAMEDataGridViewTextBoxColumn
            // 
            this.eMPLNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_LNAME";
            this.eMPLNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_LNAME";
            this.eMPLNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPLNAMEDataGridViewTextBoxColumn.Name = "eMPLNAMEDataGridViewTextBoxColumn";
            this.eMPLNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPADDRESSDataGridViewTextBoxColumn
            // 
            this.eMPADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMP_ADDRESS";
            this.eMPADDRESSDataGridViewTextBoxColumn.HeaderText = "EMP_ADDRESS";
            this.eMPADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPADDRESSDataGridViewTextBoxColumn.Name = "eMPADDRESSDataGridViewTextBoxColumn";
            this.eMPADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONENUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONENUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBTITLEDataGridViewTextBoxColumn
            // 
            this.jOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.HeaderText = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBTITLEDataGridViewTextBoxColumn.Name = "jOBTITLEDataGridViewTextBoxColumn";
            this.jOBTITLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPEMAILDataGridViewTextBoxColumn
            // 
            this.eMPEMAILDataGridViewTextBoxColumn.DataPropertyName = "EMP_EMAIL";
            this.eMPEMAILDataGridViewTextBoxColumn.HeaderText = "EMP_EMAIL";
            this.eMPEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPEMAILDataGridViewTextBoxColumn.Name = "eMPEMAILDataGridViewTextBoxColumn";
            this.eMPEMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.bankSystemDataSet;
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(272, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search for an Employe with his ID to manage it";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(275, 375);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(155, 22);
            this.txt_EmpID.TabIndex = 20;
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmployeeGridVIew);
            this.Controls.Add(this.btn_show_employees);
            this.Controls.Add(this.btn_Delete_employees);
            this.Controls.Add(this.btn_Update_employees);
            this.Controls.Add(this.btn_insert_employees);
            this.Controls.Add(this.txt_EmpEmail);
            this.Controls.Add(this.txt_EmpJobTitle);
            this.Controls.Add(this.txt_EmpPhoneNum);
            this.Controls.Add(this.txt_EmpAddress);
            this.Controls.Add(this.txt_EmpLname);
            this.Controls.Add(this.txt_EmpFname);
            this.Controls.Add(this.txt_Branch_Number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Branch_Number;
        private System.Windows.Forms.TextBox txt_EmpFname;
        private System.Windows.Forms.TextBox txt_EmpLname;
        private System.Windows.Forms.TextBox txt_EmpAddress;
        private System.Windows.Forms.TextBox txt_EmpPhoneNum;
        private System.Windows.Forms.TextBox txt_EmpJobTitle;
        private System.Windows.Forms.TextBox txt_EmpEmail;
        private System.Windows.Forms.Button btn_insert_employees;
        private System.Windows.Forms.Button btn_Update_employees;
        private System.Windows.Forms.Button btn_Delete_employees;
        private System.Windows.Forms.Button btn_show_employees;
        private System.Windows.Forms.DataGridView EmployeeGridVIew;
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private BankSystemDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARNCHNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_EmpID;
    }
}