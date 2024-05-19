using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        int customerId;
        public Customer(int Id)
        {
            customerId = Id;
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            Request_Loan request_Loan = new Request_Loan(customerId);
            request_Loan.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Account_Info account_info = new Account_Info(customerId);
            account_info.Show();

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnTransction_Click(object sender, EventArgs e)
        {
            TransactionForm transForm = new TransactionForm(customerId);
            transForm.Show();
        }
    }
}
