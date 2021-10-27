using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class AdditionalSpecification
    {
        public int Id { get; set; }
        public double? CabinRopeDiameter { get; set; }
        public double? CabinRopeLength { get; set; }
        public byte? CabinRopesAmount { get; set; }
        public double? OsRopeDiameter { get; set; }
        public double? OsRopeLength { get; set; }
        public short? Kvsh { get; set; }
        public byte? Security { get; set; }
    }
}
