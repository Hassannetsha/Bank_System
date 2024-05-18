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
        public Customer()
        {
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            Request_Loan request_Loan = new Request_Loan();
            request_Loan.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Account_Info account_info = new Account_Info();
            account_info.Show();
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
