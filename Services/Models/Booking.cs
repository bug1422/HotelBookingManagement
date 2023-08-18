using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
            Payments = new HashSet<Payment>();
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public int Customerid { get; set; }
        public int Hotelid { get; set; }
        public DateTime Bookingdate { get; set; }
        public double Totalprice { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public string Phone { get; set; }

        public virtual Account Customer { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
