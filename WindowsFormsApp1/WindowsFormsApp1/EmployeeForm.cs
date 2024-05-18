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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btn_manageCust_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomersForm = new ManageCustomers();
            manageCustomersForm.Show();
        }

        private void btn_manageLoans_Click(object sender, EventArgs e)
        {
            loan_form loan_Form = new loan_form();
            loan_Form.Show();
        }
    }
}
