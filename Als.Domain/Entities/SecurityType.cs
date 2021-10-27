using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class SecurityType
    {
        public SecurityType()
        {
            Lifts = new HashSet<Lift>();
        }

        public byte Id { get; set; }
        public string Protection { get; set; }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
