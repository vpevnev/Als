using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class CauseAndDamage
    {
        public CauseAndDamage()
        {
            RequestCauseGus = new HashSet<Request>();
            RequestDamageGus = new HashSet<Request>();
        }

        public Guid Id { get; set; }
        public string Value { get; set; }
        public bool IsCause { get; set; }
        public bool IsDamage { get; set; }
        public bool? DamageType { get; set; }

        public virtual ICollection<Request> RequestCauseGus { get; set; }
        public virtual ICollection<Request> RequestDamageGus { get; set; }
    }
}
