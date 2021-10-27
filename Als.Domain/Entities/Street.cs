using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Street
    {
        public Street()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public byte Prefix { get; set; }

        public virtual Cprefix PrefixNavigation { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
