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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            BankForm bankForm = new BankForm();
            bankForm.Show();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            branchForm.Show();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            ManageEmployees manageEmployees = new ManageEmployees();
            manageEmployees.Show();
        }
    }
}
