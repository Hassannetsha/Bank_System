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
            btn_Account.Click += btn_Account_Click;
            btn_Request.Click += btn_Request_Click;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            Request_Loan request = new Request_Loan();
            request.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Account_Info account = new Account_Info();
            account.Show();
        }
    }
}
