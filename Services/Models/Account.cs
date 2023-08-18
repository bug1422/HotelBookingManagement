using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Account
    {
        public Account()
        {
            Bookings = new HashSet<Booking>();
            Hotels = new HashSet<Hotel>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public int Roleid { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
