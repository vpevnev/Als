using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class DoorType : MechanicalPartType
    {
        public DoorType()
        {
            TechSpecifs = new HashSet<Specification>();
        }

        public string Abb { get; set; }

        public virtual ICollection<Specification> TechSpecifs { get; set; }
    }
}
