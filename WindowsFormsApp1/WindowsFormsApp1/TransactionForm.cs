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
        string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        int CustomerID;
        public TransactionForm(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            LoadTransactionData();
            LoadAccountData();
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
                        dataGridView2.DataSource = AccountTable;
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
            decimal transactionAmount;
            if (!decimal.TryParse(Amount.Text, out transactionAmount))
            {
                MessageBox.Show("Please enter a valid transaction amount.");
                return;
            }

            string accountId = Id.Text;

            // SQL query to retrieve the current balance for the account
            string balanceQuery = "SELECT BALANCE FROM ACCOUNT WHERE ACCOUNTID = @ACCOUNTID";

            // SQL insert command for TRANSCATION table
            string insertQuery = "INSERT INTO TRANSCATION (ACCOUNTID, TRANSACTION_DATE, TRANSACTION_AMOUNT, TRANSACTION_TYPE, DESCRIPTION) " +
                                 "VALUES (@ACCOUNTID, @TRANSACTION_DATE, @TRANSACTION_AMOUNT, @TRANSACTION_TYPE, @DESCRIPTION)";

            // SQL update command for ACCOUNT table
            string updateQuery = "UPDATE ACCOUNT SET BALANCE = BALANCE - @TRANSACTION_AMOUNT WHERE ACCOUNTID = @ACCOUNTID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand balanceCommand = new SqlCommand(balanceQuery, connection);
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

                // Set parameter values for balance command
                balanceCommand.Parameters.AddWithValue("@ACCOUNTID", accountId);

                // Set parameter values for insert and update commands
                insertCommand.Parameters.AddWithValue("@ACCOUNTID", accountId);
                insertCommand.Parameters.AddWithValue("@TRANSACTION_DATE", DateTime.Now); // Insert current date and time
                insertCommand.Parameters.AddWithValue("@TRANSACTION_AMOUNT", transactionAmount);
                insertCommand.Parameters.AddWithValue("@TRANSACTION_TYPE", Type.Text);
                insertCommand.Parameters.AddWithValue("@DESCRIPTION", Description.Text);

                updateCommand.Parameters.AddWithValue("@ACCOUNTID", accountId);
                updateCommand.Parameters.AddWithValue("@TRANSACTION_AMOUNT", transactionAmount);

                try
                {
                    connection.Open();

                    // Retrieve the current balance
                    decimal currentBalance = (decimal)balanceCommand.ExecuteScalar();

                    // Check if the transaction amount exceeds the current balance
                    if (transactionAmount > currentBalance)
                    {
                        MessageBox.Show("Insufficient balance for this transaction.");
                        return;
                    }

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        insertCommand.Transaction = transaction;
                        updateCommand.Transaction = transaction;

                        // Execute the insert command
                        insertCommand.ExecuteNonQuery();

                        // Execute the update command
                        updateCommand.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        MessageBox.Show("Transaction added and balance updated successfully.");
                        LoadTransactionData();
                        LoadAccountData(); // Refresh account data in UI
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
