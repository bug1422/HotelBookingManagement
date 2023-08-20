using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Checkout : Form
    {
        private RoomRepository _room = new RoomRepository();
        private AccountRepository _account = new AccountRepository();
        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _bookingdetail = new BookingDetailRepository(); 
        Room ro = null;
        Account account = new Account();
        public Checkout(Account ac, int rid)
        {
            account = ac;
            ro = _room.GetAll().Where(r => r.Id == rid).Include(rt => rt.RoomType).Include(h => h.Hotel).First();
            InitializeComponent();
            txtName.Text = ac.Name;
            txtPhone.Text = ac.Phone;
            txtTotal.Text = ro.Price * 1 + "";
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            dgvListProduct.Columns.Add("1", "ID");
            dgvListProduct.Columns.Add("1", "Hotel");
            dgvListProduct.Columns.Add("1", "Room Type");
            dgvListProduct.Columns.Add("1", "Address");
            dgvListProduct.Columns.Add("1", "Capacity");
            dgvListProduct.Columns.Add("1", "Status");
            dgvListProduct.Columns.Add("1", "Price");
            dgvListProduct.Columns.Add("1", "Quantity");
            dgvListProduct.Rows.Add(
                ro.Id,
                ro.Hotel.Name,
                ro.RoomType.Name,
                ro.Hotel.Address,
                ro.Capacity,
                ro.Quanity,
                ro.Price,
                1
                );
        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = this.dgvListProduct.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txthoteil.Text = dgv.Cells[1].Value.ToString();
                cbRT.Text = dgv.Cells[2].Value.ToString();
                txtad.Text = dgv.Cells[3].Value.ToString();
                txtcapacity.Text = dgv.Cells[4].Value.ToString();
                txtstatus.Text = dgv.Cells[5].Value.ToString();
                txtPrice.Text = dgv.Cells[6].Value.ToString();
                txtquantity.Text = dgv.Cells[7].Value.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool valid = true;
           if(dtCheckin.Value > dtCheckout.Value)
            {
                MessageBox.Show("checkin out must > check in");
                valid = false;
            }
           if(dtCheckout.Value < DateTime.Now)
            {
                MessageBox.Show("checkout must > date now");
                valid = false;
            }
            if (dtCheckin.Value < DateTime.Now)
            {
                MessageBox.Show("checkin must > date now");
                valid = false;
            }
            else
            {
                if(valid == true)
                {
                    DateTime.TryParse(dtCheckin.Text, out DateTime checkin);
                    DateTime.TryParse(dtCheckout.Text, out DateTime checkout);
                    Booking booking = new Booking() { Customerid = account.Id, Hotelid = ro.Hotelid, Bookingdate = DateTime.Now, Totalprice = float.Parse(txtTotal.Text), Status = 1, Reason = "", Phone = txtPhone.Text };
                    _booking.Add(booking);
                    var newid = _booking.GetAll().OrderByDescending(f => f.Id).First();
                    BookingDetail detail = new BookingDetail() { Bookingid = newid.Id, Checindate = checkin, Checkoutdate = checkout, Price = ro.Price, Roomid = ro.Id, Customerid = account.Id};
                    _bookingdetail.Add(detail);
                    MessageBox.Show("Successfully");
                }
            }

        }
    }
}
