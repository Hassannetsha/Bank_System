namespace WindowsFormsApp1
{
    partial class Account_Info
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
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTTableAdapter = new WindowsFormsApp1.BankSystemDataSetTableAdapters.ACCOUNTTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCCOUNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERESTRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.bankSystemDataSet;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCOUNTIDDataGridViewTextBoxColumn,
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn,
            this.iNTERESTRATEDataGridViewTextBoxColumn,
            this.oPENDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCCOUNTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aCCOUNTBindingSource1
            // 
            this.aCCOUNTBindingSource1.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource1.DataSource = this.bankSystemDataSet;
            // 
            // aCCOUNTIDDataGridViewTextBoxColumn
            // 
            this.aCCOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.HeaderText = "ACCOUNTID";
            this.aCCOUNTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTIDDataGridViewTextBoxColumn.Name = "aCCOUNTIDDataGridViewTextBoxColumn";
            this.aCCOUNTIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            this.bALANCEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            this.tYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNTERESTRATEDataGridViewTextBoxColumn
            // 
            this.iNTERESTRATEDataGridViewTextBoxColumn.DataPropertyName = "INTERESTRATE";
            this.iNTERESTRATEDataGridViewTextBoxColumn.HeaderText = "INTERESTRATE";
            this.iNTERESTRATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNTERESTRATEDataGridViewTextBoxColumn.Name = "iNTERESTRATEDataGridViewTextBoxColumn";
            this.iNTERESTRATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // oPENDATEDataGridViewTextBoxColumn
            // 
            this.oPENDATEDataGridViewTextBoxColumn.DataPropertyName = "OPENDATE";
            this.oPENDATEDataGridViewTextBoxColumn.HeaderText = "OPENDATE";
            this.oPENDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oPENDATEDataGridViewTextBoxColumn.Name = "oPENDATEDataGridViewTextBoxColumn";
            this.oPENDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // Account_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 414);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Account_Info";
            this.Text = "Account_Info";
            this.Load += new System.EventHandler(this.Account_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private BankSystemDataSetTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERESTRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPENDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource1;
    }
}