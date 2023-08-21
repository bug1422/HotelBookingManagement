namespace Winform
{
    partial class Profile
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            cbmale = new CheckBox();
            cbfemale = new CheckBox();
            cbnone = new CheckBox();
            dbBirth = new DateTimePicker();
            btnSettingAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 41);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // txtName
            // 
            txtName.Location = new Point(368, 120);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 125);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 160);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(368, 154);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 23);
            txtAddress.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 202);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(368, 196);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(316, 23);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 244);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 284);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "Birth";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(602, 339);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbmale
            // 
            cbmale.AutoSize = true;
            cbmale.Location = new Point(368, 244);
            cbmale.Margin = new Padding(3, 2, 3, 2);
            cbmale.Name = "cbmale";
            cbmale.Size = new Size(52, 19);
            cbmale.TabIndex = 16;
            cbmale.Text = "Male";
            cbmale.UseVisualStyleBackColor = true;
            // 
            // cbfemale
            // 
            cbfemale.AutoSize = true;
            cbfemale.Location = new Point(479, 244);
            cbfemale.Margin = new Padding(3, 2, 3, 2);
            cbfemale.Name = "cbfemale";
            cbfemale.Size = new Size(64, 19);
            cbfemale.TabIndex = 17;
            cbfemale.Text = "Female";
            cbfemale.UseVisualStyleBackColor = true;
            // 
            // cbnone
            // 
            cbnone.AutoSize = true;
            cbnone.Location = new Point(594, 244);
            cbnone.Margin = new Padding(3, 2, 3, 2);
            cbnone.Name = "cbnone";
            cbnone.Size = new Size(55, 19);
            cbnone.TabIndex = 18;
            cbnone.Text = "None";
            cbnone.UseVisualStyleBackColor = true;
            // 
            // dbBirth
            // 
            dbBirth.Location = new Point(368, 280);
            dbBirth.Margin = new Padding(3, 2, 3, 2);
            dbBirth.Name = "dbBirth";
            dbBirth.Size = new Size(316, 23);
            dbBirth.TabIndex = 19;
            // 
            // btnSettingAccount
            // 
            btnSettingAccount.Location = new Point(368, 339);
            btnSettingAccount.Margin = new Padding(3, 2, 3, 2);
            btnSettingAccount.Name = "btnSettingAccount";
            btnSettingAccount.Size = new Size(122, 22);
            btnSettingAccount.TabIndex = 20;
            btnSettingAccount.Text = "Change Password";
            btnSettingAccount.UseVisualStyleBackColor = true;
            btnSettingAccount.Click += btnSettingAccount_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 572);
            Controls.Add(btnSettingAccount);
            Controls.Add(dbBirth);
            Controls.Add(cbnone);
            Controls.Add(cbfemale);
            Controls.Add(cbmale);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
        private CheckBox cbmale;
        private CheckBox cbfemale;
        private CheckBox cbnone;
        private DateTimePicker dbBirth;
        private Button btnSettingAccount;
    }
}