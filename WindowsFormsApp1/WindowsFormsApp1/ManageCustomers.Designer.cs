namespace WindowsFormsApp1
{
    partial class ManageCustomers
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
            this.txt_CustFname = new System.Windows.Forms.TextBox();
            this.txt_CustLname = new System.Windows.Forms.TextBox();
            this.txt_CustAddress = new System.Windows.Forms.TextBox();
            this.txt_CustPhoneNo = new System.Windows.Forms.TextBox();
            this.txt_CustEmail = new System.Windows.Forms.TextBox();
            this.txt_CustDateOB = new System.Windows.Forms.TextBox();
            this.txt_CustNationalID = new System.Windows.Forms.TextBox();
            this.btn_InsertCustomer = new System.Windows.Forms.Button();
            this.btn_showCustomers = new System.Windows.Forms.Button();
            this.btn_removeCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATIONALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CustID = new System.Windows.Forms.TextBox();
            this.cUSTOMERTableAdapter = new WindowsFormsApp1.BankSystemDataSetTableAdapters.CUSTOMERTableAdapter();
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer\'s First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer\'s Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer\'s Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer\'s Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer\'s Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer\'s Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer\'s National ID";
            // 
            // txt_CustFname
            // 
            this.txt_CustFname.Location = new System.Drawing.Point(189, 9);
            this.txt_CustFname.Name = "txt_CustFname";
            this.txt_CustFname.Size = new System.Drawing.Size(161, 22);
            this.txt_CustFname.TabIndex = 7;
            // 
            // txt_CustLname
            // 
            this.txt_CustLname.Location = new System.Drawing.Point(189, 57);
            this.txt_CustLname.Name = "txt_CustLname";
            this.txt_CustLname.Size = new System.Drawing.Size(161, 22);
            this.txt_CustLname.TabIndex = 8;
            // 
            // txt_CustAddress
            // 
            this.txt_CustAddress.Location = new System.Drawing.Point(189, 108);
            this.txt_CustAddress.Name = "txt_CustAddress";
            this.txt_CustAddress.Size = new System.Drawing.Size(161, 22);
            this.txt_CustAddress.TabIndex = 9;
            // 
            // txt_CustPhoneNo
            // 
            this.txt_CustPhoneNo.Location = new System.Drawing.Point(189, 154);
            this.txt_CustPhoneNo.Name = "txt_CustPhoneNo";
            this.txt_CustPhoneNo.Size = new System.Drawing.Size(161, 22);
            this.txt_CustPhoneNo.TabIndex = 10;
            // 
            // txt_CustEmail
            // 
            this.txt_CustEmail.Location = new System.Drawing.Point(189, 202);
            this.txt_CustEmail.Name = "txt_CustEmail";
            this.txt_CustEmail.Size = new System.Drawing.Size(161, 22);
            this.txt_CustEmail.TabIndex = 11;
            // 
            // txt_CustDateOB
            // 
            this.txt_CustDateOB.Location = new System.Drawing.Point(189, 242);
            this.txt_CustDateOB.Name = "txt_CustDateOB";
            this.txt_CustDateOB.Size = new System.Drawing.Size(161, 22);
            this.txt_CustDateOB.TabIndex = 12;
            // 
            // txt_CustNationalID
            // 
            this.txt_CustNationalID.Location = new System.Drawing.Point(189, 293);
            this.txt_CustNationalID.Name = "txt_CustNationalID";
            this.txt_CustNationalID.Size = new System.Drawing.Size(161, 22);
            this.txt_CustNationalID.TabIndex = 13;
            // 
            // btn_InsertCustomer
            // 
            this.btn_InsertCustomer.Location = new System.Drawing.Point(3, 354);
            this.btn_InsertCustomer.Name = "btn_InsertCustomer";
            this.btn_InsertCustomer.Size = new System.Drawing.Size(192, 43);
            this.btn_InsertCustomer.TabIndex = 14;
            this.btn_InsertCustomer.Text = "Insert New Customer";
            this.btn_InsertCustomer.UseVisualStyleBackColor = true;
            this.btn_InsertCustomer.Click += new System.EventHandler(this.btn_InsertCustomer_Click);
            // 
            // btn_showCustomers
            // 
            this.btn_showCustomers.Location = new System.Drawing.Point(595, 260);
            this.btn_showCustomers.Name = "btn_showCustomers";
            this.btn_showCustomers.Size = new System.Drawing.Size(193, 32);
            this.btn_showCustomers.TabIndex = 15;
            this.btn_showCustomers.Text = "Show Customers";
            this.btn_showCustomers.UseVisualStyleBackColor = true;
            this.btn_showCustomers.Click += new System.EventHandler(this.btn_showCustomers_Click);
            // 
            // btn_removeCustomer
            // 
            this.btn_removeCustomer.Location = new System.Drawing.Point(594, 376);
            this.btn_removeCustomer.Name = "btn_removeCustomer";
            this.btn_removeCustomer.Size = new System.Drawing.Size(194, 46);
            this.btn_removeCustomer.TabIndex = 16;
            this.btn_removeCustomer.Text = "Remove Customer";
            this.btn_removeCustomer.UseVisualStyleBackColor = true;
            this.btn_removeCustomer.Click += new System.EventHandler(this.btn_removeCustomer_Click);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(594, 318);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(193, 52);
            this.btn_UpdateCustomer.TabIndex = 17;
            this.btn_UpdateCustomer.Text = "Update Customer Details";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AutoGenerateColumns = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn,
            this.cUSTPHONEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dATEOFBIRTHDataGridViewTextBoxColumn,
            this.nATIONALIDDataGridViewTextBoxColumn});
            this.CustomerGridView.DataSource = this.cUSTOMERBindingSource1;
            this.CustomerGridView.Location = new System.Drawing.Point(368, 14);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowTemplate.Height = 24;
            this.CustomerGridView.Size = new System.Drawing.Size(419, 240);
            this.CustomerGridView.TabIndex = 18;
            // 
            // cUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMERID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Name = "cUSTOMERIDDataGridViewTextBoxColumn";
            this.cUSTOMERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Name = "cUSTOMERADDRESSDataGridViewTextBoxColumn";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.HeaderText = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTPHONEDataGridViewTextBoxColumn.Name = "cUSTPHONEDataGridViewTextBoxColumn";
            this.cUSTPHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.dATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATEOFBIRTHDataGridViewTextBoxColumn.Name = "dATEOFBIRTHDataGridViewTextBoxColumn";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.Width = 125;
            // 
            // nATIONALIDDataGridViewTextBoxColumn
            // 
            this.nATIONALIDDataGridViewTextBoxColumn.DataPropertyName = "NATIONALID";
            this.nATIONALIDDataGridViewTextBoxColumn.HeaderText = "NATIONALID";
            this.nATIONALIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nATIONALIDDataGridViewTextBoxColumn.Name = "nATIONALIDDataGridViewTextBoxColumn";
            this.nATIONALIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.bankSystemDataSet;
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(289, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search for a Customer with his ID to manage it";
            // 
            // txt_CustID
            // 
            this.txt_CustID.Location = new System.Drawing.Point(292, 364);
            this.txt_CustID.Name = "txt_CustID";
            this.txt_CustID.Size = new System.Drawing.Size(161, 22);
            this.txt_CustID.TabIndex = 20;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.bankSystemDataSet;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_CustID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.btn_UpdateCustomer);
            this.Controls.Add(this.btn_removeCustomer);
            this.Controls.Add(this.btn_showCustomers);
            this.Controls.Add(this.btn_InsertCustomer);
            this.Controls.Add(this.txt_CustNationalID);
            this.Controls.Add(this.txt_CustDateOB);
            this.Controls.Add(this.txt_CustEmail);
            this.Controls.Add(this.txt_CustPhoneNo);
            this.Controls.Add(this.txt_CustAddress);
            this.Controls.Add(this.txt_CustLname);
            this.Controls.Add(this.txt_CustFname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_CustFname;
        private System.Windows.Forms.TextBox txt_CustLname;
        private System.Windows.Forms.TextBox txt_CustAddress;
        private System.Windows.Forms.TextBox txt_CustPhoneNo;
        private System.Windows.Forms.TextBox txt_CustEmail;
        private System.Windows.Forms.TextBox txt_CustDateOB;
        private System.Windows.Forms.TextBox txt_CustNationalID;
        private System.Windows.Forms.Button btn_InsertCustomer;
        private System.Windows.Forms.Button btn_showCustomers;
        private System.Windows.Forms.Button btn_removeCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CustID;
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private BankSystemDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATIONALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
    }
}