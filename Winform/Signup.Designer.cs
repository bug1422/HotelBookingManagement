namespace Winform
{
    partial class Signup
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
            components = new System.ComponentModel.Container();
            loginBtn = new Button();
            txtPass = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            signupBtn = new Button();
            txtPhone = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtFullname = new TextBox();
            label6 = new Label();
            label7 = new Label();
            gender = new ComboBox();
            birthday = new DateTimePicker();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            show = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(757, 372);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(130, 57);
            loginBtn.TabIndex = 11;
            loginBtn.Text = "Submit";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(12, 308);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(668, 36);
            txtPass.TabIndex = 10;
            txtPass.Leave += passVerify;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(12, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 36);
            txtName.TabIndex = 9;
            txtName.Leave += nameVerify;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 275);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 50);
            label1.TabIndex = 13;
            label1.Text = "Creating account";
            // 
            // signupBtn
            // 
            signupBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.Location = new Point(12, 372);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(130, 57);
            signupBtn.TabIndex = 12;
            signupBtn.Text = "Back";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(12, 209);
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '*';
            txtPhone.Size = new Size(317, 36);
            txtPhone.TabIndex = 15;
            txtPhone.Leave += phoneVerify;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(156, 30);
            label4.TabIndex = 14;
            label4.Text = "Phone number";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(344, 209);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(336, 36);
            txtAddress.TabIndex = 17;
            txtAddress.Leave += addressVerify;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(344, 176);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 16;
            label5.Text = "Address";
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(262, 116);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(418, 36);
            txtFullname.TabIndex = 19;
            txtFullname.Leave += fullnameVerify;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(262, 83);
            label6.Name = "label6";
            label6.Size = new Size(106, 30);
            label6.TabIndex = 18;
            label6.Text = "Full name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(695, 81);
            label7.Name = "label7";
            label7.Size = new Size(85, 30);
            label7.TabIndex = 20;
            label7.Text = "Gender";
            // 
            // gender
            // 
            gender.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            gender.Location = new Point(695, 114);
            gender.Name = "gender";
            gender.Size = new Size(160, 38);
            gender.TabIndex = 21;
            // 
            // birthday
            // 
            birthday.CustomFormat = "dd/MM/yyyy";
            birthday.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            birthday.Format = DateTimePickerFormat.Custom;
            birthday.Location = new Point(695, 209);
            birthday.Name = "birthday";
            birthday.Size = new Size(160, 36);
            birthday.TabIndex = 22;
            birthday.ValueChanged += birthdayVerify;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(695, 176);
            label8.Name = "label8";
            label8.Size = new Size(93, 30);
            label8.TabIndex = 23;
            label8.Text = "Birthday";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            show.Location = new Point(121, 278);
            show.Name = "show";
            show.Size = new Size(165, 29);
            show.TabIndex = 24;
            show.Text = "Show password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 441);
            Controls.Add(show);
            Controls.Add(label8);
            Controls.Add(birthday);
            Controls.Add(gender);
            Controls.Add(label7);
            Controls.Add(txtFullname);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Booking Management";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginBtn;
        private TextBox txtPass;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button signupBtn;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtFullname;
        private Label label6;
        private Label label7;
        private ComboBox gender;
        private DateTimePicker birthday;
        private Label label8;
        private ErrorProvider errorProvider1;
        private CheckBox show;
    }
}