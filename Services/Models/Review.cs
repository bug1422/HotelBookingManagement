using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int Roomid { get; set; }
        public int Bookingid { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }
    }
}
