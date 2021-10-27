using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Lifts = new HashSet<Lift>();
        }

        public int Id { get; set; }
        public string Factory { get; set; }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
