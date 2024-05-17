namespace WindowsFormsApp1
{
    partial class loan_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOANNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERESTRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRIGINATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.lOANTableAdapter = new WindowsFormsApp1.BankSystemDataSetTableAdapters.LOANTableAdapter();
            this.txt_loan_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_accept_payloan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(363, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lOANNUMBERDataGridViewTextBoxColumn
            // 
            this.lOANNUMBERDataGridViewTextBoxColumn.DataPropertyName = "LOAN_NUMBER";
            this.lOANNUMBERDataGridViewTextBoxColumn.HeaderText = "LOAN_NUMBER";
            this.lOANNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANNUMBERDataGridViewTextBoxColumn.Name = "lOANNUMBERDataGridViewTextBoxColumn";
            this.lOANNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.bankSystemDataSetBindingSource;
            // 
            // bankSystemDataSetBindingSource
            // 
            this.bankSystemDataSetBindingSource.DataSource = this.bankSystemDataSet;
            this.bankSystemDataSetBindingSource.Position = 0;
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // txt_loan_num
            // 
            this.txt_loan_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loan_num.ForeColor = System.Drawing.Color.Black;
            this.txt_loan_num.Location = new System.Drawing.Point(212, 59);
            this.txt_loan_num.Name = "txt_loan_num";
            this.txt_loan_num.Size = new System.Drawing.Size(100, 38);
            this.txt_loan_num.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan number:";
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(593, 305);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(146, 55);
            this.btn_reject.TabIndex = 3;
            this.btn_reject.Text = "Reject";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_accept_payloan
            // 
            this.btn_accept_payloan.Location = new System.Drawing.Point(212, 305);
            this.btn_accept_payloan.Name = "btn_accept_payloan";
            this.btn_accept_payloan.Size = new System.Drawing.Size(194, 55);
            this.btn_accept_payloan.TabIndex = 4;
            this.btn_accept_payloan.Text = "Accept and Payloan";
            this.btn_accept_payloan.UseVisualStyleBackColor = true;
            this.btn_accept_payloan.Click += new System.EventHandler(this.button2_Click);
            // 
            // loan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.btn_accept_payloan);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loan_num);
            this.Controls.Add(this.dataGridView1);
            this.Name = "loan_form";
            this.Text = "loan_form";
            this.Load += new System.EventHandler(this.loan_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private BankSystemDataSetTableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERESTRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRIGINATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_loan_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button btn_accept_payloan;
    }
}