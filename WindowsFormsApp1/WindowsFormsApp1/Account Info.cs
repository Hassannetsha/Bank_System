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
    public partial class Account_Info : Form
    {
        private string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        int CustomerID;
        public Account_Info(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }

        private void Account_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            /*this.aCCOUNTTableAdapter.Fill(this.bankSystemDataSet.ACCOUNT);*/
            LoadAccountData();

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
