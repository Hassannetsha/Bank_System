using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        private string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";

        public Report()
        {
            InitializeComponent();
            LoadCustomerReportData();
        }

        

        private void LoadCustomerReportData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the CUSTOMER, ACCOUNT, LOAN, and TRANSACTION tables
                    string query = "SELECT c.CUSTOMERID, c.FNAME + ' ' + c.LNAME AS CustomerName, c.CUSTOMER_ADDRESS AS Address, c.CUST_PHONE AS PhoneNumber, c.EMAIL AS Email, c.DATEOFBIRTH AS DateOfBirth, COUNT(DISTINCT a.ACCOUNTID) AS TotalAccounts, COUNT(DISTINCT l.LOAN_NUMBER) AS TotalLoans, ISNULL(SUM(t.TRANSACTION_AMOUNT), 0) AS TotalTransactionsAmount, AVG(a.BALANCE) AS AverageAccountBalance, MAX(t.TRANSACTION_DATE) AS LastTransactionDate " +
                   "FROM CUSTOMER c " +
                   "LEFT JOIN " +
                   "   ACCOUNT a ON c.CUSTOMERID = a.CUSTOMERID " +
                   "LEFT JOIN " +
                   "   LOAN l ON c.CUSTOMERID = l.CUSTOMERID " +
                   "LEFT JOIN " +
                   "   TRANSCATION t ON a.ACCOUNTID = t.ACCOUNTID " +
                   "GROUP BY " +
                   "   c.CUSTOMERID, c.FNAME, c.LNAME, c.CUSTOMER_ADDRESS, c.CUST_PHONE, c.EMAIL, c.DATEOFBIRTH " +
                   "ORDER BY c.CUSTOMERID;";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable reportTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(reportTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        ReportGridView.DataSource = reportTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
