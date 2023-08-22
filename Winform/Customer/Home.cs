using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Winform
{
    public partial class Home : Form
    {
        private string path;
        Account account = new Account();
        private HotelRepository _hotel = new HotelRepository();
        private RoomRepository _room = new RoomRepository();
        private ReviewRepository _review = new ReviewRepository();
        private TypeRoomRepository _typeRoomRepository = new TypeRoomRepository();
        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _BookingDetail = new BookingDetailRepository();
        public Home(Account ac)
        {
            InitializeComponent();
            timer1.Start();
            account = ac;
            welcome.Text = "Welcome " + account.Username + ", ready to book?";
            updateHotelDgv();
            updateBookingDgv();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTxt1.Text = "";
        }

        private void updateHotelDgv()
        {
            var list = _hotel.GetAll().Include(p => p.Rooms);
            if (!String.IsNullOrEmpty(searchTxt1.Text))
            {
                list = list.Where(p =>
                p.Name.ToLower().Contains(searchTxt1.Text.ToLower()) ||
                p.Address.ToLower().Contains(searchTxt1.Text.ToLower())
                ).Include(p => p.Rooms);
            }
            hotelDgv.DataSource = list.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Address = p.Address,
                Phone = p.Phone,
                Availble = p.Rooms.Sum(p => p.Quanity) + " rooms"
            }).OrderBy(p => p.Name).ToList();
        }

        private void updateBookingDgv()
        {
            var completed = _booking.GetAll().Where(p => p.Customerid == account.Id && p.Status == 1).Select(p => p.Id).ToList();

            var list = _BookingDetail.GetAll().Include(p => p.Room).Where(p => p.Customerid == account.Id && completed.Contains(p.Bookingid));
            bookingDgv.DataSource = list.Select(p => new
            {
                BookingId = p.Bookingid,
                RoomId = p.Roomid,
                Name = "Room " + p.Room.RoomNumber,
                CheckIn = p.Checindate.ToShortDateString(),
                CheckOut = p.Checkoutdate.ToShortDateString()
            }).ToList();
            bookingDgv.Columns[0].Visible = false;
            bookingDgv.Columns[1].Visible = false;

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            updateHotelDgv();
        }

        private void recent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
