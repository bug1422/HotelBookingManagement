namespace Winform
{
    partial class Home
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
            lbWelcome = new Label();
            txtAddress = new TextBox();
            dtCheckin = new DateTimePicker();
            dtCheckout = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnFind = new Button();
            gbfind = new GroupBox();
            dgvProduct = new DataGridView();
            lbCount = new Label();
            cbSort = new ComboBox();
            cbCate = new ComboBox();
            btncate = new Button();
            btnSort = new Button();
            txtID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txthoteil = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtad = new TextBox();
            label8 = new Label();
            txtcapacity = new TextBox();
            label11 = new Label();
            txtPrice = new TextBox();
            label12 = new Label();
            txtstatus = new TextBox();
            label13 = new Label();
            txtrating = new TextBox();
            cbRT = new ComboBox();
            btnViewDetail = new Button();
            btnOrder = new Button();
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
            label1.Size = new Size(127, 50);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Location = new Point(1037, 24);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(71, 20);
            lbWelcome.TabIndex = 2;
            lbWelcome.Text = "Welcome";
            lbWelcome.Click += lbWelcome_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(60, 49);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 27);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "Where";
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
            dtCheckout.Size = new Size(240, 27);
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
            gbfind.Controls.Add(dtCheckout);
            gbfind.Controls.Add(btnFind);
            gbfind.Controls.Add(txtAddress);
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
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 220);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(1220, 273);
            dgvProduct.TabIndex = 10;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Location = new Point(12, 197);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(234, 20);
            lbCount.TabIndex = 11;
            lbCount.Text = "There are 5 suitable hotels for you";
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(1028, 186);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(151, 28);
            cbSort.TabIndex = 12;
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Location = new Point(740, 186);
            cbCate.Name = "cbCate";
            cbCate.Size = new Size(163, 28);
            cbCate.TabIndex = 14;
            // 
            // btncate
            // 
            btncate.Location = new Point(909, 185);
            btncate.Name = "btncate";
            btncate.Size = new Size(83, 28);
            btncate.TabIndex = 15;
            btncate.Text = "Category";
            btncate.UseVisualStyleBackColor = true;
            btncate.Click += btncate_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(1180, 186);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(52, 29);
            btnSort.TabIndex = 16;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 531);
            txtID.Name = "txtID";
            txtID.Size = new Size(277, 27);
            txtID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 538);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 18;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 583);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 20;
            label5.Text = "Hoteil";
            // 
            // txthoteil
            // 
            txthoteil.Location = new Point(169, 576);
            txthoteil.Name = "txthoteil";
            txthoteil.Size = new Size(277, 27);
            txthoteil.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 630);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 22;
            label6.Text = "RoomType";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 680);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 24;
            label7.Text = "Address";
            // 
            // txtad
            // 
            txtad.Location = new Point(169, 673);
            txtad.Name = "txtad";
            txtad.Size = new Size(277, 27);
            txtad.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 732);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 26;
            label8.Text = "Capacity";
            // 
            // txtcapacity
            // 
            txtcapacity.Location = new Point(169, 725);
            txtcapacity.Name = "txtcapacity";
            txtcapacity.Size = new Size(277, 27);
            txtcapacity.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(507, 637);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 32;
            label11.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(599, 630);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(507, 590);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 30;
            label12.Text = "Status";
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(599, 583);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(277, 27);
            txtstatus.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(507, 545);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 28;
            label13.Text = "Rating";
            // 
            // txtrating
            // 
            txtrating.Location = new Point(599, 538);
            txtrating.Name = "txtrating";
            txtrating.Size = new Size(277, 27);
            txtrating.TabIndex = 27;
            // 
            // cbRT
            // 
            cbRT.FormattingEnabled = true;
            cbRT.Location = new Point(169, 622);
            cbRT.Name = "cbRT";
            cbRT.Size = new Size(277, 28);
            cbRT.TabIndex = 33;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(1028, 537);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(139, 28);
            btnViewDetail.TabIndex = 34;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(1025, 590);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(142, 29);
            btnOrder.TabIndex = 102;
            btnOrder.Text = "View Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 815);
            Controls.Add(btnOrder);
            Controls.Add(btnViewDetail);
            Controls.Add(cbRT);
            Controls.Add(label11);
            Controls.Add(txtPrice);
            Controls.Add(label12);
            Controls.Add(txtstatus);
            Controls.Add(label13);
            Controls.Add(txtrating);
            Controls.Add(label8);
            Controls.Add(txtcapacity);
            Controls.Add(label7);
            Controls.Add(txtad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txthoteil);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(btnSort);
            Controls.Add(btncate);
            Controls.Add(cbCate);
            Controls.Add(cbSort);
            Controls.Add(lbCount);
            Controls.Add(dgvProduct);
            Controls.Add(gbfind);
            Controls.Add(lbWelcome);
            Controls.Add(label1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            gbfind.ResumeLayout(false);
            gbfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbWelcome;
        private TextBox txtAddress;
        private DateTimePicker dtCheckin;
        private DateTimePicker dtCheckout;
        private Label label2;
        private Label label3;
        private Button btnFind;
        private GroupBox gbfind;
        private DataGridView dgvProduct;
        private Label lbCount;
        private ComboBox cbSort;
        private ComboBox cbCate;
        private Button btncate;
        private Button btnSort;
        private TextBox txtID;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
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
        private TextBox txthoteil;
        private TextBox txtad;
        private TextBox txtcapacity;
        private TextBox txtPrice;
        private TextBox txtstatus;
        private TextBox txtrating;
        private ComboBox cbRT;
        private Button btnViewDetail;
        private Button btnOrder;
    }
}