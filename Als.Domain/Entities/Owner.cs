using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Owner
    {
        public Owner()
        {
            Lifts = new HashSet<Lift>();
        }

        public short Id { get; set; }
        public string Org { get; set; }
        public string Director { get; set; }
        public string Phone { get; set; }
        public string FullOrg { get; set; }
        public string ContactPerson { get; set; }
        public byte? Post { get; set; }
        public string ContactPhone { get; set; }

        public virtual Post PostNavigation { get; set; }
        public virtual ICollection<Lift> Lifts { get; set; }
    }
}
