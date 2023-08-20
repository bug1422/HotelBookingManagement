using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class BaseRepository<T> where T : class
    {
        BookingManagementContext _context;
        DbSet<T> _set;
        List<Carto> carts = new List<Carto>();

        public List<Carto> getAllCart() => carts.OrderByDescending(c => c.RoomID).ToList();

        public void UpdateQuantityCart(int id, int quantity)
        {
            Carto cartToUpdate = carts.FirstOrDefault(c => c.RoomID == id);

            if (cartToUpdate != null)
            {
                cartToUpdate.Quantity = quantity;
            }
        }

        public void DeleteCart(int id)
        {
            Carto cartToDelete = carts.FirstOrDefault(c => c.RoomID == id);
            if (cartToDelete != null)
            {
                carts.Remove(cartToDelete);
            }
        }

        //public void DeleteCartAll()
        //{
        //    carts.Clear();
        //}
        public bool AddCart(Carto c)
        {
            Carto cart = getCartID(c.RoomID);

            if (cart == null)
            {
                carts.Add(c);
                return true;
            }
            else
            {
                foreach (var item in carts)
                {
                    if (item.RoomID == c.RoomID)
                    {
                        item.Quantity++;
                        return true;
                        break;
                    }
                }
            }

            return false;

        }

        //public Boolean CheckCart(int fid)
        //{
        //    foreach (Cart c in carts)
        //    {
        //        if (c.flowerID == fid)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public Cart GetCart(int fid)
        //{
        //    Cart cart = new Cart();
        //    foreach (Cart c in carts)
        //    {
        //        if (c.flowerID == fid)
        //        {
        //            cart = c;
        //        }
        //    }
        //    return cart;
        //}

        public Carto getCartID(int id)
        {
            Carto c = carts.SingleOrDefault(project => project.RoomID == id);
            return c;
        }
        public BaseRepository() 
        {
            _context = new BookingManagementContext();
            _set = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _set.AsNoTracking();
        }

        public void Add(T item)
        {
            _set.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _set.Update(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _set.Remove(item);
            _context.SaveChanges();
        }

        public void UpdateList(List<T> items)
        {
            _set.UpdateRange(items);
            _context.SaveChanges();
        }

        public void DeleteList(List<T> items)
        {
            _set.RemoveRange(items);
            _context.SaveChanges();
        }
    }
}
