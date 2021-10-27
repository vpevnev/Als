using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Mark
    {
        public Mark()
        {
            Lifts = new HashSet<Lift>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
