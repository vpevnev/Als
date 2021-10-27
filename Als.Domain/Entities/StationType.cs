using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class StationType : MechanicalPartType
    {
        public StationType()
        {
            Lifts = new HashSet<Lift>();
        }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
