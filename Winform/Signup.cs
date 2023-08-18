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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Signup : Form
    {
        AccountRepository _account;
        RoleRepository _role;
        bool isVerified = false;
        public Signup()
        {
            InitializeComponent();
            _account = new AccountRepository();
            _role = new RoleRepository();
            gender.SelectedIndex = -1;
            birthday.MaxDate = DateTime.Now;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isVerified)
            {
                try
                {
                    string hashed_pass = HashPassword.Hash(txtPass.Text);
                    Account add = new Account()
                    {
                        Username = txtName.Text,
                        Name = txtFullname.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        Password = hashed_pass,
                        Birthday = birthday.Value,
                        Gender = gender.SelectedValue.ToString(),
                        Roleid = _role.GetAll().FirstOrDefault(p => p.Name == "Customer").Id,
                        Status = 1
                    };
                    _account.Add(add);
                    MessageBox.Show("Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }

        private void Verify(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            isVerified = true;
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "This is required!");
                isVerified = false;
            }
            if (txtFullname.Text == "")
            {
                errorProvider1.SetError(txtFullname, "This is required!");
                isVerified = false;
            }
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "This is required!");
                isVerified = false;
            }
            else
            {
                Regex pattern = new Regex("\\+?[1-9][0-9]{7,14}");
                if (!pattern.IsMatch(txtPhone.Text))
                {
                    errorProvider1.SetError(txtPhone, "Invalid phone number!");
                    isVerified = false;
                }
            }
            if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "This is required!");
                isVerified = false;
            }
            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "This is required!");
                isVerified = false;
            }
            else if (txtPass.Text.Length <= 3)
            {
                errorProvider1.SetError(txtPass, "Password must be longer than 3 characters");
                isVerified = false;
            }
            if (DateTime.Now.Year - birthday.Value.Year < 5)
            {
                errorProvider1.SetError(birthday, "you have to be at least 5 years old to create account.!");
                isVerified = false;
            }
            if (gender.SelectedIndex < 0)
            {
                errorProvider1.SetError(gender, "Gender is not selected");
                isVerified = false;
            }
        }
    }
}
