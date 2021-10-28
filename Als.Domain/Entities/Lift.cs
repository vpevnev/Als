using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Lift
    {
        public Lift()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string RegNum { get; set; }
        public int? TechSpecif { get; set; }
        public DateTime? StartUpDate { get; set; }
        public int? Address { get; set; }
        public byte? Porch { get; set; }
        public short? Owner { get; set; }
        public int? Mechanic { get; set; }
        public string InspectionDate { get; set; }
        public int? Manufacturer { get; set; }
        public byte? Station { get; set; }
        public byte? Engine { get; set; }
        public byte? StopNum { get; set; }
        public double? DropeCab { get; set; }
        public double? LropeCab { get; set; }
        public byte? CropeCab { get; set; }
        public double? DropeOs { get; set; }
        public double? LropeOs { get; set; }
        public short? Kvsh { get; set; }
        public byte? Security { get; set; }
        public DateTime? DiagnosticsDate { get; set; }
        public short? Model { get; set; }
        public string FactoryNum { get; set; }
        public string ManufactureDate { get; set; }
        public byte? MropeCab { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual EngineType EngineNavigation { get; set; }
        public virtual Manufacturer ManufacturerNavigation { get; set; }
        public virtual Employee MechanicNavigation { get; set; }
        public virtual LiftModel ModelNavigation { get; set; }
        public virtual Mark MropeCabNavigation { get; set; }
        public virtual Owner OwnerNavigation { get; set; }
        public virtual SecurityType SecurityNavigation { get; set; }
        public virtual StationType StationNavigation { get; set; }
        public virtual Specification TechSpecifNavigation { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
