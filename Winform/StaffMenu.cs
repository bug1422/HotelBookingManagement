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
        Form statistics = new Statistics();
        Form hotel = new HotelManagement();
        Form user = new UserManagement();
        Form booking = new BookingManagement();
        public StaffMenu()
        {
            InitializeComponent();
            int width = this.Size.Width;
            int height = this.Size.Height;
            mainView.Width = width - sidebar.Width;
            mainView.Height = height;
            switchView("statistics");
        }
        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            setHighlight("statistics");
            switchView("statistics");
        }

        private void hotelBtn_Click(object sender, EventArgs e)
        {
            setHighlight("hotel");
            switchView("hotel");
        }

        private void userBtn_Click(object sender, EventArgs e)
        {

            setHighlight("user");
            switchView("user");
        }
        private void bookingBtn_Click(object sender, EventArgs e)
        {
            setHighlight("booking");
            switchView("booking");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void setHighlight(string s)
        {
            statisticsBtn.BackColor = Color.White;
            hotelBtn.BackColor = Color.White;
            userBtn.BackColor = Color.White;
            bookingBtn.BackColor = Color.White;
            switch (s)
            {
                case "statistics":
                    statisticsBtn.BackColor = Color.Gray;
                    break;
                case "hotel":
                    hotelBtn.BackColor = Color.Gray;
                    break;
                case "user":
                    userBtn.BackColor = Color.Gray;
                    break;
                case "booking":
                    bookingBtn.BackColor = Color.Gray;
                    break;
            }
        }

        private void switchView(string s)
        {
            Form f = new Form();
            switch (s)
            {
                case "statistics":
                    f = statistics;
                    break;
                case "hotel":
                    f = hotel;
                    break;
                case "user":
                    f = user;
                    break;
                case "booking":
                    f = booking;
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
    }
}
