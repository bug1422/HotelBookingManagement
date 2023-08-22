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
using Winform.Staff;

namespace Winform
{
    public partial class StaffMenu : Form
    {
        Account account = new Account();
        Form home;
        Form hotel;
        Form bookings;
        public StaffMenu(Account ac)
        {

            account = ac;
            home = new StaffHome(account);
            hotel = new HotelManagement(account);
            bookings = new BookingManagement(account);
            InitializeComponent();
            int width = this.Size.Width;
            int height = this.Size.Height;
            mainView.Width = width - sidebar.Width;
            mainView.Height = height;
            switchView("home");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            setHighlight("home");
            switchView("home");
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            setHighlight("hotel");
            switchView("hotel");
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            setHighlight("bookings");
            switchView("bookings");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void setHighlight(string s)
        {
            homeBtn.BackColor = Color.White;
            roomBtn.BackColor = Color.White;
            profileBtn.BackColor = Color.White;
            switch (s)
            {
                case "home":
                    homeBtn.BackColor = Color.Gray;
                    break;
                case "hotel":
                    roomBtn.BackColor = Color.Gray;
                    break;
                case "bookings":
                    profileBtn.BackColor = Color.Gray;
                    break;
            }
        }

        private void switchView(string s)
        {
            Form f = new Form();
            switch (s)
            {
                case "home":
                    f = home;
                    break;
                case "hotel":
                    f = hotel;
                    break;
                case "bookings":
                    f = bookings;
                    break;
            }
            f.TopLevel = false;
            f.AutoSize = true;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.CenterParent;
            mainView.Controls.Clear();
            mainView.Controls.Add(f);
            f.Show();
        }

        private void mainView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerMenu_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Size = new Size(1530, 850);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                CenterToScreen();
            }
        }
    }
}
