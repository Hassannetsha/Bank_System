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
    public partial class BankForm : Form
    {
        string connectionString = "Data Source=HASSANMUHAMMED\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
        public BankForm()
        {
            InitializeComponent();
            LoadBankData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "INSERT INTO BANK VALUES ('" + BankName.Text + "')";
            /*string s2 = "INSERT INTO BANK_ADDRESSES VALUES ('" + BankAddress.Text + "','""')";*/
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;


            try
            {
                // comment
                sqlConnection.Open();
                sqlCommand.CommandText = s;
                sqlCommand.ExecuteNonQuery();
                /*
                 * select code 
                 * where name = 
                 * 
                 * insert into BankAdd
                 * values (addres,code)
                 * 
                 */
                LoadBankData();
                MessageBox.Show("Bank Added successfully!");
                //LoadEmployeeData();
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



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "DELETE FROM BANK WHERE BANK_NAME ='" + BankName.Text + "' AND CODE = '" + Code.Text + "';";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = s;
                sqlCommand.ExecuteNonQuery();
                LoadBankData();
                MessageBox.Show("Bank Deleted successfully!");
                //LoadEmployeeData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "UPDATE BANK SET BANK_NAME = '" + BankName.Text + "' WHERE CODE = '" + Code.Text + "';";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = s;
                sqlCommand.ExecuteNonQuery();
                LoadBankData();
                MessageBox.Show("Bank Updated successfully!");
                //LoadEmployeeData();
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
        private void ClearFeilds()
        {
            BankName.Text = "";
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
    }
}

