using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TransactionForm : Form
    {
        string connectionString = "Data Source=HASSANMUHAMMED\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        int CustomerID;
        public TransactionForm(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            LoadTransactionData();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadTransactionData()
        { 
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the TRANSCATION table
                    string query = @"
                    SELECT 
                        TRANSACTIONID,
                        ACCOUNTID,
                        TRANSACTION_DATE,
                        TRANSACTION_AMOUNT,
                        TRANSACTION_TYPE,
                        DESCRIPTION
                    FROM 
                        TRANSCATION
                    ORDER BY 
                        TRANSACTIONID ASC";  // You can adjust the order by clause as needed

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable transactionTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(transactionTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = transactionTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadAccountData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM ACCOUNT where CUSTOMERID = '" + CustomerID + "'";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable AccountTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(AccountTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = AccountTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Database connection string
            // SQL insert command for TRANSCATION table
            string insertQuery = "INSERT INTO TRANSCATION (ACCOUNTID, TRANSACTION_DATE, TRANSACTION_AMOUNT, TRANSACTION_TYPE, DESCRIPTION) " +
                                 "VALUES (@ACCOUNTID, @TRANSACTION_DATE, @TRANSACTION_AMOUNT, @TRANSACTION_TYPE, @DESCRIPTION)";

            // Execute the insert command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                // Set parameter values
                command.Parameters.AddWithValue("@ACCOUNTID", Id.Text);
                command.Parameters.AddWithValue("@TRANSACTION_DATE", DateTime.Now); // Insert current date and time
                command.Parameters.AddWithValue("@TRANSACTION_AMOUNT", Amount.Text);
                command.Parameters.AddWithValue("@TRANSACTION_TYPE", Type.Text);
                command.Parameters.AddWithValue("@DESCRIPTION", Description.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction added successfully.");
                    LoadTransactionData(); // Refresh transaction data in UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
    }
}
