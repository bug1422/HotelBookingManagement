using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? Ownerid { get; set; }

        public virtual Account Owner { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
