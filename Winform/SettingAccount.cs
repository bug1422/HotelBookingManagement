using Services.Models;
using Services.Repository;
using Services.Tools;
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
    public partial class SettingAccount : Form
    {
        private AccountRepository _account = new AccountRepository();
        Account account;
        public SettingAccount(Account ac)
        {
            account = ac;
            InitializeComponent();
            txtUserName.Text = account.Name;
        }

        private void SettingAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOld.Text.Equals(""))
            {
                MessageBox.Show("Old password not null.");
            }
            if (txtNew.Text.Equals(""))
            {
                MessageBox.Show("New password not null.");
            }
            else if(txtNew.Text.Length <= 3)
            {
                MessageBox.Show("New password must be longer than 3 characters.");
            }
            else
            {
                if (account.Password != HashPassword.Hash(txtOld.Text))
                {
                    MessageBox.Show("Old password is incorrect.");
                }
                else
                {
                    account.Password = HashPassword.Hash(txtNew.Text);
                    _account.Update(account);
                    MessageBox.Show("Saved");
                    DialogResult = DialogResult.OK;
                }
            }

        }
    }
}
