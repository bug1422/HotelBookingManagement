namespace Winform
{
    partial class Cart
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
            btnDelete = new Button();
            btnUpdateQuantity = new Button();
            btnCheckout = new Button();
            dgvCart = new DataGridView();
            cbRT = new ComboBox();
            label11 = new Label();
            txtPrice = new TextBox();
            label12 = new Label();
            txtstatus = new TextBox();
            label13 = new Label();
            txtrating = new TextBox();
            label8 = new Label();
            txtcapacity = new TextBox();
            label7 = new Label();
            txtad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txthoteil = new TextBox();
            label2 = new Label();
            txtquantity = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 50);
            label1.TabIndex = 1;
            label1.Text = "Cart";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1100, 564);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.Location = new Point(1100, 516);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(94, 29);
            btnUpdateQuantity.TabIndex = 20;
            btnUpdateQuantity.Text = "Update";
            btnUpdateQuantity.UseVisualStyleBackColor = true;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(1100, 467);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 12;
            btnCheckout.Text = "Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(12, 75);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(1169, 342);
            dgvCart.TabIndex = 11;
            dgvCart.CellClick += dgvCart_CellClick;
            // 
            // cbRT
            // 
            cbRT.FormattingEnabled = true;
            cbRT.Location = new Point(114, 543);
            cbRT.Name = "cbRT";
            cbRT.Size = new Size(277, 28);
            cbRT.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(453, 596);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 48;
            label11.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(545, 589);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(453, 549);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 46;
            label12.Text = "Status";
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(545, 542);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(277, 27);
            txtstatus.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(453, 504);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 44;
            label13.Text = "Rating";
            // 
            // txtrating
            // 
            txtrating.Location = new Point(545, 497);
            txtrating.Name = "txtrating";
            txtrating.Size = new Size(277, 27);
            txtrating.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 653);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 42;
            label8.Text = "Capacity";
            // 
            // txtcapacity
            // 
            txtcapacity.Location = new Point(114, 646);
            txtcapacity.Name = "txtcapacity";
            txtcapacity.Size = new Size(277, 27);
            txtcapacity.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 601);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 40;
            label7.Text = "Address";
            // 
            // txtad
            // 
            txtad.Location = new Point(114, 594);
            txtad.Name = "txtad";
            txtad.Size = new Size(277, 27);
            txtad.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 551);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 38;
            label6.Text = "RoomType";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 504);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 37;
            label5.Text = "Hoteil";
            // 
            // txthoteil
            // 
            txthoteil.Location = new Point(114, 497);
            txthoteil.Name = "txthoteil";
            txthoteil.Size = new Size(277, 27);
            txthoteil.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 639);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 51;
            label2.Text = "Quantity";
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(545, 632);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(277, 27);
            txtquantity.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 471);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 53;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(114, 464);
            txtID.Name = "txtID";
            txtID.Size = new Size(277, 27);
            txtID.TabIndex = 52;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 782);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtquantity);
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
            Controls.Add(btnDelete);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(btnCheckout);
            Controls.Add(dgvCart);
            Controls.Add(label1);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDelete;
        private Button btnUpdateQuantity;
        private Button btnCheckout;
        private DataGridView dgvCart;
        private ComboBox cbRT;
        private Label label11;
        private TextBox txtPrice;
        private Label label12;
        private TextBox txtstatus;
        private Label label13;
        private TextBox txtrating;
        private Label label8;
        private TextBox txtcapacity;
        private Label label7;
        private TextBox txtad;
        private Label label6;
        private Label label5;
        private TextBox txthoteil;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtquantity;
        private Label label3;
        private TextBox txtID;
    }
}