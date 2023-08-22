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
            homeBtn = new Button();
            panel1 = new Panel();
            roomBtn = new Button();
            panel3 = new Panel();
            profileBtn = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            logoutBtn = new Button();
            mainView = new Panel();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ControlLight;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(228, 724);
            sidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(homeBtn);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 110);
            panel2.TabIndex = 1;
            // 
            // homeBtn
            // 
            homeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.Image = Properties.Resources.home_icon;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Margin = new Padding(3, 2, 3, 2);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(225, 110);
            homeBtn.TabIndex = 3;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(roomBtn);
            panel1.Location = new Point(3, 116);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 110);
            panel1.TabIndex = 0;
            // 
            // roomBtn
            // 
            roomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomBtn.Image = Properties.Resources.hotel_icon;
            roomBtn.ImageAlign = ContentAlignment.MiddleLeft;
            roomBtn.Location = new Point(0, 0);
            roomBtn.Margin = new Padding(3, 2, 3, 2);
            roomBtn.Name = "roomBtn";
            roomBtn.Size = new Size(225, 110);
            roomBtn.TabIndex = 5;
            roomBtn.Text = "Hotel Management";
            roomBtn.TextAlign = ContentAlignment.MiddleRight;
            roomBtn.UseVisualStyleBackColor = true;
            roomBtn.Click += roomBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(profileBtn);
            panel3.Location = new Point(3, 230);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 110);
            panel3.TabIndex = 2;
            // 
            // profileBtn
            // 
            profileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profileBtn.Image = Properties.Resources.booking_icon;
            profileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            profileBtn.Location = new Point(0, 0);
            profileBtn.Margin = new Padding(3, 2, 3, 2);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(225, 112);
            profileBtn.TabIndex = 5;
            profileBtn.Text = "Booking Management";
            profileBtn.TextAlign = ContentAlignment.MiddleRight;
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(logoutBtn);
            panel4.Location = new Point(3, 344);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 110);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 458);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 110);
            panel5.TabIndex = 3;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutBtn.Image = Properties.Resources.logout_icon;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 2);
            logoutBtn.Margin = new Padding(3, 2, 3, 2);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(225, 108);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // mainView
            // 
            mainView.Dock = DockStyle.Fill;
            mainView.Location = new Point(228, 0);
            mainView.Margin = new Padding(3, 2, 3, 2);
            mainView.Name = "mainView";
            mainView.Size = new Size(812, 724);
            mainView.TabIndex = 3;
            mainView.Paint += mainView_Paint;
            // 
            // StaffMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 724);
            Controls.Add(mainView);
            Controls.Add(sidebar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            SizeChanged += CustomerMenu_SizeChanged;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button homeBtn;
        private Button profileBtn;
        private Button logoutBtn;
        private Button roomBtn;
        private Panel mainView;
    }
}