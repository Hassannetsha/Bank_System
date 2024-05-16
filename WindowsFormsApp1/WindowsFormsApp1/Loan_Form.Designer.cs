namespace WindowsFormsApp1
{
    partial class Loan_Form
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
        string Loan_Amount, AccoutId;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Reject = new System.Windows.Forms.Button();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet1 = new WindowsFormsApp1.BankSystemDataSet1();
            this.projectDataSet = new WindowsFormsApp1.ProjectDataSet();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new WindowsFormsApp1.ProjectDataSetTableAdapters.empTableAdapter();
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.bankSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANTableAdapter = new WindowsFormsApp1.BankSystemDataSet1TableAdapters.LOANTableAdapter();
            this.txt_loan_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bankSystemDataSet2 = new WindowsFormsApp1.BankSystemDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOANNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERESTRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRIGINATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_accept_payloan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(779, 341);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(173, 40);
            this.btn_Reject.TabIndex = 11;
            this.btn_Reject.Text = "Reject";
            this.btn_Reject.UseVisualStyleBackColor = true;
            this.btn_Reject.Click += new System.EventHandler(this.button4_Click);
            // 
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.bankSystemDataSet1;
            // 
            // bankSystemDataSet1
            // 
            this.bankSystemDataSet1.DataSetName = "BankSystemDataSet1";
            this.bankSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.projectDataSet;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSystemDataSetBindingSource
            // 
            this.bankSystemDataSetBindingSource.DataSource = this.bankSystemDataSet;
            this.bankSystemDataSetBindingSource.Position = 0;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // txt_loan_num
            // 
            this.txt_loan_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loan_num.Location = new System.Drawing.Point(190, 89);
            this.txt_loan_num.Name = "txt_loan_num";
            this.txt_loan_num.Size = new System.Drawing.Size(117, 38);
            this.txt_loan_num.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loan_number:";
            // 
            // bankSystemDataSet2
            // 
            this.bankSystemDataSet2.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOANNUMBERDataGridViewTextBoxColumn,
            this.eMPSSNDataGridViewTextBoxColumn,
            this.aCCOUNTIDDataGridViewTextBoxColumn,
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.lOANTYPEDataGridViewTextBoxColumn,
            this.lOANAMOUNTDataGridViewTextBoxColumn,
            this.iNTERESTRATEDataGridViewTextBoxColumn,
            this.oRIGINATIONDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(337, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lOANNUMBERDataGridViewTextBoxColumn
            // 
            this.lOANNUMBERDataGridViewTextBoxColumn.DataPropertyName = "LOAN_NUMBER";
            this.lOANNUMBERDataGridViewTextBoxColumn.HeaderText = "LOAN_NUMBER";
            this.lOANNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANNUMBERDataGridViewTextBoxColumn.Name = "lOANNUMBERDataGridViewTextBoxColumn";
            this.lOANNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPSSNDataGridViewTextBoxColumn
            // 
            this.eMPSSNDataGridViewTextBoxColumn.DataPropertyName = "EMP_SSN";
            this.eMPSSNDataGridViewTextBoxColumn.HeaderText = "EMP_SSN";
            this.eMPSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPSSNDataGridViewTextBoxColumn.Name = "eMPSSNDataGridViewTextBoxColumn";
            this.eMPSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCOUNTIDDataGridViewTextBoxColumn
            // 
            this.aCCOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTIDDataGridViewTextBoxColumn.Name = "aCCOUNTIDDataGridViewTextBoxColumn";
            this.aCCOUNTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMERID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Name = "cUSTOMERIDDataGridViewTextBoxColumn";
            this.cUSTOMERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANTYPEDataGridViewTextBoxColumn
            // 
            this.lOANTYPEDataGridViewTextBoxColumn.DataPropertyName = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.HeaderText = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANTYPEDataGridViewTextBoxColumn.Name = "lOANTYPEDataGridViewTextBoxColumn";
            this.lOANTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANAMOUNTDataGridViewTextBoxColumn
            // 
            this.lOANAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "LOAN_AMOUNT";
            this.lOANAMOUNTDataGridViewTextBoxColumn.HeaderText = "LOAN_AMOUNT";
            this.lOANAMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANAMOUNTDataGridViewTextBoxColumn.Name = "lOANAMOUNTDataGridViewTextBoxColumn";
            this.lOANAMOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNTERESTRATEDataGridViewTextBoxColumn
            // 
            this.iNTERESTRATEDataGridViewTextBoxColumn.DataPropertyName = "INTERESTRATE";
            this.iNTERESTRATEDataGridViewTextBoxColumn.HeaderText = "INTERESTRATE";
            this.iNTERESTRATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNTERESTRATEDataGridViewTextBoxColumn.Name = "iNTERESTRATEDataGridViewTextBoxColumn";
            this.iNTERESTRATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // oRIGINATIONDATEDataGridViewTextBoxColumn
            // 
            this.oRIGINATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "ORIGINATIONDATE";
            this.oRIGINATIONDATEDataGridViewTextBoxColumn.HeaderText = "ORIGINATIONDATE";
            this.oRIGINATIONDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRIGINATIONDATEDataGridViewTextBoxColumn.Name = "oRIGINATIONDATEDataGridViewTextBoxColumn";
            this.oRIGINATIONDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // btn_accept_payloan
            // 
            this.btn_accept_payloan.Location = new System.Drawing.Point(312, 341);
            this.btn_accept_payloan.Name = "btn_accept_payloan";
            this.btn_accept_payloan.Size = new System.Drawing.Size(173, 40);
            this.btn_accept_payloan.TabIndex = 17;
            this.btn_accept_payloan.Text = "Accept and Payloan";
            this.btn_accept_payloan.UseVisualStyleBackColor = true;
            this.btn_accept_payloan.Click += new System.EventHandler(this.btn_accept_payloan_Click);
            // 
            // Loan_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 595);
            this.Controls.Add(this.btn_accept_payloan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loan_num);
            this.Controls.Add(this.btn_Reject);
            this.Name = "Loan_Form";
            this.Text = "Loan_Form";
            this.Load += new System.EventHandler(this.Loan_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Reject;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource empBindingSource;
        private ProjectDataSetTableAdapters.empTableAdapter empTableAdapter;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private BankSystemDataSet bankSystemDataSet;
        private BankSystemDataSet1 bankSystemDataSet1;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private BankSystemDataSet1TableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.TextBox txt_loan_num;
        private System.Windows.Forms.Label label1;
        private BankSystemDataSet bankSystemDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERESTRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRIGINATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_accept_payloan;
    }
}