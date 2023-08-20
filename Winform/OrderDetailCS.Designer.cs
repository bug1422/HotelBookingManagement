namespace Winform
{
    partial class OrderDetailCS
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
            txtprice = new TextBox();
            txtflower = new TextBox();
            Exits = new Button();
            txtroomtype = new TextBox();
            txtquanity = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btncancel = new Button();
            dgvorderDetail = new DataGridView();
            label1 = new Label();
            dtcheckin = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            dtcheckout = new DateTimePicker();
            txtcustomername = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).BeginInit();
            SuspendLayout();
            // 
            // txtprice
            // 
            txtprice.Location = new Point(807, 423);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(306, 27);
            txtprice.TabIndex = 49;
            // 
            // txtflower
            // 
            txtflower.Location = new Point(807, 157);
            txtflower.Name = "txtflower";
            txtflower.Size = new Size(306, 27);
            txtflower.TabIndex = 48;
            // 
            // Exits
            // 
            Exits.Location = new Point(918, 539);
            Exits.Name = "Exits";
            Exits.Size = new Size(94, 29);
            Exits.TabIndex = 47;
            Exits.Text = "Exits";
            Exits.UseVisualStyleBackColor = true;
            Exits.Click += Exits_Click;
            // 
            // txtroomtype
            // 
            txtroomtype.Location = new Point(807, 220);
            txtroomtype.Name = "txtroomtype";
            txtroomtype.Size = new Size(306, 27);
            txtroomtype.TabIndex = 45;
            // 
            // txtquanity
            // 
            txtquanity.Location = new Point(807, 487);
            txtquanity.Name = "txtquanity";
            txtquanity.Size = new Size(306, 27);
            txtquanity.TabIndex = 44;
            // 
            // txtid
            // 
            txtid.Location = new Point(807, 50);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(306, 27);
            txtid.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(719, 227);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 42;
            label6.Text = "RoomType";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(719, 494);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 41;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(719, 430);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 40;
            label4.Text = "price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 164);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 39;
            label3.Text = "Hotel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(719, 57);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 38;
            label2.Text = "ID";
            // 
            // btncancel
            // 
            btncancel.Location = new Point(918, 539);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 37;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // dgvorderDetail
            // 
            dgvorderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorderDetail.Location = new Point(46, 50);
            dgvorderDetail.Name = "dgvorderDetail";
            dgvorderDetail.RowHeadersWidth = 51;
            dgvorderDetail.RowTemplate.Height = 29;
            dgvorderDetail.Size = new Size(631, 668);
            dgvorderDetail.TabIndex = 36;
            dgvorderDetail.CellClick += dgvorderDetail_CellClick;
            dgvorderDetail.CellContentClick += dgvorderDetail_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 35;
            label1.Text = "List Product";
            // 
            // dtcheckin
            // 
            dtcheckin.Location = new Point(807, 285);
            dtcheckin.Name = "dtcheckin";
            dtcheckin.Size = new Size(306, 27);
            dtcheckin.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(719, 290);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 51;
            label8.Text = "Checkin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(719, 362);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 53;
            label9.Text = "Checkout";
            // 
            // dtcheckout
            // 
            dtcheckout.Location = new Point(807, 357);
            dtcheckout.Name = "dtcheckout";
            dtcheckout.Size = new Size(306, 27);
            dtcheckout.TabIndex = 52;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(807, 108);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.ReadOnly = true;
            txtcustomername.Size = new Size(306, 27);
            txtcustomername.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(719, 115);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 54;
            label10.Text = "Customer";
            // 
            // OrderDetailCS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 730);
            Controls.Add(txtcustomername);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtcheckout);
            Controls.Add(label8);
            Controls.Add(dtcheckin);
            Controls.Add(txtprice);
            Controls.Add(txtflower);
            Controls.Add(Exits);
            Controls.Add(txtroomtype);
            Controls.Add(txtquanity);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncancel);
            Controls.Add(dgvorderDetail);
            Controls.Add(label1);
            Name = "OrderDetailCS";
            Text = "OrderDetailCS";
            Load += OrderDetailCS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtprice;
        private TextBox txtflower;
        private Button Exits;
        private TextBox txtdiscount;
        private TextBox txtquanity;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btncancel;
        private DataGridView dgvorderDetail;
        private Label label1;
        private DateTimePicker dtcheckin;
        private Label label8;
        private Label label9;
        private DateTimePicker dtcheckout;
        private TextBox txtcustomername;
        private Label label10;
        private TextBox txtroomtype;
    }
}