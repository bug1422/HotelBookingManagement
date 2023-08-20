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
    public partial class OrderDetailCS : Form
    {

        private BookingRepository _booking = new BookingRepository();
        private BookingDetailRepository _bookingdetail = new BookingDetailRepository();
        private AccountRepository _account = new AccountRepository();
        private HotelRepository _hotel = new HotelRepository();
        private RoomRepository _room = new RoomRepository();
        private TypeRoomRepository _type = new TypeRoomRepository();
        Account account = null;
        int orid;
        public OrderDetailCS(int oid)
        {
            orid = oid;
            InitializeComponent();
        }

        private void OrderDetailCS_Load(object sender, EventArgs e)
        {
            List<BookingDetail> bds = _bookingdetail.GetAll().Where(d => d.Bookingid == orid).ToList();
            dgvorderDetail.Columns.Add("", "Order ID");
            dgvorderDetail.Columns.Add("", "Customer Name");
            dgvorderDetail.Columns.Add("", "Room Type");
            dgvorderDetail.Columns.Add("", "Checkin");
            dgvorderDetail.Columns.Add("", "Checkout");
            dgvorderDetail.Columns.Add("", "Price");
            dgvorderDetail.Columns.Add("", "Quantity");
            foreach (BookingDetail b in bds)
            {
                Room room = _room.GetAll().Where(r => r.Id == b.Roomid).First();
                TypeRoom troom = _type.GetAll().Where(rt => rt.Id == room.Id).First();
                dgvorderDetail.Rows.Add(
                    b.Bookingid,
                    (_account.GetAll().Where(a => a.Id == b.Customerid).First()).Name,
                    troom.Name,
                    b.Checindate,
                    b.Checkoutdate,
                    room.Price,
                    1
                    );
            }

        }

        private void dgvorderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = this.dgvorderDetail.Rows[e.RowIndex];
                txtid.Text = dgv.Cells[0].Value.ToString();
                txtcustomername.Text = dgv.Cells[1].Value.ToString();
                txtroomtype.Text = dgv.Cells[2].Value.ToString();
                dtcheckin.Text = dgv.Cells[3].Value.ToString();
                dtcheckout.Text = dgv.Cells[4].Value.ToString();
                txtprice.Text = dgv.Cells[5].Value.ToString();
                txtquanity.Text = dgv.Cells[6].Value.ToString();
            }
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvorderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
