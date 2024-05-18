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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = CustmID.Text;
            string nationalID = NatID.Text;
            string firstName = F_name.Text;
            if (IsValidUser(customerID, nationalID, firstName))
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("Invalid Customer ID , National ID or First name", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string customerID, string nationalID, string firstName)
        {
            bool isValid = false;

            string connectionString = "Server=desktop-1o5tpi7;Database=BankSystem;Integrated Security=True;";

            string query = "SELECT COUNT(*) FROM CUSTOMER WHERE CUSTOMERID = @CustomerID AND NATIONALID = @NationalID AND FNAME= @firstName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@NationalID", nationalID);
                cmd.Parameters.AddWithValue("@firstName", F_name);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    isValid = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }
    }
}