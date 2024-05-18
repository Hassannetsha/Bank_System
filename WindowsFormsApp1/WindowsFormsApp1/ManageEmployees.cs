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
    public partial class ManageEmployees : Form
    {
        private string connectionString = "Data Source=DESKTOP-1H7L7GA\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        public ManageEmployees()
        {
            InitializeComponent();
            txt_EmpID.TextChanged += Txt_EmpID_TextChanged;
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            /* // TODO: This line of code loads data into the 'bankSystemDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
             this.eMPLOYEETableAdapter.Fill(this.bankSystemDataSet.EMPLOYEE);*/
        }
        private void LoadEmployeeData()
        {
            try
            {
                // Create a new SqlConnection and set the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data from the EMPLOYEE table
                    string query = "SELECT * FROM EMPLOYEE";

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the retrieved data
                        DataTable employeeTable = new DataTable();

                        // Fill the DataTable with data from the SqlDataAdapter
                        adapter.Fill(employeeTable);

                        // Set the DataSource of the DataGridView to the DataTable
                        EmployeeGridVIew.DataSource = employeeTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_show_employees_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btn_insert_employees_Click(object sender, EventArgs e)
        {
          
            SqlConnection connection = new SqlConnection(connectionString);
           

           
            string sql = @"INSERT INTO EMPLOYEE (BARNCH_NUMBER, EMP_FNAME, EMP_LNAME, EMP_ADDRESS, PHONENUMBER, JOBTITLE, EMP_EMAIL)
                   VALUES (@BranchNumber, @FirstName, @LastName, @Address, @PhoneNumber, @JobTitle, @Email)";

           
            SqlCommand cmd = new SqlCommand(sql, connection);

            
            cmd.Parameters.AddWithValue("@BranchNumber", txt_Branch_Number.Text);
            cmd.Parameters.AddWithValue("@FirstName", txt_EmpFname.Text);
            cmd.Parameters.AddWithValue("@LastName", txt_EmpLname.Text);
            cmd.Parameters.AddWithValue("@Address", txt_EmpAddress.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txt_EmpPhoneNum.Text);
            cmd.Parameters.AddWithValue("@JobTitle", txt_EmpJobTitle.Text);
            cmd.Parameters.AddWithValue("@Email", txt_EmpEmail.Text);

            try
            {
               
                connection.Open();

                
                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Employee inserted successfully!");
                LoadEmployeeData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                
                connection.Close();
            }
        }

        private void Txt_EmpID_TextChanged(object sender, EventArgs e)
        {
            // Ensure txt_EmpID has a value before querying the database
            if (!string.IsNullOrEmpty(txt_EmpID.Text))
            {
                int employeeId;
                if (int.TryParse(txt_EmpID.Text, out employeeId))
                {
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                           
                            connection.Open();

                           
                            string query = "SELECT * FROM EMPLOYEE WHERE EMPLOYEEID = @EmployeeID";

                            
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                               
                                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                               
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                   
                                    if (reader.Read())
                                    {
                                        
                                        txt_Branch_Number.Text = reader["BARNCH_NUMBER"].ToString();
                                        txt_EmpFname.Text = reader["EMP_FNAME"].ToString();
                                        txt_EmpLname.Text = reader["EMP_LNAME"].ToString();
                                        txt_EmpAddress.Text = reader["EMP_ADDRESS"].ToString();
                                        txt_EmpPhoneNum.Text = reader["PHONENUMBER"].ToString();
                                        txt_EmpJobTitle.Text = reader["JOBTITLE"].ToString();
                                        txt_EmpEmail.Text = reader["EMP_EMAIL"].ToString();
                                    }
                                    else
                                    {
                                        // Employee with the specified ID was not found
                                        MessageBox.Show("Employee not found.");
                                    }
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
                    // Show message if employee ID is not a valid number
                    MessageBox.Show("Employee ID must be a valid number.");
                }
            }
        }

        private void btn_Update_employees_Click(object sender, EventArgs e)
        {
            // Ensure txt_EmpID has a value before updating
            if (!string.IsNullOrEmpty(txt_EmpID.Text))
            {
                int employeeId;
                if (int.TryParse(txt_EmpID.Text, out employeeId))
                {
                    try
                    {
                        // Create a new SqlConnection and set the connection string
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Open the connection
                            connection.Open();

                            // Define the update query
                            string query = @"UPDATE EMPLOYEE SET 
                                    BARNCH_NUMBER = @BranchNumber, 
                                    EMP_FNAME = @FirstName, 
                                    EMP_LNAME = @LastName, 
                                    EMP_ADDRESS = @Address, 
                                    PHONENUMBER = @PhoneNumber, 
                                    JOBTITLE = @JobTitle, 
                                    EMP_EMAIL = @Email 
                                    WHERE EMPLOYEEID = @EmployeeID";

                            
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                               
                                cmd.Parameters.AddWithValue("@BranchNumber", txt_Branch_Number.Text);
                                cmd.Parameters.AddWithValue("@FirstName", txt_EmpFname.Text);
                                cmd.Parameters.AddWithValue("@LastName", txt_EmpLname.Text);
                                cmd.Parameters.AddWithValue("@Address", txt_EmpAddress.Text);
                                cmd.Parameters.AddWithValue("@PhoneNumber", txt_EmpPhoneNum.Text);
                                cmd.Parameters.AddWithValue("@JobTitle", txt_EmpJobTitle.Text);
                                cmd.Parameters.AddWithValue("@Email", txt_EmpEmail.Text);
                                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                                
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Check if update was successful
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee updated successfully!");
                                    LoadEmployeeData();
                                }
                                else
                                {
                                    MessageBox.Show("Employee not found or no changes made.");
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
                    // Show message if employee ID is not a valid number
                    MessageBox.Show("Employee ID must be a valid number.");
                }
            }
        }

        private void btn_Delete_employees_Click(object sender, EventArgs e)
        {
       
            if (!string.IsNullOrEmpty(txt_EmpID.Text))
            {
                int employeeId;
                if (int.TryParse(txt_EmpID.Text, out employeeId))
                {
                    try
                    {
                       
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            
                            connection.Open();

                    
                            string query = "DELETE FROM EMPLOYEE WHERE EMPLOYEEID = @EmployeeID";

                            
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                
                                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                               
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Check if delete was successful
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee deleted successfully!");
                                    LoadEmployeeData();
                                    ClearTextBoxes();
                                }
                                else
                                {
                                    MessageBox.Show("Employee not found or could not be deleted.");
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
                    // Show message if employee ID is not a valid number
                    MessageBox.Show("Employee ID must be a valid number.");
                }
            }
            else
            {
                // Show message if txt_EmpID is empty
                MessageBox.Show("Please enter Employee ID.");
            }
        }


        private void ClearTextBoxes()
        {
            txt_EmpID.Text = "";
            txt_Branch_Number.Text = "";
            txt_EmpFname.Text = "";
            txt_EmpLname.Text = "";
            txt_EmpAddress.Text = "";
            txt_EmpPhoneNum.Text = "";
            txt_EmpJobTitle.Text = "";
            txt_EmpEmail.Text = "";
        }

    }
}
