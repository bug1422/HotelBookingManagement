using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class BookingDetail
    {
        public int Bookingid { get; set; }
        public DateTime Checindate { get; set; }
        public DateTime Checkoutdate { get; set; }
        public double Price { get; set; }
        public int Roomid { get; set; }
        public int Customerid { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }
    }
}
