namespace Winform
{
    partial class Rooms
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
            dtCheckin = new DateTimePicker();
            dtCheckout = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnFind = new Button();
            gbfind = new GroupBox();
            label9 = new Label();
            address = new ComboBox();
            dgvProduct = new DataGridView();
            lbCount = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtHotel = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtCapacity = new TextBox();
            label11 = new Label();
            txtPrice = new TextBox();
            label12 = new Label();
            txtStatus = new TextBox();
            label13 = new Label();
            bookBtn = new Button();
            addBtn = new Button();
            txtRating = new Label();
            txtType = new TextBox();
            detailBtn = new Button();
            gbfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 50);
            label1.TabIndex = 0;
            label1.Text = "Available room";
            // 
            // dtCheckin
            // 
            dtCheckin.Location = new Point(392, 47);
            dtCheckin.Name = "dtCheckin";
            dtCheckin.Size = new Size(242, 27);
            dtCheckin.TabIndex = 4;
            // 
            // dtCheckout
            // 
            dtCheckout.Location = new Point(654, 47);
            dtCheckout.Name = "dtCheckout";
            dtCheckout.Size = new Size(239, 27);
            dtCheckout.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 24);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "CheckIn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 24);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "CheckOut";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(921, 47);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // gbfind
            // 
            gbfind.BackColor = SystemColors.ActiveCaption;
            gbfind.Controls.Add(label9);
            gbfind.Controls.Add(address);
            gbfind.Controls.Add(dtCheckout);
            gbfind.Controls.Add(btnFind);
            gbfind.Controls.Add(label3);
            gbfind.Controls.Add(dtCheckin);
            gbfind.Controls.Add(label2);
            gbfind.Location = new Point(86, 75);
            gbfind.Name = "gbfind";
            gbfind.Size = new Size(1051, 99);
            gbfind.TabIndex = 9;
            gbfind.TabStop = false;
            gbfind.Enter += gbfind_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 21);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 10;
            label9.Text = "Address";
            // 
            // address
            // 
            address.FormattingEnabled = true;
            address.Location = new Point(35, 45);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(316, 28);
            address.TabIndex = 9;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(6, 223);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(1221, 273);
            dgvProduct.TabIndex = 10;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Location = new Point(11, 197);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(234, 20);
            lbCount.TabIndex = 11;
            lbCount.Text = "There are 5 suitable hotels for you";
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 531);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 531);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 18;
            label4.Text = "Room name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 576);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 20;
            label5.Text = "Hotel";
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(169, 576);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(277, 27);
            txtHotel.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 531);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 22;
            label6.Text = "RoomType";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 629);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 24;
            label7.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(169, 629);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(277, 27);
            txtAddress.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 680);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 26;
            label8.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(169, 680);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(277, 27);
            txtCapacity.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(507, 576);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 32;
            label11.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(599, 576);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(507, 629);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 30;
            label12.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(599, 629);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(277, 27);
            txtStatus.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(507, 673);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 28;
            label13.Text = "Rating";
            // 
            // bookBtn
            // 
            bookBtn.Location = new Point(1007, 516);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(161, 112);
            bookBtn.TabIndex = 34;
            bookBtn.Text = "Book this room";
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1007, 673);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(164, 113);
            addBtn.TabIndex = 102;
            addBtn.Text = "Add to cart";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // txtRating
            // 
            txtRating.AutoSize = true;
            txtRating.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRating.Location = new Point(599, 673);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(70, 30);
            txtRating.TabIndex = 104;
            txtRating.Text = "0/5 ☆";
            // 
            // txtType
            // 
            txtType.Location = new Point(599, 531);
            txtType.Name = "txtType";
            txtType.Size = new Size(277, 27);
            txtType.TabIndex = 105;
            // 
            // detailBtn
            // 
            detailBtn.Location = new Point(169, 724);
            detailBtn.Name = "detailBtn";
            detailBtn.Size = new Size(179, 67);
            detailBtn.TabIndex = 109;
            detailBtn.Text = "View more details";
            detailBtn.UseVisualStyleBackColor = true;
            detailBtn.Click += detailBtn_Click;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 815);
            Controls.Add(detailBtn);
            Controls.Add(txtType);
            Controls.Add(txtRating);
            Controls.Add(addBtn);
            Controls.Add(bookBtn);
            Controls.Add(label11);
            Controls.Add(txtPrice);
            Controls.Add(label12);
            Controls.Add(txtStatus);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(txtCapacity);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHotel);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(lbCount);
            Controls.Add(dgvProduct);
            Controls.Add(gbfind);
            Controls.Add(label1);
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            gbfind.ResumeLayout(false);
            gbfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtCheckin;
        private DateTimePicker dtCheckout;
        private Label label2;
        private Label label3;
        private Button btnFind;
        private GroupBox gbfind;
        private DataGridView dgvProduct;
        private Label lbCount;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox txtType;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private ComboBox cbRoomType;
        private TextBox txtHotel;
        private TextBox txtAddress;
        private TextBox txtCapacity;
        private TextBox txtPrice;
        private TextBox txtStatus;
        private Button bookBtn;
        private Button addBtn;
        private ComboBox address;
        private Label label9;
        private Label txtRating;
        private Button detailBtn;
    }
}