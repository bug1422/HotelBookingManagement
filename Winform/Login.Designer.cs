namespace Winform
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            loginBtn = new Button();
            signupBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 36);
            label1.Name = "label1";
            label1.Size = new Size(470, 50);
            label1.TabIndex = 0;
            label1.Text = "HOTEL BOOKING SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 112);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 217);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(109, 260);
            txtName.Name = "txtName";
            txtName.Size = new Size(570, 36);
            txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(109, 155);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(570, 36);
            txtPass.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.AutoSize = true;
            loginBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(549, 316);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(130, 57);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.AutoSize = true;
            signupBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.Location = new Point(109, 316);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(130, 57);
            signupBtn.TabIndex = 6;
            signupBtn.Text = "Sign up";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 431);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Booking Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPass;
        private Button loginBtn;
        private Button signupBtn;
    }
}