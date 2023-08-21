namespace Winform
{
    partial class CustomerMenu
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
            cartBtn = new Button();
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
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(260, 966);
            sidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(homeBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 147);
            panel2.TabIndex = 1;
            // 
            // homeBtn
            // 
            homeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.Image = Properties.Resources.home_icon;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(257, 147);
            homeBtn.TabIndex = 3;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(roomBtn);
            panel1.Location = new Point(3, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 147);
            panel1.TabIndex = 0;
            // 
            // roomBtn
            // 
            roomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomBtn.Image = Properties.Resources.list_icon;
            roomBtn.ImageAlign = ContentAlignment.MiddleLeft;
            roomBtn.Location = new Point(0, 0);
            roomBtn.Name = "roomBtn";
            roomBtn.Size = new Size(257, 147);
            roomBtn.TabIndex = 5;
            roomBtn.Text = "Available Room";
            roomBtn.TextAlign = ContentAlignment.MiddleRight;
            roomBtn.UseVisualStyleBackColor = true;
            roomBtn.Click += roomBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(profileBtn);
            panel3.Location = new Point(3, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 147);
            panel3.TabIndex = 2;
            // 
            // profileBtn
            // 
            profileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profileBtn.Image = Properties.Resources.profile_icon;
            profileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            profileBtn.Location = new Point(0, 0);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(257, 150);
            profileBtn.TabIndex = 5;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cartBtn);
            panel4.Location = new Point(3, 462);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 147);
            panel4.TabIndex = 1;
            // 
            // cartBtn
            // 
            cartBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cartBtn.Image = Properties.Resources.cart_icon;
            cartBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cartBtn.Location = new Point(0, 0);
            cartBtn.Name = "cartBtn";
            cartBtn.Size = new Size(257, 147);
            cartBtn.TabIndex = 4;
            cartBtn.Text = "Cart";
            cartBtn.UseVisualStyleBackColor = true;
            cartBtn.Click += cartBtn_Click;
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
            logoutBtn.Location = new Point(0, 0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(257, 144);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // mainView
            // 
            mainView.Dock = DockStyle.Fill;
            mainView.Location = new Point(260, 0);
            mainView.Name = "mainView";
            mainView.Size = new Size(928, 966);
            mainView.TabIndex = 3;
            mainView.Paint += mainView_Paint;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1188, 966);
            Controls.Add(mainView);
            Controls.Add(sidebar);
            Name = "CustomerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            SizeChanged += CustomerMenu_SizeChanged;
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
        private Button homeBtn;
        private Button cartBtn;
        private Button profileBtn;
        private Button logoutBtn;
        private Button roomBtn;
        private Panel mainView;
    }
}