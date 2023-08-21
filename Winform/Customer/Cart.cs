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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dropbox.Api.Common.PathRoot;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Winform
{
    public partial class Cart : Form
    {
        private CartRepository _cart = new CartRepository();
        private AccountRepository _account = new AccountRepository();
        private RoomRepository _room = new RoomRepository();
        private ReviewRepository _review = new ReviewRepository();
        private TypeRoomRepository _typeRoomRepository = new TypeRoomRepository();
        Account account = null;
        List<int> list = new List<int>();
        public Cart(Account a)
        {
            account = a;
            InitializeComponent();
            LoadCart();
        }
        public void scrollbar_handle()
        {

        }

        public void LoadCart()
        {
            cartFlow.Controls.Clear();
            int width = cartFlow.Width - 20;
            int height = cartFlow.Height;
            int x = cartFlow.Location.X, y = cartFlow.Location.Y;
            foreach (var item in getFromCart())
            {
                int roomId = int.Parse(item.Split("-").ToList()[1]);
                var room = _room.GetAll().Include(p => p.Hotel).FirstOrDefault(p => p.Id == roomId);
                CheckBox select = new CheckBox();
                select.Size = new Size(25, height / 6);
                select.Location = new Point(x, y);
                select.Click += (s, e) =>
                {
                    if (select.Checked) list.Add(roomId);
                    else list.Remove(roomId);
                    ListHandler();
                };
                Label name = new Label();
                name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                name.Text = "Room " + room.RoomNumber;
                name.Width = width / 9;
                name.Height = height / 6;
                name.Padding = new Padding(0, 5, 0, 5);
                Label hotel = new Label();
                hotel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                hotel.Text = room.Hotel.Name + " Hotel - " + room.Hotel.Address;
                hotel.Location = new Point(width, height);
                hotel.Width = width / 2;
                hotel.Height = height / 6;
                hotel.Padding = new Padding(0, 5, 0, 5);
                Button detail = new Button();
                detail.Size = new Size(width / 7, height / 7);
                detail.Padding = new Padding(50, 5, 50, 5);
                detail.Text = "See details";
                detail.Click += (s, e) =>
                {
                    Form f = new ProductDetail(account, roomId);
                    f.ShowDialog();
                };
                Label t = new Label();
                t.Size = new Size(width / 5, height / 6);
                cartFlow.Controls.Add(select);
                cartFlow.Controls.Add(name);
                cartFlow.Controls.Add(hotel);
                cartFlow.Controls.Add(detail);
                cartFlow.Controls.Add(t);
                cartFlow.VerticalScroll.Enabled = true;
            }

        }

        private void ListHandler()
        {
            if (list.Any())
            {
                checkout.Text = "Check out " + list.Count.ToString() + (list.Count > 0 ? " rooms" : " room");
                remove.Text = "Remove " + list.Count.ToString() + (list.Count > 0 ? " rooms" : " room");
            }
            else
            {
                checkout.Text = "Check out";
                remove.Text = "Remove";
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (list.Any())
            {
                Form f = new Checkout(account, list);
                f.ShowDialog();
                LoadCart();
            }
            else
            {
                MessageBox.Show("You haven't selected any room");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (list.Any())
            {
                var confirmResult = MessageBox.Show("Are you sure to remove these items out of your cart?", "",
                                     MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes) return;
                foreach (int id in list)
                {
                    removeFromCart(id);
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any room");
            }
            LoadCart();
        }

        private List<String> getFromCart()
        {
            List<string> cart = new List<string>();
            var fileName = GetDirectory.TryGetSolutionDirectoryInfo().FullName + "\\cart.txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    // Open the stream and read it back.    
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            cart.Add(s);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can't get from cart");
            }
            return cart;
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
                MessageBox.Show("Removed from cart");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadCart();
        }
    }
}
