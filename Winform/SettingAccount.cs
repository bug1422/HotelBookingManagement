using Services.Models;
using Services.Repository;
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
            txtPassword.Text = account.Password;

        }

        private void SettingAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                MessageBox.Show("Username not null");
            }
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Username not null");
            }
            if (txtrepassword.Text.Equals(""))
            {
                MessageBox.Show("Username not null");
            }
            else
            {
                if (!txtPassword.Text.Equals(txtrepassword.Text))
                {
                    MessageBox.Show("Password and repassword must same");
                }
                else
                {
                    Account a = new Account() { Id = account.Id, Username = txtUserName.Text, Password = txtPassword.Text, Status = account.Status, Roleid = account.Roleid, Phone = account.Phone, Gender = account.Gender, Birthday = account.Birthday, Address = account.Address, Name = account.Name};
                    _account.Update(a);
                    MessageBox.Show("Saved");
                    DialogResult = DialogResult.OK;
                }
            }

        }
    }
}
