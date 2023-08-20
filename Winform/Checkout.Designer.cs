namespace Winform
{
    partial class Checkout
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
            txtID = new TextBox();
            label2 = new Label();
            txtquantity = new TextBox();
            cbRT = new ComboBox();
            label11 = new Label();
            txtPrice = new TextBox();
            label12 = new Label();
            txtstatus = new TextBox();
            label8 = new Label();
            txtcapacity = new TextBox();
            label7 = new Label();
            txtad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txthoteil = new TextBox();
            btnConfirm = new Button();
            dgvListProduct = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            dtCheckin = new DateTimePicker();
            dtCheckout = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label14 = new Label();
            txtPhone = new TextBox();
            label15 = new Label();
            txtName = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 389);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 75;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(110, 382);
            txtID.Name = "txtID";
            txtID.Size = new Size(277, 27);
            txtID.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 590);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 73;
            label2.Text = "Quantity";
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(541, 583);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(244, 27);
            txtquantity.TabIndex = 72;
            // 
            // cbRT
            // 
            cbRT.FormattingEnabled = true;
            cbRT.Location = new Point(110, 480);
            cbRT.Name = "cbRT";
            cbRT.Size = new Size(277, 28);
            cbRT.TabIndex = 71;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(449, 538);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 70;
            label11.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(541, 531);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(244, 27);
            txtPrice.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 488);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 68;
            label12.Text = "Status";
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(541, 481);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(244, 27);
            txtstatus.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 590);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 64;
            label8.Text = "Capacity";
            // 
            // txtcapacity
            // 
            txtcapacity.Location = new Point(110, 583);
            txtcapacity.Name = "txtcapacity";
            txtcapacity.Size = new Size(277, 27);
            txtcapacity.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 538);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 62;
            label7.Text = "Address";
            // 
            // txtad
            // 
            txtad.Location = new Point(110, 531);
            txtad.Name = "txtad";
            txtad.Size = new Size(277, 27);
            txtad.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 488);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 60;
            label6.Text = "RoomType";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 441);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 59;
            label5.Text = "Hoteil";
            // 
            // txthoteil
            // 
            txthoteil.Location = new Point(110, 434);
            txthoteil.Name = "txthoteil";
            txthoteil.Size = new Size(277, 27);
            txthoteil.TabIndex = 58;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(691, 698);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 57;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Location = new Point(12, 12);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 51;
            dgvListProduct.RowTemplate.Height = 29;
            dgvListProduct.Size = new Size(773, 364);
            dgvListProduct.TabIndex = 54;
            dgvListProduct.CellClick += dgvListProduct_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(878, 106);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 79;
            label1.Text = "CheckOut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(878, 61);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 77;
            label4.Text = "CheckIn";
            // 
            // dtCheckin
            // 
            dtCheckin.Location = new Point(972, 54);
            dtCheckin.Name = "dtCheckin";
            dtCheckin.Size = new Size(250, 27);
            dtCheckin.TabIndex = 80;
            // 
            // dtCheckout
            // 
            dtCheckout.Location = new Point(972, 99);
            dtCheckout.Name = "dtCheckout";
            dtCheckout.Size = new Size(250, 27);
            dtCheckout.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(791, 156);
            label9.Name = "label9";
            label9.Size = new Size(150, 20);
            label9.TabIndex = 82;
            label9.Text = "Ordering information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(791, 12);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 83;
            label10.Text = "Reservation time";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(880, 254);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 87;
            label14.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(972, 247);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(244, 27);
            txtPhone.TabIndex = 86;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(880, 209);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 85;
            label15.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(972, 202);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 84;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(929, 356);
            label17.Name = "label17";
            label17.Size = new Size(327, 20);
            label17.TabIndex = 89;
            label17.Text = "-----------------------------------------------------";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1080, 389);
            label18.Name = "label18";
            label18.Size = new Size(42, 20);
            label18.TabIndex = 90;
            label18.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(1080, 422);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(41, 20);
            txtTotal.TabIndex = 91;
            txtTotal.Text = "Price";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 788);
            Controls.Add(txtTotal);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(txtPhone);
            Controls.Add(label15);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtCheckout);
            Controls.Add(dtCheckin);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtquantity);
            Controls.Add(cbRT);
            Controls.Add(label11);
            Controls.Add(txtPrice);
            Controls.Add(label12);
            Controls.Add(txtstatus);
            Controls.Add(label8);
            Controls.Add(txtcapacity);
            Controls.Add(label7);
            Controls.Add(txtad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txthoteil);
            Controls.Add(btnConfirm);
            Controls.Add(dgvListProduct);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtID;
        private Label label2;
        private TextBox txtquantity;
        private ComboBox cbRT;
        private Label label11;
        private TextBox txtPrice;
        private Label label12;
        private TextBox txtstatus;
        private Label label8;
        private TextBox txtcapacity;
        private Label label7;
        private TextBox txtad;
        private Label label6;
        private Label label5;
        private TextBox txthoteil;
        private Button btnConfirm;
        private DataGridView dgvListProduct;
        private Label label1;
        private Label label4;
        private DateTimePicker dtCheckin;
        private DateTimePicker dtCheckout;
        private Label label9;
        private Label label10;
        private Label label14;
        private TextBox txtPhone;
        private Label label15;
        private TextBox txtName;
        private Label label17;
        private Label label18;
        private Label txtTotal;
    }
}