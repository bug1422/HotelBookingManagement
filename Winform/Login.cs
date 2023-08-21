using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Services.Repository;
using Services.Tools;
namespace Winform
{
    public partial class Login : Form
    {
        AccountRepository _account;
        RoleRepository _role;
        public Login()
        {
            InitializeComponent();
            _account = new AccountRepository();
            _role = new RoleRepository();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Form f = new Signup();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
                if ((username, pass) == GetAccount())
                {
                    Form f = new StaffMenu();
                    f.Width = Screen.PrimaryScreen.Bounds.Width;
                    f.Height = Screen.PrimaryScreen.Bounds.Height;
                    f.ShowDialog();
                    this.Close();
                }
                var hashed_pass = HashPassword.Hash(pass);
                var account = _account.GetAll().FirstOrDefault(p => p.Username == username && p.Password == hashed_pass);
                if (account is null)
                {
                    MessageBox.Show("Wrong username or password.", "Login failed");
                }
                else
                {
                    Form f = new Form();
                    if (account.Roleid ==
                        _role.GetAll()
                        .FirstOrDefault(p => p.Name == "Customer").Id
                        ) f = new CustomerMenu(account);
                    if (account.Roleid ==
                        _role.GetAll()
                        .FirstOrDefault(p => p.Name == "Admin" || p.Name == "Staff").Id
                        ) f = new StaffMenu();
                    this.Hide();
                    f.Width = Screen.PrimaryScreen.Bounds.Width;
                    f.Height = Screen.PrimaryScreen.Bounds.Height;
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
        public (string username, string password) GetAccount()
        {
            IConfiguration _configuration;
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            return (_configuration.GetSection("Username").Value, _configuration.GetSection("Password").Value);
        }
    }
}
