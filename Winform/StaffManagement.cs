using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Tools;
using Services.Repository;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform
{
    public partial class StaffManagement : Form
    {
        private AccountRepository _account = new AccountRepository();
        private RoleRepository _role = new RoleRepository();
        private int id = 0;
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _account.GetAll().Include(p => p.Role).Select(p => new
            {
                Id = p.Id,
                Role = p.Role.Name,
                Name = p.Name,
                Gender = p.Gender,
                DOB = p.Birthday.ToString(),
                Address = p.Address,
                Status = p.Status == 1 ? "Active" : "Deactivated"
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Account acc = _account.GetAll().FirstOrDefault(p => p.Id == id);

            textBox1.Text = acc.Id.ToString();

            textBox2.Text = acc.Username;

            comboBox1.SelectedIndex = acc.Status;

            textBox3.Text = acc.Phone;

            comboBox2.SelectedIndex = acc.Gender == "Male" ? 0 : 1;

            dateTimePicker1.Value = Convert.ToDateTime(acc.Birthday.ToString());

            textBox4.Text = acc.Address;

            textBox5.Text = acc.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to promote this user to staff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Account acc = _account.GetAll().FirstOrDefault(p => p.Id == id);
                        acc.Roleid = 3;
                        _account.Update(acc);
                        LoadData();
                        acc = new Account();
                        MessageBox.Show("Promote to staff successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't promote to staff! "+ ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to de change this user account status?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Account acc = _account.GetAll().FirstOrDefault(p => p.Id == id);
                        var b = acc.Status;
                        if (b == 1) acc.Status = 0;
                        else acc.Status = 1;
                        _account.Update(acc);
                        LoadData();
                        acc = new Account();
                        MessageBox.Show("De-active User(s)!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't change this user status! " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an account first!");

            }
        }
    }
}
