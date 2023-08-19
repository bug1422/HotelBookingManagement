namespace Winform
{
    partial class StaffMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            statisticsBtn = new Button();
            panel1 = new Panel();
            hotelBtn = new Button();
            panel3 = new Panel();
            userBtn = new Button();
            panel4 = new Panel();
            bookingBtn = new Button();
            panel5 = new Panel();
            logoutBtn = new Button();
            mainView = new Panel();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            sidebar.BackColor = SystemColors.ControlLight;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "flowLayoutPanel1";
            sidebar.Size = new Size(260, 787);
            sidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(statisticsBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 147);
            panel2.TabIndex = 1;
            // 
            // statisticsBtn
            // 
            statisticsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statisticsBtn.Image = Properties.Resources.statistics_icon;
            statisticsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            statisticsBtn.Location = new Point(0, 0);
            statisticsBtn.Name = "statisticsBtn";
            statisticsBtn.Size = new Size(257, 147);
            statisticsBtn.TabIndex = 3;
            statisticsBtn.Text = "Statistics";
            statisticsBtn.UseVisualStyleBackColor = true;
            statisticsBtn.Click += statisticsBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(hotelBtn);
            panel1.Location = new Point(3, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 147);
            panel1.TabIndex = 0;
            // 
            // hotelBtn
            // 
            hotelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hotelBtn.Image = Properties.Resources.hotel_icon;
            hotelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            hotelBtn.Location = new Point(0, 0);
            hotelBtn.Name = "hotelBtn";
            hotelBtn.Size = new Size(257, 147);
            hotelBtn.TabIndex = 5;
            hotelBtn.Text = "Hotel Management";
            hotelBtn.TextAlign = ContentAlignment.MiddleRight;
            hotelBtn.UseVisualStyleBackColor = true;
            hotelBtn.Click += hotelBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(userBtn);
            panel3.Location = new Point(3, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 147);
            panel3.TabIndex = 2;
            // 
            // userBtn
            // 
            userBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userBtn.Image = Properties.Resources.profile_icon;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(0, 0);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(257, 150);
            userBtn.TabIndex = 5;
            userBtn.Text = "User Management";
            userBtn.TextAlign = ContentAlignment.MiddleRight;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bookingBtn);
            panel4.Location = new Point(3, 462);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 147);
            panel4.TabIndex = 1;
            // 
            // bookingBtn
            // 
            bookingBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookingBtn.Image = Properties.Resources.booking_icon;
            bookingBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bookingBtn.Location = new Point(0, 0);
            bookingBtn.Name = "bookingBtn";
            bookingBtn.Size = new Size(257, 147);
            bookingBtn.TabIndex = 4;
            bookingBtn.Text = "Booking Management";
            bookingBtn.TextAlign = ContentAlignment.MiddleRight;
            bookingBtn.UseVisualStyleBackColor = true;
            bookingBtn.Click += bookingBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(logoutBtn);
            panel5.Location = new Point(3, 615);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 147);
            panel5.TabIndex = 3;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutBtn.Image = Properties.Resources.logout_icon;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 3);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(257, 144);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // mainView
            // 
            mainView.Location = new Point(258, 0);
            mainView.Name = "mainView";
            mainView.Size = new Size(847, 787);
            mainView.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1103, 787);
            Controls.Add(mainView);
            Controls.Add(sidebar);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button statisticsBtn;
        private Button bookingBtn;
        private Button userBtn;
        private Button logoutBtn;
        private Button hotelBtn;
        private Panel mainView;
    }
}