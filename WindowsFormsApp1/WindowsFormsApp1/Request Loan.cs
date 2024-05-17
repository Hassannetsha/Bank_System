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
        public Request_Loan()
        {
            InitializeComponent();
        }

        private void Request_Loan_Load(object sender, EventArgs e)
        {

        }

        private void text_LoanType_TextChanged(object sender, EventArgs e)
        {

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
            string connectionString = "Data Source=DESKTOP-F9CRI1I\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";

            // Insert command
            string insertQuery = "INSERT INTO LOAN (LOAN_TYPE, LOAN_AMOUNT, INTERESTRATE, ORIGINATIONDATE) " +
                                 "VALUES (@LoanType, @LoanAmount, @InterestRate, @OriginationDate)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    // Add parameters with appropriate data types
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
