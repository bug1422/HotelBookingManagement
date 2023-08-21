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
            remove = new Button();
            checkout = new Button();
            cartFlow = new FlowLayoutPanel();
            cartLabel = new Label();
            orderBtn = new Button();
            refreshBtn = new Button();
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
            // remove
            // 
            remove.Location = new Point(878, 431);
            remove.Name = "remove";
            remove.Size = new Size(158, 77);
            remove.TabIndex = 21;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // checkout
            // 
            checkout.Location = new Point(677, 431);
            checkout.Name = "checkout";
            checkout.Size = new Size(158, 77);
            checkout.TabIndex = 12;
            checkout.Text = "Check Out";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += btnCheckout_Click;
            // 
            // cartFlow
            // 
            cartFlow.AutoScroll = true;
            cartFlow.Location = new Point(12, 53);
            cartFlow.Name = "cartFlow";
            cartFlow.Size = new Size(1024, 337);
            cartFlow.TabIndex = 55;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(374, 24);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(261, 20);
            cartLabel.TabIndex = 56;
            cartLabel.Text = "There's no order in cart. Go add some!";
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(477, 431);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(158, 77);
            orderBtn.TabIndex = 57;
            orderBtn.Text = "See Order History";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(12, 431);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(158, 77);
            refreshBtn.TabIndex = 58;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 564);
            Controls.Add(refreshBtn);
            Controls.Add(orderBtn);
            Controls.Add(cartLabel);
            Controls.Add(cartFlow);
            Controls.Add(remove);
            Controls.Add(checkout);
            Controls.Add(label1);
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button remove;
        private Button checkout;
        private FlowLayoutPanel cartFlow;
        private Label cartLabel;
        private Button orderBtn;
        private Button refreshBtn;
    }
}