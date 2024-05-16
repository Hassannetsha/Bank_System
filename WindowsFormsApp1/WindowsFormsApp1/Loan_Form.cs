using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Loan_Form : Form
    {
        public Loan_Form()
        {
            InitializeComponent();
        }

        private void Loan_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet1.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bankSystemDataSet1.LOAN);
            // TODO: This line of code loads data into the 'projectDataSet.emp' table. You can move, or remove it, as needed.
            //this.empTableAdapter.Fill(this.projectDataSet.emp);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-0O63OIFI\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True;Encrypt=False";
            SqlCommand cmd = new SqlCommand("delete from LOAN where LOAN_NUMBER = '" + txt_loan_num.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done!");
            this.lOANTableAdapter.Fill(this.bankSystemDataSet1.LOAN);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_accept_payloan_Click(object sender, EventArgs e)
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
                            this.lOANTableAdapter.Fill(this.bankSystemDataSet1.LOAN);
                            break;
                        }
                    }
                }
                if (write) { break; }
            }
        }
    }
}
