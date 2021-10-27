using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Request
    {
        public int Id { get; set; }
        public int Lift { get; set; }
        public DateTime DeliveryDate { get; set; }
        public short? Cause { get; set; }
        public byte? Trequest { get; set; }
        public int? EmployeeReport { get; set; }
        public DateTime? TransferDate { get; set; }
        public short? Damage { get; set; }
        public DateTime? RuntimeDate { get; set; }
        public int? EmployeeStart { get; set; }
        public int Dispatcher { get; set; }
        public int? EmployeeAccept { get; set; }
        public string CauseFloor { get; set; }
        public string DamageFloor { get; set; }
        public Guid? CauseGuid { get; set; }
        public Guid? DamageGuid { get; set; }

        public virtual CauseAndDamage CauseGu { get; set; }
        public virtual CauseAndDamage DamageGu { get; set; }
        public virtual Employee DispatcherNavigation { get; set; }
        public virtual Employee EmployeeAcceptNavigation { get; set; }
        public virtual Employee EmployeeReportNavigation { get; set; }
        public virtual Employee EmployeeStartNavigation { get; set; }
        public virtual Lift LiftNavigation { get; set; }
        public virtual RequestType TrequestNavigation { get; set; }
    }
}
