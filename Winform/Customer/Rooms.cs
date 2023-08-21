using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
using Services.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Winform
{
    public partial class Rooms : Form
    {
        Account account = null;
        private int roomId = -1;
        private HotelRepository _hotel = new HotelRepository();
        private RoomRepository _room = new RoomRepository();
        private ReviewRepository _review = new ReviewRepository();
        private TypeRoomRepository _typeRoomRepository = new TypeRoomRepository();
        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _BookingDetail = new BookingDetailRepository();
        public Rooms(Account ac)
        {
            List<Room> rooms = _room.GetAll().ToList();
            account = ac;
            InitializeComponent();
            dtCheckin.Value = DateTime.Now;
            dtCheckout.Value = DateTime.Parse("2023-12-31");
            address.Items.Add("All");
            foreach (var addr in _hotel.GetAll().Select(rt => rt.Address).Distinct().ToList())
            {
                address.Items.Add(addr.ToString());
            }
            address.SelectedIndex = 0;
            CreateDgv();
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

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
        private void CreateDgv()
        {
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateDgv(DateTime.Now, DateTime.MaxValue);
        }
        private IQueryable<Room> GetAvailable(DateTime start, DateTime end)
        {
            List<int> unavail = _BookingDetail.GetAll().Include(p => p.Room).Where(p =>
                DateTime.Compare(p.Checindate, start) > 0 &&
                DateTime.Compare(p.Checkoutdate, end) < 0).Select(p => p.Room.Id).ToList();
            var list = _room.GetAll().Include(p => p.Hotel).Include(p => p.RoomType).Where(p => p.Quanity > 0 && !unavail.Contains(p.Id));
            if (address.SelectedIndex > 0)
            {
                list = list.Where(p => p.Hotel.Address.Equals(address.SelectedItem.ToString()));
            }
            return list;
        }
        private void UpdateDgv(DateTime start, DateTime end)
        {
            var list = GetAvailable(start, end);
            dgvProduct.DataSource = list.Select(p => new
            {
                Id = p.Id,
                Name = "Room " + p.RoomNumber,
                Hotel = p.Hotel.Name,
                Type = p.RoomType.Name,
                Description = p.Description,
                Capacity = "Max " + p.Capacity.ToString() + (p.Capacity > 0 ? " person" : " people"),
                Pricing = p.Price.ToString("0.00"),
                Available = p.Quanity.ToString() + (p.Quanity > 0 ? " rooms" : " room") + " left"
            }).ToList();
            dgvProduct.Columns[0].Visible = false;
            SetCount(list.Count());
        }
        private void gbfind_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dtCheckin.Value.Date > dtCheckout.Value.Date)
            {
                MessageBox.Show("check in must be earlier check out.");
            }
            if (dtCheckin.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("check in must start from today.");
            }
            else
            {
                UpdateDgv(dtCheckin.Value.Date, dtCheckout.Value.Date);
            }
        }


        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                var obj = _room.GetAll().Include(p => p.Hotel).Include(p => p.RoomType).FirstOrDefault(p => p.Id == id);
                txtName.Text = "Room " + obj.RoomNumber;
                txtHotel.Text = obj.Hotel.Name;
                txtAddress.Text = obj.Hotel.Address;
                txtType.Text = obj.RoomType.Name;
                txtCapacity.Text = "Max " + obj.Capacity.ToString() + (obj.Capacity > 0 ? " person" : " people");
                txtRating.Text = CalculateAverageRate(obj.Id).ToString() + "/5☆";
                txtPrice.Text = obj.Price.ToString("0.00");
                txtStatus.Text = obj.Quanity.ToString() + (obj.Quanity > 0 ? " rooms" : " room") + " availble";
                roomId = obj.Id;
            }
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (roomId > 0)
            {
                Checkout checkout = new Checkout(account, new List<int>() { roomId });
                checkout.ShowDialog();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (roomId > 0)
            {
                addToCart(roomId);
            }
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            if (roomId > 0)
            {
                Form f = new ProductDetail(account, roomId);
                f.BringToFront();
                f.ShowDialog();
            }
        }

        private void SetCount(int count)
        {
            switch (count)
            {
                case 0:
                    lbCount.Text = "There're no availble room";
                    break;
                case 1:
                    lbCount.Text = "There's 1 availble room";
                    break;
                case > 2 and <= 5:
                    lbCount.Text = "There're " + count.ToString() + " available rooms";
                    break;
                case > 5:
                    lbCount.Text = "There're more than 5 available rooms";
                    break;
            }
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
    }
}
