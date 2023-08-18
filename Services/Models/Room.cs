using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Room
    {
        public Room()
        {
            BookingDetails = new HashSet<BookingDetail>();
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public int Hotelid { get; set; }
        public int RoomNumber { get; set; }
        public int RoomTypeId { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int Available { get; set; }
        public string Images { get; set; }
        public int? Quanity { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual TypeRoom RoomType { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
