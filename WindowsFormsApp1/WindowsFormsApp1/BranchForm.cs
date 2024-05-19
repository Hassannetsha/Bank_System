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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            string query = "INSERT INTO BRANCH (BANK_CODE, BARNCH_ADDRESS, CITY, STATE, ZIPCODE)" +
                "VALUES (@BANK_CODE, @BARNCH_ADDRESS, @CITY, @STATE, @ZIPCODE)";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@BANK_CODE", branchCodeInput.Text);
            cmd.Parameters.AddWithValue("@BARNCH_ADDRESS", BranchAddressInput.Text);
            cmd.Parameters.AddWithValue("@CITY", CityInput.Text);
            cmd.Parameters.AddWithValue("@STATE", StateInput.Text);
            cmd.Parameters.AddWithValue("@ZIPCODE", ZipCodeInput.Text);

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Branch Added Successfully!");

            LoadBranchTable();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            branchCodeInput.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BranchAddressInput.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CityInput.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StateInput.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ZipCodeInput.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE BRANCH " +
                "SET BANK_CODE=@BANK_CODE, BARNCH_ADDRESS=@BARNCH_ADDRESS, CITY=@CITY, STATE=@STATE, ZIPCODE=@ZIPCODE " +
                "WHERE BRANCH_NUMBER = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();

            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@BANK_CODE", branchCodeInput.Text);
            cmd.Parameters.AddWithValue("@BARNCH_ADDRESS", BranchAddressInput.Text);
            cmd.Parameters.AddWithValue("@CITY", CityInput.Text);
            cmd.Parameters.AddWithValue("@STATE", StateInput.Text);
            cmd.Parameters.AddWithValue("@ZIPCODE", ZipCodeInput.Text);

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Cell Updated Successfully!");

            LoadBranchTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM BRANCH WHERE BRANCH_NUMBER = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();

            SqlConnection connection = new SqlConnection(sql);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Cell Deleted Successfully!");

            LoadBranchTable();

        }
    }
}
