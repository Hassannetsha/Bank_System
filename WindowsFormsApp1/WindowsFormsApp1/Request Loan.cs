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
    public partial class Request_Loan : Form
    {
        private string connectionString = "Data Source=LAPTOP-0O63OIFI\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        int CustomerID;
        public Request_Loan(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }

        private void Request_Loan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            /*this.aCCOUNTTableAdapter.Fill(this.bankSystemDataSet.ACCOUNT);*/
            LoadAccountData();

        }
        /*
        Customer mainForm = new Customer(customerID);
        mainForm.Show();
        this.Hide();
        */
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
        private void btn_Request_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-F9CRI1I\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand(
                    "Insert into Loan values('"+text_LoanType.Text+"', '"+text_LoanAmount.Text+"', '"+text_Interestrate.Text+"', '"+text_OriginationDate.Text+"')"
                );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close(); */

            // Insert command
            string insertQuery = "INSERT INTO LOAN (EMP_SSN,ACCOUNTID,LOAN_TYPE, LOAN_AMOUNT, INTERESTRATE, ORIGINATIONDATE) " +
                                 "VALUES (null,@AccountId,@LoanType, @LoanAmount, @InterestRate, @OriginationDate)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@AccountId", txt_AccountId.Text);
                    cmd.Parameters.AddWithValue("@LoanType", text_LoanType.Text);
                    cmd.Parameters.AddWithValue("@LoanAmount", Convert.ToDecimal(text_LoanAmount.Text));
                    cmd.Parameters.AddWithValue("@InterestRate", Convert.ToDouble(text_Interestrate.Text));
                    cmd.Parameters.AddWithValue("@OriginationDate", DateTime.Now); // Auto-generate current date and time
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
    }
}
