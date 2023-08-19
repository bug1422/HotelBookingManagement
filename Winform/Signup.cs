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
            Verify();
            if (isVerified)
            {
                try
                {
                    string hashed_pass = HashPassword.Hash(txtPass.Text);
                    string sex = gender.SelectedItem.ToString();
                    int roleId = _role.GetAll().FirstOrDefault(p => p.Name == "Customer").Id;
                    Account add = new Account()
                    {
                        Username = capitalize(txtName.Text),
                        Name = txtFullname.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        Password = hashed_pass,
                        Birthday = birthday.Value,
                        Gender = sex,
                        Roleid = roleId,
                        Status = 1
                    };
                    _account.Add(add);
                    MessageBox.Show("Creating successfully!", "Account created");
                    Form f = new CustomerMenu();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }
        private string capitalize(string text)
        {
            var list = new List<string>();
            foreach (var p in text.Split(" "))
            {
                if (!String.IsNullOrWhiteSpace(p))
                {
                    list.Add(p.Substring(0, 1).ToUpper() + p.Substring(1).ToLower());
                }
            }
            return String.Join(" ", list);
        }
        private void Verify()
        {
            isVerified = true;
            string error = "";
            if (txtName.Text == "")
            {
                error += "Username is empty.\n";
            }
            if (txtFullname.Text == "")
            {
                error += "Full name is empty.\n";
            }
            if (txtPhone.Text == "")
            {
                error += "Phone number is empty.\n";
            }
            else
            {
                Regex pattern = new Regex("\\+?[1-9][0-9]{7,14}");
                if (!pattern.IsMatch(txtPhone.Text))
                {
                    error += "Phone number is not in correct format.\n";
                }
            }
            if (txtAddress.Text == "")
            {
                error += "Address is empty.\n";
            }
            if (txtPass.Text == "")
            {
                error += "Password is empty.\n";
            }
            else if (txtPass.Text.Length <= 3)
            {
                error += "Password must be longer than 3 characters.\n";
            }
            if (DateTime.Now.Year - birthday.Value.Year < 5)
            {
                error += "Invalid year of birth, you have to be 5+ years olds.\n";
            }
            if (gender.SelectedIndex < 0)
            {
                error += "Gender is not selected.\n";
            }
            if (String.IsNullOrEmpty(error)) isVerified = true;
            else
            {
                isVerified = false;
                MessageBox.Show(error, "Invalid form");
            }
        }

        private void nameVerify(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "This is required!");
                isVerified = false;
            }
            else errorProvider1.Clear();
        }

        private void fullnameVerify(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                errorProvider1.SetError(txtFullname, "This is required!");
                isVerified = false;
            }
            else errorProvider1.Clear();
        }

        private void phoneVerify(object sender, EventArgs e)
        {
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
                    errorProvider1.SetError(txtPhone, "Invalid phone number format!");
                    isVerified = false;
                }
                else errorProvider1.Clear();
            }
        }

        private void addressVerify(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "This is required!");
                isVerified = false;
            }
            else errorProvider1.Clear();
        }

        private void passVerify(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "This is required!");
                isVerified = false;
            }
            else if (txtPass.Text.Length <= 3)
            {
                errorProvider1.SetError(txtPass, "Password must be longer than 3 characters!");
                isVerified = false;
            }
            else errorProvider1.Clear();
        }

        private void birthdayVerify(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - birthday.Value.Year < 5)
            {
                errorProvider1.SetError(birthday, "You have to be at least 5 years old to create account!");
                isVerified = false;
            }
            else errorProvider1.Clear();
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = show.Checked ? '\0' : '*';
        }
    }
}
