using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Cprefix
    {
        public Cprefix()
        {
            Cstreets = new HashSet<Street>();
        }

        public byte Id { get; set; }
        public string Prefix { get; set; }
        public string Abb { get; set; }

        public virtual ICollection<Street> Cstreets { get; set; }
    }
}
