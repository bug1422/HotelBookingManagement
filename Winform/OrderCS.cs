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
    //status order -1:Cancel, 0:process, 1:Success
    public partial class OrderCS : Form
    {
        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _bookingdetail = new BookingDetailRepository();
        private AccountRepository _account = new AccountRepository();
        private HotelRepository _hotel = new HotelRepository();
        Account account = null;
        public OrderCS(Account ac)
        {
            account = ac;
            InitializeComponent();
        }

        private void dgvorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = this.dgvorder.Rows[e.RowIndex];
                txtid.Text = dgv.Cells[0].Value.ToString();
                txthotel.Text = dgv.Cells[1].Value.ToString();
                txtorderdate.Text = dgv.Cells[2].Value.ToString();
                txtstatus.Text = dgv.Cells[3].Value.ToString();
                txtcsname.Text = dgv.Cells[4].Value.ToString();
            }
        }

        private void OrderCS_Load(object sender, EventArgs e)
        {
            List<Booking> bookings = _booking.GetAll().Where(b => b.Customerid == account.Id).ToList();
            dgvorder.Columns.Add("1", "ID");
            dgvorder.Columns.Add("1", "Hotel");
            dgvorder.Columns.Add("1", "Order Date");
            dgvorder.Columns.Add("1", "Status");
            dgvorder.Columns.Add("1", "Customer Name");
            foreach (Booking booking in bookings)
            {
                string status = "";
                if (booking.Status == -1)
                {
                    status = "Cancel";
                }
                if (booking.Status == 0)
                {
                    status = "Processing";
                }
                if (booking.Status == 1)
                {
                    status = "Successfully";
                }
                dgvorder.Rows.Add(
                    booking.Id,
                     _hotel.GetAll().Where(h => h.Id == booking.Hotelid).Select(ht => ht.Name).First(),
                     booking.Bookingdate,
                     status,
                     _account.GetAll().Where(a => a.Id == booking.Customerid).Select(acc => acc.Name).First()
                    );
            }
        }

        private void btnviewdetail_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
            {
                MessageBox.Show("Choose order you want view detail");
            }
            else
            {
                OrderDetailCS od = new OrderDetailCS(int.Parse(txtid.Text));
                od.ShowDialog();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtid.Text == null)
            {
                MessageBox.Show("Please choose order you want update status");
            }
            if (txtstatus.Text.Equals("Cancel"))
            {
                MessageBox.Show("Status of order is cancel, not cancel again");
            }
            if (txtstatus.Text.Equals("Successfully"))
            {
                MessageBox.Show("Order is succesfulled, dont cancel");
            }
            else
            {
                Int32.TryParse(txtid.Text.Trim(), out int oid);
                Booking bfind = _booking.GetAll().Where(b => b.Id == oid).FirstOrDefault();
                Booking b = new Booking() {Id = oid, Customerid = account.Id, Hotelid = bfind.Hotelid, Bookingdate = bfind.Bookingdate, Totalprice = bfind.Totalprice, Status = -1, Reason = "", Phone = bfind.Phone};
                _booking.Update(b);
                MessageBox.Show("Canceled");
                List<Booking> bookings = _booking.GetAll().Where(b => b.Customerid == account.Id).ToList();
                dgvorder.Rows.Clear();
                dgvorder.Columns.Clear();
                dgvorder.Columns.Add("1", "ID");
                dgvorder.Columns.Add("1", "Hotel");
                dgvorder.Columns.Add("1", "Order Date");
                dgvorder.Columns.Add("1", "Status");
                dgvorder.Columns.Add("1", "Customer Name");
                foreach (Booking booking in bookings)
                {
                    string status = "";
                    if (booking.Status == -1)
                    {
                        status = "Cancel";
                    }
                    if (booking.Status == 0)
                    {
                        status = "Processing";
                    }
                    if (booking.Status == 1)
                    {
                        status = "Successfully";
                    }
                    dgvorder.Rows.Add(
                        booking.Id,
                         _hotel.GetAll().Where(h => h.Id == booking.Hotelid).Select(ht => ht.Name).First(),
                         booking.Bookingdate,
                         status,
                         _account.GetAll().Where(a => a.Id == booking.Customerid).Select(acc => acc.Name).First()
                        );
                }
            }
        }
    }
}
