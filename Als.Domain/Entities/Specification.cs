using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Specification
    {
        public Specification()
        {
            Lifts = new HashSet<Lift>();
        }

        public int Id { get; set; }
        public byte Lift { get; set; }
        public byte Door { get; set; }
        public double? Speed { get; set; }
        public short? Capacity { get; set; }

        public virtual DoorType DoorNavigation { get; set; }
        public virtual LiftType LiftNavigation { get; set; }
        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
