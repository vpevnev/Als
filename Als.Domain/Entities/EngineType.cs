using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class EngineType : MechanicalPartType
    {
        public EngineType()
        {
            Lifts = new HashSet<Lift>();
        }

        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
