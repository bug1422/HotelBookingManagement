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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            gbfind = new GroupBox();
            welcome = new Label();
            hotelDgv = new DataGridView();
            title = new Label();
            label4 = new Label();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            time = new Label();
            searchTxt1 = new TextBox();
            clearBtn1 = new Button();
            bookingDgv = new DataGridView();
            button1 = new Button();
            searchTxt2 = new TextBox();
            gbfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingDgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 41);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // gbfind
            // 
            gbfind.BackColor = SystemColors.ActiveCaption;
            gbfind.Controls.Add(welcome);
            gbfind.Location = new Point(76, 110);
            gbfind.Margin = new Padding(3, 2, 3, 2);
            gbfind.Name = "gbfind";
            gbfind.Padding = new Padding(3, 2, 3, 2);
            gbfind.Size = new Size(920, 74);
            gbfind.TabIndex = 9;
            gbfind.TabStop = false;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Dock = DockStyle.Top;
            welcome.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            welcome.Location = new Point(3, 18);
            welcome.Name = "welcome";
            welcome.Size = new Size(142, 41);
            welcome.TabIndex = 15;
            welcome.Text = "Welcome";
            // 
            // hotelDgv
            // 
            hotelDgv.AllowUserToAddRows = false;
            hotelDgv.AllowUserToDeleteRows = false;
            hotelDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hotelDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hotelDgv.Location = new Point(10, 254);
            hotelDgv.Margin = new Padding(3, 2, 3, 2);
            hotelDgv.Name = "hotelDgv";
            hotelDgv.ReadOnly = true;
            hotelDgv.RowHeadersWidth = 51;
            hotelDgv.RowTemplate.Height = 29;
            hotelDgv.Size = new Size(494, 209);
            hotelDgv.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(11, 204);
            title.Name = "title";
            title.Size = new Size(57, 15);
            title.TabIndex = 11;
            title.Text = "Hotel List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 204);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 12;
            label4.Text = "Completed Booking History";
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(855, 51);
            date.Name = "date";
            date.Size = new Size(214, 31);
            date.TabIndex = 14;
            date.Text = "display date here";
            date.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // time
            // 
            time.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            time.Location = new Point(855, 7);
            time.Name = "time";
            time.Size = new Size(214, 31);
            time.TabIndex = 15;
            time.Text = "display time here";
            time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchTxt1
            // 
            searchTxt1.Location = new Point(11, 230);
            searchTxt1.Margin = new Padding(3, 2, 3, 2);
            searchTxt1.Name = "searchTxt1";
            searchTxt1.PlaceholderText = "Search hotel name or address here";
            searchTxt1.Size = new Size(239, 23);
            searchTxt1.TabIndex = 16;
            searchTxt1.TextChanged += search_TextChanged;
            // 
            // clearBtn1
            // 
            clearBtn1.Location = new Point(256, 229);
            clearBtn1.Margin = new Padding(3, 2, 3, 2);
            clearBtn1.Name = "clearBtn1";
            clearBtn1.Size = new Size(82, 22);
            clearBtn1.TabIndex = 17;
            clearBtn1.Text = "Clear";
            clearBtn1.UseVisualStyleBackColor = true;
            clearBtn1.Click += clearBtn_Click;
            // 
            // bookingDgv
            // 
            bookingDgv.AllowUserToAddRows = false;
            bookingDgv.AllowUserToDeleteRows = false;
            bookingDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookingDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingDgv.Location = new Point(552, 254);
            bookingDgv.Margin = new Padding(3, 2, 3, 2);
            bookingDgv.Name = "bookingDgv";
            bookingDgv.ReadOnly = true;
            bookingDgv.RowHeadersWidth = 51;
            bookingDgv.RowTemplate.Height = 29;
            bookingDgv.Size = new Size(494, 209);
            bookingDgv.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(796, 228);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 20;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchTxt2
            // 
            searchTxt2.Location = new Point(552, 229);
            searchTxt2.Margin = new Padding(3, 2, 3, 2);
            searchTxt2.Name = "searchTxt2";
            searchTxt2.PlaceholderText = "Search hotel name or address here";
            searchTxt2.Size = new Size(239, 23);
            searchTxt2.TabIndex = 19;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 611);
            Controls.Add(button1);
            Controls.Add(searchTxt2);
            Controls.Add(bookingDgv);
            Controls.Add(clearBtn1);
            Controls.Add(searchTxt1);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(label4);
            Controls.Add(title);
            Controls.Add(hotelDgv);
            Controls.Add(gbfind);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            gbfind.ResumeLayout(false);
            gbfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbfind;
        private DataGridView hotelDgv;
        private Label title;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private ComboBox cbRoomType;
        private Label welcome;
        private Label label4;
        private TextBox recent;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Label time;
        private TextBox searchTxt1;
        private Button clearBtn1;
        private DataGridView bookingDgv;
        private Button button1;
        private TextBox searchTxt2;
    }
}