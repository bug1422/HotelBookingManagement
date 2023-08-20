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

namespace Winform
{
    public partial class Home : Form
    {
        Account account = null;
        private RoomRepository _room = new RoomRepository();
        private ReviewRepository _review = new ReviewRepository();
        private TypeRoomRepository _typeRoomRepository = new TypeRoomRepository();
        private BookingDetailRepository _BookingDetail = new BookingDetailRepository();
        List<string> sorts = new List<string>() { "A-Z", "Z-A", "New", "Price" };

        public Home(Account ac)
        {
            List<Room> rooms = _room.GetAll().ToList();
            account = ac;
            InitializeComponent();
            lbWelcome.Text = lbWelcome.Text + " " + account.Name;
            cbSort.DataSource = sorts;
            cbCate.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();
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
        private void Home_Load(object sender, EventArgs e)
        {
            List<Room> rooms = _room.GetAll().Where(r => r.Quanity > 0).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
            dgvProduct.Columns.Add("1", "Room ID");
            dgvProduct.Columns.Add("2", "Hotel Name");
            dgvProduct.Columns.Add("3", "Room Type");
            dgvProduct.Columns.Add("4", "Room Address");
            dgvProduct.Columns.Add("5", "Room Capacity");
            dgvProduct.Columns.Add("6", "Room Rating");
            dgvProduct.Columns.Add("7", "Room Status");
            dgvProduct.Columns.Add("8", "Room Price");
            foreach (Room ro in rooms)
            {
                dgvProduct.Rows.Add(
                    ro.Id,
                    ro.Hotel.Name,
                    ro.RoomType.Name,
                    ro.Hotel.Address,
                    ro.Capacity,
                    CalculateAverageRate(ro.Id) + "/5",
                    (ro.Quanity > 0) ? ro.Quanity + " room" : "OutStock",
                    ro.Price
                    );
            }
            cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();

        }

        private void gbfind_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("please input address");
            }
            if (dtCheckin.Value > dtCheckout.Value)
            {
                MessageBox.Show("check in must < check out");
            }
            if (dtCheckin.Value < DateTime.Now)
            {
                MessageBox.Show("check in must is today or > today");
            }
            else
            {
                //lay rid có trong order id từ checkin tới check out Checkin < x < Checkout
                List<BookingDetail> listid = _BookingDetail.GetAll().Where(b => b.Checindate >= dtCheckin.Value || b.Checkoutdate <= dtCheckout.Value).ToList();
                List<Room> rooms = _room.GetAll().Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
                dgvProduct.Rows.Clear();
                dgvProduct.Columns.Clear();
                dgvProduct.Columns.Add("1", "Room ID");
                dgvProduct.Columns.Add("2", "Hotel Name");
                dgvProduct.Columns.Add("3", "Room Type");
                dgvProduct.Columns.Add("4", "Room Address");
                dgvProduct.Columns.Add("5", "Room Capacity");
                dgvProduct.Columns.Add("6", "Room Rating");
                dgvProduct.Columns.Add("7", "Room Status");
                dgvProduct.Columns.Add("8", "Room Price");
                foreach (Room ro in rooms)
                {
                    if (!listid.Any(booking => booking.Roomid == ro.Id))
                    {
                        dgvProduct.Rows.Add(
                        ro.Id,
                        ro.Hotel.Name,
                        ro.RoomType.Name,
                        ro.Hotel.Address,
                        ro.Capacity,
                        CalculateAverageRate(ro.Id) + "/5",
                        (ro.Quanity > 0) ? ro.Quanity + " room" : "OutStock",
                        ro.Price
                        );
                    }

                }
                cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = this.dgvProduct.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txthoteil.Text = dgv.Cells[1].Value.ToString();
                cbRT.Text = dgv.Cells[2].Value.ToString();
                txtad.Text = dgv.Cells[3].Value.ToString();
                txtcapacity.Text = dgv.Cells[4].Value.ToString();
                txtrating.Text = dgv.Cells[5].Value.ToString();
                txtstatus.Text = dgv.Cells[6].Value.ToString();
                txtPrice.Text = dgv.Cells[7].Value.ToString();
            }

        }

        private void btncate_Click(object sender, EventArgs e)
        {
            List<Room> rooms = _room.GetAll().Where(r => r.RoomType.Name.Equals(cbCate.Text)).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();
            dgvProduct.Columns.Add("1", "Room ID");
            dgvProduct.Columns.Add("2", "Hotel Name");
            dgvProduct.Columns.Add("3", "Room Type");
            dgvProduct.Columns.Add("4", "Room Address");
            dgvProduct.Columns.Add("5", "Room Capacity");
            dgvProduct.Columns.Add("6", "Room Rating");
            dgvProduct.Columns.Add("7", "Room Status");
            dgvProduct.Columns.Add("8", "Room Price");
            foreach (Room ro in rooms)
            {
                dgvProduct.Rows.Add(
                    ro.Id,
                    ro.Hotel.Name,
                    ro.RoomType.Name,
                    ro.Hotel.Address,
                    ro.Capacity,
                    CalculateAverageRate(ro.Id) + "/5",
                    (ro.Quanity > 0) ? ro.Quanity + " room" : "OutStock",
                    ro.Price
                    );
            }
            cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            List<Room> rooms = new List<Room>();
            string caseSort = cbSort.Text;
            switch (caseSort)
            {
                case "New":
                    rooms = _room.GetAll().OrderByDescending(r => r.Id).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
                    break;
                case "A-Z":
                    rooms = _room.GetAll().OrderBy(r => r.Hotel.Name).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
                    break;
                case "Z-A":
                    rooms = _room.GetAll().OrderByDescending(r => r.Hotel.Name).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
                    break;
                case "Price":
                    rooms = _room.GetAll().OrderBy(r => r.Price).Include(h => h.Hotel).Include(rt => rt.RoomType).ToList();
                    break;

            }
            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();
            dgvProduct.Columns.Add("1", "Room ID");
            dgvProduct.Columns.Add("2", "Hotel Name");
            dgvProduct.Columns.Add("3", "Room Type");
            dgvProduct.Columns.Add("4", "Room Address");
            dgvProduct.Columns.Add("5", "Room Capacity");
            dgvProduct.Columns.Add("6", "Room Rating");
            dgvProduct.Columns.Add("7", "Room Status");
            dgvProduct.Columns.Add("8", "Room Price");
            foreach (Room ro in rooms)
            {
                dgvProduct.Rows.Add(
                    ro.Id,
                    ro.Hotel.Name,
                    ro.RoomType.Name,
                    ro.Hotel.Address,
                    ro.Capacity,
                    CalculateAverageRate(ro.Id) + "/5",
                    (ro.Quanity > 0) ? ro.Quanity + " room" : "OutStock",
                    ro.Price
                    );
            }
            cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Please choose room you want view detail");
            }
            int.TryParse(txtID.Text, out int id);
            using (ProductDetail frmpd = new ProductDetail(account, id))
            {
                DialogResult rs = frmpd.ShowDialog();
                if (rs == DialogResult.OK)
                {

                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderCS o = new OrderCS(account);
            o.ShowDialog();
        }
    }
}
