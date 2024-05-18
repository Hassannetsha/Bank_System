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
    public partial class ManageCustomers : Form
    {
        private string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        public ManageCustomers()
        {
            InitializeComponent();
            txt_CustID.TextChanged += txt_CustID_TextChanged;
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            /*this.cUSTOMERTableAdapter.Fill(this.bankSystemDataSet.CUSTOMER);*/

        }
        
          private void LoadCustomerData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM CUSTOMER ";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable customerTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(customerTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        CustomerGridView.DataSource = customerTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void btn_showCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void btn_InsertCustomer_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes
            string fname = txt_CustFname.Text;
            string lname = txt_CustLname.Text;
            string address = txt_CustAddress.Text;
            string phone = txt_CustPhoneNo.Text;
            string email = txt_CustEmail.Text;
            string dateOfBirth = txt_CustDateOB.Text;
            string nationalId = txt_CustNationalID.Text;

            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to insert a new customer
                    string query = "INSERT INTO CUSTOMER (FNAME, LNAME, CUSTOMER_ADDRESS, CUST_PHONE, EMAIL, DATEOFBIRTH, NATIONALID) " +
                                   "VALUES (@FNAME, @LNAME, @CUSTOMER_ADDRESS, @CUST_PHONE, @EMAIL, @DATEOFBIRTH, @NATIONALID)";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command to prevent SQL injection
                        command.Parameters.AddWithValue("@FNAME", fname);
                        command.Parameters.AddWithValue("@LNAME", lname);
                        command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                        command.Parameters.AddWithValue("@CUST_PHONE", phone);
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@DATEOFBIRTH", dateOfBirth);
                        command.Parameters.AddWithValue("@NATIONALID", nationalId);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer inserted successfully.");
                            LoadCustomerData(); // Refresh the customer data grid view
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert customer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FetchCustomerDetailsById(int customerId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM CUSTOMER WHERE CUSTOMERID = @CUSTOMERID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CUSTOMERID", customerId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_CustFname.Text = reader["FNAME"].ToString();
                                txt_CustLname.Text = reader["LNAME"].ToString();
                                txt_CustAddress.Text = reader["CUSTOMER_ADDRESS"].ToString();
                                txt_CustPhoneNo.Text = reader["CUST_PHONE"].ToString();
                                txt_CustEmail.Text = reader["EMAIL"].ToString();
                                txt_CustDateOB.Text = reader["DATEOFBIRTH"].ToString();
                                txt_CustNationalID.Text = reader["NATIONALID"].ToString();
                            }
                            else
                            {
                                ClearCustomerTextBoxes();
                                MessageBox.Show("Customer not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearCustomerTextBoxes()
        {
            txt_CustFname.Clear();
            txt_CustLname.Clear();
            txt_CustAddress.Clear();
            txt_CustPhoneNo.Clear();
            txt_CustEmail.Clear();
            txt_CustDateOB.Clear();
            txt_CustNationalID.Clear();
        }

        private void txt_CustID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_CustID.Text, out int customerId))
            {
                FetchCustomerDetailsById(customerId);
            }
            else
            {
                ClearCustomerTextBoxes();
            }
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            // Ensure the customer ID is a valid number
            if (int.TryParse(txt_CustID.Text, out int customerId))
            {
                // Retrieve updated data from textboxes
                string fname = txt_CustFname.Text;
                string lname = txt_CustLname.Text;
                string address = txt_CustAddress.Text;
                string phone = txt_CustPhoneNo.Text;
                string email = txt_CustEmail.Text;
                string dateOfBirth = txt_CustDateOB.Text;
                string nationalId = txt_CustNationalID.Text;

                try
                {
                    // Create a new SqlConnection and set the connection string
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // Define the query to update the customer details
                        string query = "UPDATE CUSTOMER SET FNAME = @FNAME, LNAME = @LNAME, CUSTOMER_ADDRESS = @CUSTOMER_ADDRESS, " +
                                       "CUST_PHONE = @CUST_PHONE, EMAIL = @EMAIL, DATEOFBIRTH = @DATEOFBIRTH, NATIONALID = @NATIONALID " +
                                       "WHERE CUSTOMERID = @CUSTOMERID";

                        // Create a SqlCommand to execute the query
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the command to prevent SQL injection
                            command.Parameters.AddWithValue("@CUSTOMERID", customerId);
                            command.Parameters.AddWithValue("@FNAME", fname);
                            command.Parameters.AddWithValue("@LNAME", lname);
                            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", address);
                            command.Parameters.AddWithValue("@CUST_PHONE", phone);
                            command.Parameters.AddWithValue("@EMAIL", email);
                            command.Parameters.AddWithValue("@DATEOFBIRTH", dateOfBirth);
                            command.Parameters.AddWithValue("@NATIONALID", nationalId);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the update was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer updated successfully.");
                                LoadCustomerData(); // Refresh the customer data grid view
                            }
                            else
                            {
                                MessageBox.Show("Failed to update customer.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.");
            }
        }

        private void btn_removeCustomer_Click(object sender, EventArgs e)
        {
            // Ensure the customer ID is a valid number
            if (int.TryParse(txt_CustID.Text, out int customerId))
            {
                try
                {
                    // Create a new SqlConnection and set the connection string
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // Define the query to delete the customer
                        string query = "DELETE FROM CUSTOMER WHERE CUSTOMERID = @CUSTOMERID";

                        // Create a SqlCommand to execute the query
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the command to prevent SQL injection
                            command.Parameters.AddWithValue("@CUSTOMERID", customerId);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the delete was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer removed successfully.");
                                LoadCustomerData(); // Refresh the customer data grid view
                                ClearCustomerTextBoxes(); // Clear the text boxes
                            }
                            else
                            {
                                MessageBox.Show("Failed to remove customer.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show an error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.");
            }
        }
    }


}

