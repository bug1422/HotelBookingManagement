using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.MdiParent = this;
            staffManagement.Show();
        }

        private void incomeCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeCheckPage incomeCheck = new IncomeCheckPage();
            incomeCheck.MdiParent = this;
            incomeCheck.Show();
        }
    }
}
