using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TypeRoom
    {
        public TypeRoom()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
