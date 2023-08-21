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
            txtOld = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtNew = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 224);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 23;
            label3.Text = "Old Password";
            // 
            // txtOld
            // 
            txtOld.Location = new Point(403, 218);
            txtOld.Margin = new Padding(3, 2, 3, 2);
            txtOld.Name = "txtOld";
            txtOld.PasswordChar = '*';
            txtOld.Size = new Size(316, 23);
            txtOld.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 164);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 21;
            label2.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(403, 159);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(316, 23);
            txtUserName.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(403, 345);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(636, 345);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 278);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 31;
            label1.Text = "New Password";
            // 
            // txtNew
            // 
            txtNew.Location = new Point(403, 278);
            txtNew.Margin = new Padding(3, 2, 3, 2);
            txtNew.Name = "txtNew";
            txtNew.PasswordChar = '*';
            txtNew.Size = new Size(316, 23);
            txtNew.TabIndex = 30;
            // 
            // SettingAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 511);
            Controls.Add(label1);
            Controls.Add(txtNew);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtOld);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingAccount";
            Text = "SettingAccount";
            Load += SettingAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtOld;
        private Label label2;
        private TextBox txtUserName;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label1;
        private TextBox txtNew;
    }
}