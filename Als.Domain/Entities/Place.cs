using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Place
    {
        public Place()
        {
            Addresses = new HashSet<Address>();
        }

        public byte Id { get; set; }
        public string Area { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
