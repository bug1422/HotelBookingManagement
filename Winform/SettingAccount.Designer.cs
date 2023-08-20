namespace Winform
{
    partial class SettingAccount
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
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtrepassword = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 298);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(461, 291);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 219);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 21;
            label2.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(461, 212);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(360, 27);
            txtUserName.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(461, 460);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(727, 460);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 378);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 31;
            label1.Text = "RE-Password";
            // 
            // txtrepassword
            // 
            txtrepassword.Location = new Point(461, 371);
            txtrepassword.Name = "txtrepassword";
            txtrepassword.PasswordChar = '*';
            txtrepassword.Size = new Size(360, 27);
            txtrepassword.TabIndex = 30;
            // 
            // SettingAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 681);
            Controls.Add(label1);
            Controls.Add(txtrepassword);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Name = "SettingAccount";
            Text = "SettingAccount";
            Load += SettingAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserName;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label1;
        private TextBox txtrepassword;
    }
}