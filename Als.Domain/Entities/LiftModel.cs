using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class LiftModel
    {
        public LiftModel()
        {
            Lifts = new HashSet<Lift>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
