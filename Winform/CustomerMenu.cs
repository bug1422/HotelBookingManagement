﻿using Services.Models;
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
    public partial class CustomerMenu : Form
    {
        Account account = new Account();
        Form home;
        Form rooms;
        Form profile;
        Form cart;
        List<Services.Models.Cart> carts = new List<Services.Models.Cart>();
        public CustomerMenu(Account ac)
        {

            account = ac;
            home = new Home(account);
            rooms = new Rooms(account);
            profile = new Profile(account);
            cart = new Cart(account);
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
            setHighlight("room");
            switchView("room");
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            setHighlight("profile");
            switchView("profile");
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            setHighlight("cart");
            switchView("cart");
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
            cartBtn.BackColor = Color.White;
            switch (s)
            {
                case "home":
                    homeBtn.BackColor = Color.Gray;
                    break;
                case "room":
                    roomBtn.BackColor = Color.Gray;
                    break;
                case "profile":
                    profileBtn.BackColor = Color.Gray;
                    break;
                case "cart":
                    cartBtn.BackColor = Color.Gray;
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
                case "room":
                    f = rooms;
                    break;
                case "profile":
                    f = profile;
                    break;
                case "cart":
                    f = cart;
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
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.Size = new Size(1530, 850);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                CenterToScreen();
            }
        }
    }
}
