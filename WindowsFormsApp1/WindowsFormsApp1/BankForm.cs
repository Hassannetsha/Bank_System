using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BankForm : Form
    {
        string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        public BankForm()
        {
            InitializeComponent();
            LoadBankData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string insertBankQuery = "INSERT INTO BANK (BANK_NAME) VALUES (@BankName); SELECT SCOPE_IDENTITY();";
                string insertAddressQuery = "INSERT INTO BANK_ADDRESSES (BANK_ADDRESS, BANK_CODE) VALUES (@BankAddress, @BankCode)";

                try
                {
                    sqlConnection.Open();

                    // Insert into BANK and get the newly generated CODE
                    using (SqlCommand sqlCommand = new SqlCommand(insertBankQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@BankName", BankName.Text);

                        // Execute the query and get the new CODE
                        decimal newBankCode = (decimal)sqlCommand.ExecuteScalar();

                        // Insert into BANK_ADDRESSES using the new CODE
                        using (SqlCommand addressCommand = new SqlCommand(insertAddressQuery, sqlConnection))
                        {
                            addressCommand.Parameters.AddWithValue("@BankAddress", BankAddress.Text);
                            addressCommand.Parameters.AddWithValue("@BankCode", newBankCode);

                            addressCommand.ExecuteNonQuery();
                        }
                    }

                    LoadBankData();
                    MessageBox.Show("Bank added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ClearFeilds();
                    sqlConnection.Close();
                }
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BankName.Text) || string.IsNullOrWhiteSpace(Code.Text))
            {
                MessageBox.Show("Please provide both Bank Name and Code.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM BANK WHERE BANK_NAME = @BankName AND CODE = @Code";

                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@BankName", BankName.Text);
                        sqlCommand.Parameters.AddWithValue("@Code", Code.Text);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bank deleted successfully!");
                            LoadBankData();
                        }
                        else
                        {
                            MessageBox.Show("No bank found with the provided details.");
                        }
                        LoadBankData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ClearFeilds();
                    sqlConnection.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BankName.Text) || string.IsNullOrWhiteSpace(Code.Text) || string.IsNullOrWhiteSpace(BankAddress.Text))
            {
                MessageBox.Show("Please provide Bank Name, Code, and Address.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string updateBankQuery = "UPDATE BANK SET BANK_NAME = @BankName WHERE CODE = @Code";
                string updateAddressQuery = "UPDATE BANK_ADDRESSES SET BANK_ADDRESS = @Address WHERE BANK_CODE = @Code";

                try
                {
                    sqlConnection.Open();

                    // Start a transaction
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    using (SqlCommand bankCommand = new SqlCommand(updateBankQuery, sqlConnection, transaction))
                    {
                        bankCommand.Parameters.AddWithValue("@BankName", BankName.Text);
                        bankCommand.Parameters.AddWithValue("@Code", Code.Text);

                        int bankRowsAffected = bankCommand.ExecuteNonQuery();

                        using (SqlCommand addressCommand = new SqlCommand(updateAddressQuery, sqlConnection, transaction))
                        {
                            addressCommand.Parameters.AddWithValue("@Address", BankAddress.Text);
                            addressCommand.Parameters.AddWithValue("@Code", Code.Text);

                            int addressRowsAffected = addressCommand.ExecuteNonQuery();

                            // Check if both updates were successful
                            if (bankRowsAffected > 0 && addressRowsAffected > 0)
                            {
                                // Commit the transaction
                                transaction.Commit();
                                MessageBox.Show("Bank and address updated successfully!");
                                LoadBankData();
                            }
                            else
                            {
                                // Rollback the transaction if either update failed
                                transaction.Rollback();
                                MessageBox.Show("No bank or address found with the provided details.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    ClearFeilds();
                    sqlConnection.Close();
                }
            }
        }

        private void LoadBankData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the BANK and BANK_ADDRESSES tables and order by CODE
                    string query = @"
                        SELECT 
                            b.CODE AS Bank_Code,
                            b.BANK_NAME AS Bank_Name,
                            ba.BANK_ADDRESS AS Bank_Address
                        FROM 
                            BANK b
                        INNER JOIN 
                            BANK_ADDRESSES ba
                        ON 
                            b.CODE = ba.BANK_CODE
                        ORDER BY 
                            b.CODE ASC";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable bankTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(bankTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = bankTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        /*
        private void LoadBankData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM BANK";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable employeeTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(employeeTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = employeeTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        */
        private void ClearFeilds()
        {
            BankName.Text = "";
            BankAddress.Text = "";
            Code.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void BankForm_Load(object sender, EventArgs e)
        {

        }

        private void BankAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

