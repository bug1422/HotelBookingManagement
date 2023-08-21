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
            recent = new TextBox();
            date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            time = new Label();
            searchTxt = new TextBox();
            clearBtn = new Button();
            gbfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelDgv).BeginInit();
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
            // gbfind
            // 
            gbfind.BackColor = SystemColors.ActiveCaption;
            gbfind.Controls.Add(welcome);
            gbfind.Location = new Point(87, 147);
            gbfind.Name = "gbfind";
            gbfind.Size = new Size(1051, 99);
            gbfind.TabIndex = 9;
            gbfind.TabStop = false;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Dock = DockStyle.Top;
            welcome.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            welcome.Location = new Point(3, 23);
            welcome.Name = "welcome";
            welcome.Size = new Size(174, 50);
            welcome.TabIndex = 15;
            welcome.Text = "Welcome";
            // 
            // hotelDgv
            // 
            hotelDgv.AllowUserToAddRows = false;
            hotelDgv.AllowUserToDeleteRows = false;
            hotelDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hotelDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hotelDgv.Location = new Point(12, 339);
            hotelDgv.Name = "hotelDgv";
            hotelDgv.ReadOnly = true;
            hotelDgv.RowHeadersWidth = 51;
            hotelDgv.RowTemplate.Height = 29;
            hotelDgv.Size = new Size(565, 279);
            hotelDgv.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(13, 272);
            title.Name = "title";
            title.Size = new Size(72, 20);
            title.TabIndex = 11;
            title.Text = "Hotel List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 272);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 12;
            label4.Text = "Most Recent Room Booked";
            // 
            // recent
            // 
            recent.Location = new Point(631, 339);
            recent.Multiline = true;
            recent.Name = "recent";
            recent.Size = new Size(591, 279);
            recent.TabIndex = 13;
            recent.KeyPress += recent_KeyPress;
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(977, 68);
            date.Name = "date";
            date.Size = new Size(245, 41);
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
            time.Location = new Point(977, 9);
            time.Name = "time";
            time.Size = new Size(245, 41);
            time.TabIndex = 15;
            time.Text = "display time here";
            time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(13, 306);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Search hotel name or address here";
            searchTxt.Size = new Size(273, 27);
            searchTxt.TabIndex = 16;
            searchTxt.TextChanged += search_TextChanged;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(292, 305);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 815);
            Controls.Add(clearBtn);
            Controls.Add(searchTxt);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(recent);
            Controls.Add(label4);
            Controls.Add(title);
            Controls.Add(hotelDgv);
            Controls.Add(gbfind);
            Controls.Add(label1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            gbfind.ResumeLayout(false);
            gbfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelDgv).EndInit();
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
        private TextBox searchTxt;
        private Button clearBtn;
    }
}