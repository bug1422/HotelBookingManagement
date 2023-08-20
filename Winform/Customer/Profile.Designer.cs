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
            btnCancel = new Button();
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
            label1.Size = new Size(138, 50);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // txtName
            // 
            txtName.Location = new Point(420, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 167);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 213);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(420, 206);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(360, 27);
            txtAddress.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 269);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(420, 262);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(360, 27);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 325);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 378);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 11;
            label6.Text = "Birth";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(420, 447);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(686, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbmale
            // 
            cbmale.AutoSize = true;
            cbmale.Location = new Point(420, 325);
            cbmale.Name = "cbmale";
            cbmale.Size = new Size(64, 24);
            cbmale.TabIndex = 16;
            cbmale.Text = "Male";
            cbmale.UseVisualStyleBackColor = true;
            // 
            // cbfemale
            // 
            cbfemale.AutoSize = true;
            cbfemale.Location = new Point(547, 325);
            cbfemale.Name = "cbfemale";
            cbfemale.Size = new Size(79, 24);
            cbfemale.TabIndex = 17;
            cbfemale.Text = "Female";
            cbfemale.UseVisualStyleBackColor = true;
            // 
            // cbnone
            // 
            cbnone.AutoSize = true;
            cbnone.Location = new Point(679, 325);
            cbnone.Name = "cbnone";
            cbnone.Size = new Size(67, 24);
            cbnone.TabIndex = 18;
            cbnone.Text = "None";
            cbnone.UseVisualStyleBackColor = true;
            // 
            // dbBirth
            // 
            dbBirth.Location = new Point(420, 373);
            dbBirth.Name = "dbBirth";
            dbBirth.Size = new Size(360, 27);
            dbBirth.TabIndex = 19;
            // 
            // btnSettingAccount
            // 
            btnSettingAccount.Location = new Point(12, 63);
            btnSettingAccount.Name = "btnSettingAccount";
            btnSettingAccount.Size = new Size(140, 29);
            btnSettingAccount.TabIndex = 20;
            btnSettingAccount.Text = "Setting Account";
            btnSettingAccount.UseVisualStyleBackColor = true;
            btnSettingAccount.Click += btnSettingAccount_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 762);
            Controls.Add(btnSettingAccount);
            Controls.Add(dbBirth);
            Controls.Add(cbnone);
            Controls.Add(cbfemale);
            Controls.Add(cbmale);
            Controls.Add(btnCancel);
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
        private Button btnCancel;
        private CheckBox cbmale;
        private CheckBox cbfemale;
        private CheckBox cbnone;
        private DateTimePicker dbBirth;
        private Button btnSettingAccount;
    }
}