using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Services.Models;
using Services.Repository;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Winform
{
    public partial class Profile : Form
    {
        private AccountRepository _account = new AccountRepository();
        Account aa = null;
        public Profile(Account a)
        {
            aa = a;
            InitializeComponent();
            txtName.Text = aa.Name;
            txtAddress.Text = aa.Address;
            txtPhone.Text = aa.Phone;
            dbBirth.Value = aa.Birthday.Value;
            if (aa.Gender.Equals("Male"))
            {
                cbmale.Checked = true;
            }
            if (aa.Gender.Equals("FeMale"))
            {
                cbfemale.Checked = true;
            }
            if (aa.Gender.Equals("None"))
            {
                cbnone.Checked = true;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
        private bool updateProfile(Account ac, int aid)
        {
            Account acc = _account.GetAll().Where(a => a.Id == aid).First();
            if (acc != null)
            {
                //acc.Name = ac.Name;
                //acc.Address = ac.Address;
                //acc.Phone = ac.Phone;
                //acc.Gender = ac.Gender;
                _account.Update(ac);
                return true;
            }

            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Please enter your name");
            }
            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Please enter your address");
            }
            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Please enter your phone");
            }
            if (cbmale.Checked == false && cbfemale.Checked == false && cbnone.Checked == false)
            {
                MessageBox.Show("Please choose gender");
            }
            else
            {
                string pattern = @"^0\d{2}-\d{3}-\d{4}$";
                DateTime.TryParse(dbBirth.Text, out DateTime birth);
                if (birth >= DateTime.Now)
                {
                    MessageBox.Show("gender must < date now");
                }
                if (!Regex.IsMatch(txtPhone.Text, pattern))
                {
                    MessageBox.Show("must format begin number 0 and fill 10 number: 0XX-XXX-XXXX");
                }
                else
                {
                    string gender = "";
                    if (cbmale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (cbfemale.Checked == true)
                    {
                        gender = "FeMale";
                    }
                    else if (cbnone.Checked == true)
                    {
                        gender = "None";
                    }

                    Account account = new Account() { Id = aa.Id, Username = aa.Username, Password = aa.Password, Status = aa.Status, Roleid = aa.Roleid, Phone = txtPhone.Text, Gender = gender, Birthday = birth, Address = txtAddress.Text, Name = txtName.Text };
                    bool updated = updateProfile(account, aa.Id);
                    if (updated)
                    {
                        MessageBox.Show("Update Profille Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Update Fail");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSettingAccount_Click(object sender, EventArgs e)
        {
            using (SettingAccount sett = new SettingAccount(aa))
            {
                DialogResult rs = sett.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    txtName.Text = aa.Name;
                    txtAddress.Text = aa.Address;
                    txtPhone.Text = aa.Phone;
                    dbBirth.Value = aa.Birthday.Value;
                    if (aa.Gender.Equals("Male"))
                    {
                        cbmale.Checked = true;
                    }
                    if (aa.Gender.Equals("FeMale"))
                    {
                        cbfemale.Checked = true;
                    }
                    if (aa.Gender.Equals("None"))
                    {
                        cbnone.Checked = true;
                    }
                }
            }
        }
    }
}
