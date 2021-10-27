using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Cause
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
    }
}
