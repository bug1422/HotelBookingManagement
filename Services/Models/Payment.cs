using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int Bookingid { get; set; }
        public int Bycash { get; set; }
        public DateTime Transactiondate { get; set; }
        public int Customerid { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
