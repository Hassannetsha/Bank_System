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
    public partial class BranchForm : Form
    {

        string sql = "Data Source=DESKTOP-F9CRI1I\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";

        public BranchForm()
        {
            InitializeComponent();
        }

        public void LoadBranchTable()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(sql))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM BRANCH";

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
            
            /* DataTable table = new DataTable();

            String query = "SELECT * FROM BRANCH";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(table);

            con.Close();

            return table; */
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            LoadBranchTable();
        }
    }
}
