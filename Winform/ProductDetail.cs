using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
using Services.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Winform
{
    public partial class ProductDetail : Form
    {
        private RoomRepository _room = new RoomRepository();
        private AccountRepository _account = new AccountRepository();
        Room ro = null;
        private ReviewRepository _review = new ReviewRepository();
        private CartRepository _cart = new CartRepository();
        Account account = new Account();
        public ProductDetail(Account ac, int roomid)
        {
            account = ac;
            ro = _room.GetAll().Include(rt => rt.RoomType).Include(h => h.Hotel).FirstOrDefault(r => r.Id == roomid);
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (String.IsNullOrEmpty(ro.Images))
            {
                pictureBox1.Image = new Bitmap(Winform.Properties.Resources.no_image_icon);
            }
            else
            {
                string filePath = GetDirectory.TryGetSolutionDirectoryInfo().FullName + "\\" + ro.Images;
                pictureBox1.Image = new Bitmap(filePath);
            }
            txtHotel.Text = ro.Hotel.Name.ToString();
            txtTypeRoom.Text = ro.RoomType.Name;
            txtAddress.Text = ro.Hotel.Address.ToString();
            txtRoomNumber.Text = ro.RoomNumber.ToString();
            txtPrice.Text = ro.Price.ToString() + " VND";
            txtCapacity.Text = ro.Capacity.ToString();
            txtDesc.Text = ro.Description.ToString();
            txtQuantity.Text = ro.Quanity.ToString();
            double star = CalculateAverageRate(ro.Id);
            if (star > 0) txtRating.Text = star.ToString() + "/5☆";
            else txtRating.Text = "No rating for this room";
            int reviews = _review.GetAll().Where(p => p.Id == ro.Id).Count();
            setReview(reviews);
            LoadReview();
        }
        public void LoadReview()
        {
            var reviews = _review.GetAll().Include(p => p.Booking.Customer).Where(p => p.Id == ro.Id);
            if (reviews.Any())
            {
                foreach (var r in reviews)
                {
                    string s = r.Booking.Customer.Username + "-" + r.Date.ToString("dd-MM-yyyy");
                    s += "\n" + r.Comment + "\n";
                    txtReview.Text += s + "\n";
                }
            }
            else
            {
                txtReview.Visible = false;
            }
        }
        public void setReview(int count)
        {
            switch (count)
            {
                case 0:
                    reviewLabel.Text = "There's no review";
                    break;
                case 1:
                    reviewLabel.Text = "There's 1 review";
                    break;
                case > 2 and <= 5:
                    reviewLabel.Text = "There're " + count.ToString() + " reviews";
                    break;
                case > 5:
                    reviewLabel.Text = "There're more than 5 reviews";
                    break;
            }
        }

        public double CalculateAverageRate(int rid)
        {
            List<int> rates = new List<int>();
            List<Review> reviews = _review.GetAll().Where(re => re.Roomid == rid).ToList();
            foreach (Review review in reviews)
            {
                rates.Add(review.Rating);
            }
            if (rates == null || rates.Count == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int rate in rates)
            {
                sum += rate;
            }
            double average = (double)sum / rates.Count;
            return average;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(account, new List<int>() { ro.Id });
            checkout.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addToCart(ro.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToCart(int roomId)
        {
            var fileName = GetDirectory.TryGetSolutionDirectoryInfo().FullName + "\\cart.txt";
            try
            {
                List<string> leftover = new List<string>();
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    // Open the stream and read it back.    
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            if (s.Equals(account.Id + "-" + roomId))
                            {
                                MessageBox.Show("You have already added this room to cart");
                                return;
                            }
                            leftover.Add(s);
                        }
                    }
                }
                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file
                    foreach (string s in leftover)
                    {
                        byte[] oldCart = new UTF8Encoding(true).GetBytes(s + "\n");
                        fs.Write(oldCart, 0, oldCart.Length);
                    }
                    byte[] newCart = new UTF8Encoding(true).GetBytes(account.Id + "-" + roomId + "\n");
                    fs.Write(newCart, 0, newCart.Length);
                }
                MessageBox.Show("Added to cart");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
