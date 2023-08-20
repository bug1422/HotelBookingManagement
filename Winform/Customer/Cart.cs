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
    public partial class Cart : Form
    {
        private CartRepository _cart = new CartRepository();
        private AccountRepository _account = new AccountRepository();
        private RoomRepository _room = new RoomRepository();
        private ReviewRepository _review = new ReviewRepository();
        private TypeRoomRepository _typeRoomRepository = new TypeRoomRepository();
        Account aa = null;
        List<Carto> carts = new List<Carto>();

        public Cart(Account a)
        {
            aa = a;
            InitializeComponent();
        }

        public Cart()
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
        private void Cart_Load(object sender, EventArgs e)
        {
            List<Carto> carts = _cart.getAllCart();
            dgvCart.Rows.Clear();
            dgvCart.Columns.Add("1", "ID");
            dgvCart.Columns.Add("1", "Hotel");
            dgvCart.Columns.Add("1", "Room Type");
            dgvCart.Columns.Add("1", "Address");
            dgvCart.Columns.Add("1", "Capacity");
            dgvCart.Columns.Add("1", "Rating");
            dgvCart.Columns.Add("1", "Status");
            dgvCart.Columns.Add("1", "Price");
            dgvCart.Columns.Add("1", "Quantity");
            foreach (var item in carts)
            {
                Room r = _room.GetAll().Where(x => x.Id == item.RoomID).Include(h => h.Hotel).Include(rt => rt.RoomType).FirstOrDefault();
                dgvCart.Rows.Add(
                    r.Id,
                    r.Hotel.Name,
                    r.RoomType.Name,
                    r.Hotel.Address,
                    r.Capacity,
                    CalculateAverageRate(r.Id) + "/5",
                    (r.Quanity > 0) ? r.Quanity + " room" : "OutStock",
                    r.Price,
                    item.Quantity

                    );

            }
            cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();


        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtquantity.Text))
            {
                MessageBox.Show("Quantity cannot be empty");
            }
            else if (!int.TryParse(txtquantity.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity format");
            }
            else if (quantity < 0)
            {
                MessageBox.Show("Quantity must be greater than or equal to 0");
            }
            else if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Product ID cannot be empty");
            }
            else if (!int.TryParse(txtID.Text, out int productID))
            {
                MessageBox.Show("Invalid product ID format");
            }
            else if (quantity > _room.GetAll().Where(r => r.Id == productID).Select(f => f.Id).First())
            {
                MessageBox.Show("Quantity must < InStock of product");
            }
            else
            {

                _cart.UpdateQuantityCart(productID, quantity);
                MessageBox.Show("Quantity updated successfully");
                List<Carto> carts = _cart.getAllCart();
                dgvCart.Rows.Clear();
                dgvCart.Columns.Clear();
                dgvCart.Columns.Add("1", "ID");
                dgvCart.Columns.Add("1", "Hotel");
                dgvCart.Columns.Add("1", "Room Type");
                dgvCart.Columns.Add("1", "Address");
                dgvCart.Columns.Add("1", "Capacity");
                dgvCart.Columns.Add("1", "Rating");
                dgvCart.Columns.Add("1", "Status");
                dgvCart.Columns.Add("1", "Price");
                dgvCart.Columns.Add("1", "Quantity");
                foreach (var item in carts)
                {
                    Room r = _room.GetAll().Where(x => x.Id == item.RoomID).Include(h => h.Hotel).Include(rt => rt.RoomType).First();
                    dgvCart.Rows.Add(
                        r.Id,
                        r.Hotel.Name,
                        r.RoomType.Name,
                        r.Hotel.Address,
                        r.Capacity,
                        CalculateAverageRate(r.Id) + "/5",
                        (r.Quanity > 0) ? r.Quanity + " room" : "OutStock",
                        r.Price,
                        item.Quantity

                        );

                }
                cbRT.DataSource = _typeRoomRepository.GetAll().Select(rt => rt.Name).ToList();

            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = this.dgvCart.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txthoteil.Text = dgv.Cells[1].Value.ToString();
                cbRT.Text = dgv.Cells[2].Value.ToString();
                txtad.Text = dgv.Cells[3].Value.ToString();
                txtcapacity.Text = dgv.Cells[4].Value.ToString();
                txtrating.Text = dgv.Cells[5].Value.ToString();
                txtstatus.Text = dgv.Cells[6].Value.ToString();
                txtPrice.Text = dgv.Cells[7].Value.ToString();
                txtquantity.Text = dgv.Cells[8].Value.ToString();
            }
        }
    }
}
