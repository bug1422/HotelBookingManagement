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
            txtRoomName = new TextBox();
            label11 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            txtCapacity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtHotel = new TextBox();
            btnConfirm = new Button();
            dgvListProduct = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            dtCheckin = new DateTimePicker();
            dtCheckout = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label17 = new Label();
            totalLabel = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            cardOwner = new TextBox();
            payNameLabel = new Label();
            cardNumber = new TextBox();
            payInAdvance = new Panel();
            txtType = new TextBox();
            backBtn = new Button();
            removeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            payInAdvance.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 389);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 75;
            label3.Text = "Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(110, 382);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(277, 27);
            txtRoomName.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(425, 441);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 70;
            label11.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(517, 434);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(244, 27);
            txtPrice.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 495);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 64;
            label8.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(110, 488);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(277, 27);
            txtCapacity.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 389);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 60;
            label6.Text = "Room Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 441);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 59;
            label5.Text = "Hotel";
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(110, 434);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(277, 27);
            txtHotel.TabIndex = 58;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(590, 555);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(171, 65);
            btnConfirm.TabIndex = 57;
            btnConfirm.Text = "Confirm booking";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dgvListProduct
            // 
            dgvListProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(856, 356);
            label17.Name = "label17";
            label17.Size = new Size(327, 20);
            label17.TabIndex = 89;
            label17.Text = "-----------------------------------------------------";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(812, 376);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(134, 30);
            totalLabel.TabIndex = 90;
            totalLabel.Text = "Total price: ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(881, 180);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 24);
            checkBox1.TabIndex = 92;
            checkBox1.Text = "Pay in advance";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 96;
            label2.Text = "Card Owner";
            // 
            // cardOwner
            // 
            cardOwner.Location = new Point(148, 78);
            cardOwner.Name = "cardOwner";
            cardOwner.PlaceholderText = "NGUYEN VAN A";
            cardOwner.Size = new Size(244, 27);
            cardOwner.TabIndex = 95;
            cardOwner.TextChanged += textBox1_TextChanged;
            // 
            // payNameLabel
            // 
            payNameLabel.AutoSize = true;
            payNameLabel.Location = new Point(31, 33);
            payNameLabel.Name = "payNameLabel";
            payNameLabel.Size = new Size(95, 20);
            payNameLabel.TabIndex = 94;
            payNameLabel.Text = "Card number";
            // 
            // cardNumber
            // 
            cardNumber.Location = new Point(148, 33);
            cardNumber.Name = "cardNumber";
            cardNumber.PlaceholderText = "1234-5678-7890-1011";
            cardNumber.Size = new Size(244, 27);
            cardNumber.TabIndex = 93;
            cardNumber.TextChanged += cardNumber_TextChanged;
            cardNumber.KeyDown += cardNumber_KeyDown;
            // 
            // payInAdvance
            // 
            payInAdvance.Controls.Add(cardOwner);
            payInAdvance.Controls.Add(label2);
            payInAdvance.Controls.Add(cardNumber);
            payInAdvance.Controls.Add(payNameLabel);
            payInAdvance.Location = new Point(825, 210);
            payInAdvance.Name = "payInAdvance";
            payInAdvance.Size = new Size(461, 133);
            payInAdvance.TabIndex = 97;
            // 
            // txtType
            // 
            txtType.Location = new Point(517, 382);
            txtType.Name = "txtType";
            txtType.Size = new Size(244, 27);
            txtType.TabIndex = 98;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 555);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(171, 65);
            backBtn.TabIndex = 99;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(295, 555);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(171, 65);
            removeBtn.TabIndex = 100;
            removeBtn.Text = "Remove room from list";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 632);
            Controls.Add(removeBtn);
            Controls.Add(backBtn);
            Controls.Add(txtType);
            Controls.Add(payInAdvance);
            Controls.Add(checkBox1);
            Controls.Add(totalLabel);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtCheckout);
            Controls.Add(dtCheckin);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRoomName);
            Controls.Add(label11);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(txtCapacity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHotel);
            Controls.Add(btnConfirm);
            Controls.Add(dgvListProduct);
            Name = "Checkout";
            Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            payInAdvance.ResumeLayout(false);
            payInAdvance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtRoomName;
        private Label label11;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txtCapacity;
        private Label label6;
        private Label label5;
        private TextBox txtHotel;
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
        private Label totalLabel;
        private Label txtTotal;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox cardOwner;
        private Label payNameLabel;
        private TextBox cardNumber;
        private Panel payInAdvance;
        private TextBox txtType;
        private Button backBtn;
        private Button removeBtn;
    }
}