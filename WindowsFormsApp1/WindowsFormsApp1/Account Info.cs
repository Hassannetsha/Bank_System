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
    public partial class Account_Info : Form
    {
        public Account_Info()
        {
            InitializeComponent();
        }

        private void Account_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.bankSystemDataSet.ACCOUNT);

        }
    }
}
