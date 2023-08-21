using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
using Services.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Winform
{
    public partial class Checkout : Form
    {
        private HotelRepository _hotel = new HotelRepository();
        private RoomRepository _room = new RoomRepository();
        private AccountRepository _account = new AccountRepository();
        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _bookingdetail = new BookingDetailRepository();
        private double total = 0;
        Room ro = null;
        Account account = new Account();
        List<int> roomIds = new List<int>();
        public Checkout(Account ac, List<int> list)
        {
            account = ac;
            roomIds = list;
            InitializeComponent();
            dtCheckin.MinDate = DateTime.Now.Date;
            dtCheckout.MinDate = DateTime.Now.Date;
            payInAdvance.Visible = false;
            total = _room.GetAll()
                .Where(r => list.Contains(r.Id)).Sum(p => p.Price);
            totalLabel.Text = "Total Price: " + total.ToString("00.00");
            LoadDgv();
        }
        private void LoadDgv()
        {
            dgvListProduct.DataSource = _room.GetAll()
                .Where(r => roomIds.Contains(r.Id))
                .Include(rt => rt.RoomType).Include(h => h.Hotel)
                .Select(p => new
                {
                    Id = p.Id,
                    Name = "Room " + p.RoomNumber,
                    Hotel = p.Hotel.Name,
                    Type = p.RoomType.Name,
                    Capacity = "Max " + p.Capacity.ToString() + (p.Capacity > 0 ? " person" : " people"),
                    Price = p.Price
                }).ToList();
            dgvListProduct.Columns[0].Visible = false;
        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dgvListProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                ro = _room.GetAll().Include(p => p.Hotel).Include(p => p.RoomType).FirstOrDefault(p => p.Id == id);
                txtRoomName.Text = "Room " + ro.RoomNumber;
                txtHotel.Text = ro.Hotel.Name + ", " + ro.Hotel.Address;
                txtType.Text = ro.RoomType.Name;
                txtCapacity.Text = "Max " + ro.Capacity.ToString() + (ro.Capacity > 0 ? " person" : " people");
                txtPrice.Text = ro.Price.ToString("000.00");
            }
        }
        private List<Hotel> GetHotelList()
        {
            List<Hotel> list = new List<Hotel>();
            foreach(var id in roomIds)
            {
                list.Add(_room.GetAll().Include(p => p.Hotel).FirstOrDefault(p => p.Id == id).Hotel);
            }
            return list;
        }

        private List<Room> GetRoomList(int hotelId)
        {
            List<Room> list = new List<Room>();
            foreach (var id in roomIds)
            {
                list.Add(_room.GetAll().FirstOrDefault(p => p.Id == id && p.Hotelid == hotelId));
            }
            return list;
        }
        private void Booking()
        {
            DateTime.TryParse(dtCheckin.Text, out DateTime checkin);
            DateTime.TryParse(dtCheckout.Text, out DateTime checkout);
            var bookingHistory = _bookingdetail.GetAll().Include(p => p.Room).Include(p => p.Room.Hotel).Where(p =>
            p.Customerid == account.Id &&
            roomIds.Contains(p.Roomid) &&
            (p.Checindate.Date >= checkin.Date && p.Checkoutdate <= checkout.Date) ||
            (p.Checindate <= checkin.Date && p.Checkoutdate >= checkout.Date)
            );
            if (bookingHistory.Any())
            {
                string error = "Please remove these room from list\n";
                foreach (var item in bookingHistory)
                {
                    error += "Room " + item.Room.RoomNumber + " from " + item.Room.Hotel.Name + " Hotel is already booked from "
                        + item.Checindate.ToShortDateString() + " to " + item.Checkoutdate.ToShortDateString() + "\n";
                }
                MessageBox.Show(error);
            }
            else
            {
                var hotels = GetHotelList();
                foreach (var hotel in hotels)
                {
                    var rooms = GetRoomList(hotel.Id);
                    double totalPrice = 0;
                    foreach(var r in rooms)
                    {
                        totalPrice += r.Price;
                    }
                    try
                    {
                        Booking booking = new Booking()
                        {
                            Customerid = account.Id,
                            Hotelid = hotel.Id,
                            Bookingdate = DateTime.Now.Date,
                            Totalprice = totalPrice,
                            Status = checkBox1.Checked ? 1 : 0,
                            Reason = "",
                            Phone = account.Phone
                        };
                        _booking.Add(booking);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't complete booking, " + ex.Message, "Booking Error");
                    }
                    try
                    {
                        var newid = _booking.GetAll().OrderBy(f => f.Id).LastOrDefault().Id;
                        foreach (var room in rooms)
                        {
                            var obj = _room.GetAll().FirstOrDefault(p => p.Id == room.Id);
                            BookingDetail detail = new BookingDetail()
                            {
                                Bookingid = newid,
                                Checindate = checkin.Date,
                                Checkoutdate = checkout.Date,
                                Price = obj.Price,
                                Roomid = obj.Id,
                                Customerid = account.Id
                            };
                            _bookingdetail.Add(detail);
                            removeFromCart(obj.Id);
                        }
                        MessageBox.Show("Successfully");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't complete booking, " + ex.Message, "Booking Detail Error");
                    }

                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (roomIds.Any())
            {
                if (DateTime.Compare(dtCheckin.Value.Date, dtCheckout.Value.Date) < 0)
                {
                    MessageBox.Show("Check out date must be check in date or later.");
                }
                else if (dtCheckout.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("Check out date must be from today onward.");
                }
                else if (dtCheckin.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("Check in date must be from today onward.");
                }
                else
                {
                    Booking();
                }
            }
            else
            {
                MessageBox.Show("No order in the current list, go back and add more.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
{
    payInAdvance.Visible = checkBox1.Checked;
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
    cardOwner.Text = cardOwner.Text.ToUpper();
}

private void cardNumber_TextChanged(object sender, EventArgs e)
{
    string s = cardNumber.Text;
    cardNumber.Text = s.Substring(0, 4) +
        "-" + s.Substring(4, 4) +
        "-" + s.Substring(8, 4) +
        "-" + s.Substring(12, 4);
}

private bool IsNumericKey(Keys key)
{
    // Check if the key is a number key (0-9 on the numeric keypad or top row)
    return (key >= Keys.D0 && key <= Keys.D9) ||
           (key >= Keys.NumPad0 && key <= Keys.NumPad9);
}

private void cardNumber_KeyDown(object sender, KeyEventArgs e)
{
    if (!IsNumericKey(e.KeyCode))
    {
        e.Handled = true;
    }
}

private void backBtn_Click(object sender, EventArgs e)
{
    this.Close();
}

private void removeFromCart(int roomId)
{
    var fileName = GetDirectory.TryGetSolutionDirectoryInfo().FullName + "\\cart.txt";
    try
    {
        List<string> newList = new List<string>();
        // Check if file already exists. If yes, delete it.     
        if (File.Exists(fileName))
        {
            // Open the stream and read it back.    
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (!s.Equals(account.Id + "-" + roomId))
                    {
                        newList.Add(s);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("No cart found");
            return;
        }
        // Create a new file     
        using (FileStream fs = File.Create(fileName))
        {
            // Add some text to file
            foreach (string s in newList)
            {
                byte[] oldCart = new UTF8Encoding(true).GetBytes(s + "\n");
                fs.Write(oldCart, 0, oldCart.Length);
            }
        }
    }
    catch (Exception Ex)
    {
        Console.WriteLine(Ex.ToString());
    }
}

private void removeBtn_Click(object sender, EventArgs e)
{
    if (ro.Id > 0)
    {
        removeFromCart(ro.Id);
        roomIds.Remove(ro.Id);
        var name = "Room " + _room.GetAll().FirstOrDefault(p => p.Id == ro.Id).RoomNumber;
        MessageBox.Show("Removed " + name + " from cart");
        LoadDgv();        
    }
    else
    {
        MessageBox.Show("Select a room first to use this action.");
    }
}
    }
}
