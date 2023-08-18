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
