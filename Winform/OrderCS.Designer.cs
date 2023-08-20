namespace Winform
{
    partial class OrderCS
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
            btnUpdate = new Button();
            txtorderdate = new DateTimePicker();
            txtcsname = new TextBox();
            txtstatus = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btncancel = new Button();
            dgvorder = new DataGridView();
            label1 = new Label();
            btnviewdetail = new Button();
            txthotel = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvorder).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1012, 408);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtorderdate
            // 
            txtorderdate.Location = new Point(801, 234);
            txtorderdate.Name = "txtorderdate";
            txtorderdate.Size = new Size(305, 27);
            txtorderdate.TabIndex = 30;
            // 
            // txtcsname
            // 
            txtcsname.Location = new Point(801, 349);
            txtcsname.Name = "txtcsname";
            txtcsname.Size = new Size(306, 27);
            txtcsname.TabIndex = 29;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(801, 291);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(306, 27);
            txtstatus.TabIndex = 28;
            // 
            // txtid
            // 
            txtid.Location = new Point(800, 134);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(306, 27);
            txtid.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(713, 356);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 26;
            label6.Text = "CS Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(713, 298);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 25;
            label5.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(712, 241);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 23;
            label3.Text = "Order Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 141);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 22;
            label2.Text = "ID";
            // 
            // btncancel
            // 
            btncancel.Location = new Point(801, 408);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 21;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // dgvorder
            // 
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Location = new Point(39, 50);
            dgvorder.Name = "dgvorder";
            dgvorder.RowHeadersWidth = 51;
            dgvorder.RowTemplate.Height = 29;
            dgvorder.Size = new Size(631, 700);
            dgvorder.TabIndex = 20;
            dgvorder.CellClick += dgvorder_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 13);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 19;
            label1.Text = "Order Management";
            // 
            // btnviewdetail
            // 
            btnviewdetail.Location = new Point(712, 50);
            btnviewdetail.Name = "btnviewdetail";
            btnviewdetail.Size = new Size(94, 29);
            btnviewdetail.TabIndex = 18;
            btnviewdetail.Text = "View Detail";
            btnviewdetail.UseVisualStyleBackColor = true;
            btnviewdetail.Click += btnviewdetail_Click;
            // 
            // txthotel
            // 
            txthotel.Location = new Point(801, 183);
            txthotel.Name = "txthotel";
            txthotel.ReadOnly = true;
            txthotel.Size = new Size(306, 27);
            txthotel.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(713, 190);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 35;
            label8.Text = "Hotel";
            // 
            // OrderCS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 774);
            Controls.Add(txthotel);
            Controls.Add(label8);
            Controls.Add(btnUpdate);
            Controls.Add(txtorderdate);
            Controls.Add(txtcsname);
            Controls.Add(txtstatus);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncancel);
            Controls.Add(dgvorder);
            Controls.Add(label1);
            Controls.Add(btnviewdetail);
            Name = "OrderCS";
            Text = "OrderCS";
            Load += OrderCS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private DateTimePicker txtorderdate;
        private TextBox txtcsname;
        private TextBox txtstatus;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btncancel;
        private DataGridView dgvorder;
        private Label label1;
        private Button btnviewdetail;
        private TextBox txthotel;
        private Label label8;
    }
}