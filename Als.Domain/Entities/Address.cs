using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Address
    {
        public Address()
        {
            Lifts = new HashSet<Lift>();
        }

        public int Id { get; set; }
        public byte Place { get; set; }
        public int Street { get; set; }
        public string House { get; set; }
        public byte? PorchesAmount { get; set; }

        public virtual Place PlaceNavigation { get; set; }
        public virtual Street StreetNavigation { get; set; }
        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
