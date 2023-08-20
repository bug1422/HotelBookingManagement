using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
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
        public ProductDetail(Account ac,int roomid)
        {
            account = ac;
            ro = _room.GetAll().Where(r => r.Id == roomid).Include(rt => rt.RoomType).Include(h => h.Hotel).First();
            InitializeComponent();
            lbRating.Text = CalculateAverageRate(roomid) + "/5" + " " + lbRating.Text;
            pictureBox1.ImageLocation = ro.Images.Trim();
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            txtHotel.Text = ro.Hotel.Name.ToString();
            txtTypeRoom.Text = ro.RoomType.Name;
            txtAddress.Text = ro.Hotel.Address.ToString();
            txtRoomNumber.Text = ro.RoomNumber.ToString();
            txtPrice.Text = ro.Price.ToString() + " VND";
            txtCapacity.Text = ro.Capacity.ToString();
            txtDesc.Text = ro.Description.ToString();
            txtQuantity.Text = ro.Quanity.ToString();
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

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (ro.Id == null)
            {
                MessageBox.Show("please choose product you want to place");
            }
            else
            {
                Checkout checkout = new Checkout(account, ro.Id);
                checkout.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            List<Review> reviews = _review.GetAll().Where(r => r.Roomid == ro.Id).Include(B => B.Booking).ToList();
            dgvReviews.Columns.Add("Column1", "Customer Name");
            dgvReviews.Columns.Add("Column2", "Rating");
            dgvReviews.Columns.Add("Column3", "Date");
            dgvReviews.Columns.Add("Column4", "Room Type");
            dgvReviews.Columns.Add("Column5", "Comment");
            
            foreach (Review re in reviews)
            {
                dgvReviews.Rows.Add(
                    _account.GetAll().Where(an => an.Id == re.Booking.Customerid).FirstOrDefault().Name,
                    re.Rating,
                    re.Date,
                    ro.RoomType.Name,
                    re.Comment
                    );
            }
        }
    }
}
