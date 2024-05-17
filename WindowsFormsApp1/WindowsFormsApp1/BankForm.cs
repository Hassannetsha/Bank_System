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
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "INSERT INTO BANK VALUES ('"+BankName.Text+ "')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = s;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "DELETE FROM BANK WHERE BANK_NAME ='"+BankName.Text+ "' AND CODE = '" + Code.Text + "';";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = s;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string s = "UPDATE BANK SET BANK_NAME = '"+BankName.Text+ "' WHERE CODE = '"+Code.Text+"';";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = s;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

