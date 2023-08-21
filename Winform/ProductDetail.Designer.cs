namespace Winform
{
    partial class ProductDetail
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
            txtTypeRoom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtHotel = new TextBox();
            label4 = new Label();
            txtRoomNumber = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtCapacity = new TextBox();
            lbRating = new Label();
            label8 = new Label();
            txtDesc = new TextBox();
            label9 = new Label();
            txtQuantity = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            addBtn = new Button();
            bookBtn = new Button();
            reviewLabel = new Label();
            txtRating = new Label();
            txtReview = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTypeRoom
            // 
            txtTypeRoom.Location = new Point(403, 151);
            txtTypeRoom.Name = "txtTypeRoom";
            txtTypeRoom.Size = new Size(450, 27);
            txtTypeRoom.TabIndex = 0;
            txtTypeRoom.KeyPress += txtDesc_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 158);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Type Room";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 217);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(403, 214);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(450, 27);
            txtAddress.TabIndex = 2;
            txtAddress.KeyPress += txtDesc_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 101);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Hotel";
            // 
            // txtHotel
            // 
            txtHotel.Location = new Point(403, 98);
            txtHotel.Name = "txtHotel";
            txtHotel.Size = new Size(450, 27);
            txtHotel.TabIndex = 4;
            txtHotel.KeyPress += txtDesc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 288);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 7;
            label4.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(403, 285);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(450, 27);
            txtRoomNumber.TabIndex = 6;
            txtRoomNumber.KeyPress += txtDesc_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 361);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(403, 358);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(450, 27);
            txtPrice.TabIndex = 8;
            txtPrice.KeyPress += txtDesc_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 437);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(403, 434);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(450, 27);
            txtCapacity.TabIndex = 10;
            txtCapacity.KeyPress += txtDesc_KeyPress;
            // 
            // lbRating
            // 
            lbRating.AutoSize = true;
            lbRating.Location = new Point(896, 98);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(52, 20);
            lbRating.TabIndex = 13;
            lbRating.Text = "Rating";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 521);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(403, 514);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(450, 128);
            txtDesc.TabIndex = 14;
            txtDesc.KeyPress += txtDesc_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(276, 682);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 16;
            label9.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(403, 675);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(450, 27);
            txtQuantity.TabIndex = 17;
            txtQuantity.KeyPress += txtDesc_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 98);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 18;
            label10.Text = "Images";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = Properties.Resources.no_image_icon;
            pictureBox1.Location = new Point(12, 136);
            pictureBox1.MaximumSize = new Size(245, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 71);
            button1.TabIndex = 22;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(41, 563);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(142, 79);
            addBtn.TabIndex = 104;
            addBtn.Text = "Add to cart";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // bookBtn
            // 
            bookBtn.Location = new Point(41, 433);
            bookBtn.Name = "bookBtn";
            bookBtn.Size = new Size(139, 78);
            bookBtn.TabIndex = 103;
            bookBtn.Text = "Book this room now";
            bookBtn.UseVisualStyleBackColor = true;
            bookBtn.Click += bookBtn_Click;
            // 
            // reviewLabel
            // 
            reviewLabel.AutoSize = true;
            reviewLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            reviewLabel.Location = new Point(896, 136);
            reviewLabel.Name = "reviewLabel";
            reviewLabel.Size = new Size(226, 32);
            reviewLabel.TabIndex = 110;
            reviewLabel.Text = "There are no review";
            // 
            // txtRating
            // 
            txtRating.AutoSize = true;
            txtRating.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRating.Location = new Point(954, 95);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(70, 30);
            txtRating.TabIndex = 111;
            txtRating.Text = "0/5 ☆";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(896, 184);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.ScrollBars = ScrollBars.Vertical;
            txtReview.Size = new Size(311, 518);
            txtReview.TabIndex = 112;
            txtReview.KeyPress += txtDesc_KeyPress;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1219, 815);
            Controls.Add(txtReview);
            Controls.Add(txtRating);
            Controls.Add(reviewLabel);
            Controls.Add(addBtn);
            Controls.Add(bookBtn);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(txtQuantity);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtDesc);
            Controls.Add(lbRating);
            Controls.Add(label6);
            Controls.Add(txtCapacity);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtRoomNumber);
            Controls.Add(label3);
            Controls.Add(txtHotel);
            Controls.Add(label2);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtTypeRoom);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTypeRoom;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtHotel;
        private Label label4;
        private TextBox txtRoomNumber;
        private Label label5;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtCapacity;
        protected Label label1;
        protected Label lbRating;
        private Label label8;
        private TextBox txtDesc;
        private Label label9;
        private TextBox txtQuantity;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button1;
        private Button addBtn;
        private Button bookBtn;
        private Label reviewLabel;
        private Label txtRating;
        private TextBox txtReview;
    }
}