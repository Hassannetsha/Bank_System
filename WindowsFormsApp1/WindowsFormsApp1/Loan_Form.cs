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
    public partial class loan_form : Form
    {
        private string connectionString = "Data Source=LAPTOP-0O63OIFI\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        public loan_form()
        {
            InitializeComponent();
        }

        private void loan_form_Load(object sender, EventArgs e)
        {

            LoadLoanData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-0O63OIFI\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int ctn = 0;
                bool write = false;
                foreach (DataGridViewCell column in row.Cells)
                {
                    string s = column.Value.ToString();
                    if (txt_loan_num.Text != null && txt_loan_num.Text == s)
                    {
                        write = true;
                    }
                    if (write == true)
                    {
                        ctn++;
                        if (ctn == 3)
                        {
                            AccoutId = s;
                        }
                        if (ctn == 6)
                        {
                            Loan_Amount = s;
                        }
                        if (ctn == 8)
                        {
                            SqlCommand cmd = new SqlCommand("delete from LOAN where LOAN_NUMBER = '" + txt_loan_num.Text + "' ;update ACCOUNT set BALANCE = BALANCE + '" + Loan_Amount + "' where ACCOUNTID = '" + AccoutId + "';", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("done!");
                            this.lOANTableAdapter.Fill(this.bankSystemDataSet.LOAN);
                            break;
                        }
                    }
                }
                if (write) { break; }
            }
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-0O63OIFI\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand("delete from LOAN where LOAN_NUMBER = '" + txt_loan_num.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done!");
            this.lOANTableAdapter.Fill(this.bankSystemDataSet.LOAN);
        }
        private void LoadLoanData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM LOAN";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable LoanTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(LoanTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = LoanTable;
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
