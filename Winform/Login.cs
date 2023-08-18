using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Repository;
using Services.Tools;
namespace Winform
{
    public partial class Login : Form
    {
        AccountRepository _account;
        public Login()
        {
            InitializeComponent();
            _account = new AccountRepository();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Form f = new Signup();
            f.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please insert all fields.", "Missing fields");
            }
            else
            {
                var hashed_pass = HashPassword.Hash(pass);
                var account = _account.GetAll().FirstOrDefault(p => p.Username == username && p.Password == hashed_pass);
                if (account is null)
                {
                    MessageBox.Show("Wrong username or password.", "Login failed");
                }
                else
                {
                    MessageBox.Show("Success.", "Debug");
                }
            }
        }
    }
}
