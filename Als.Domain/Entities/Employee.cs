using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Lifts = new HashSet<Lift>();
            LoginTables = new HashSet<LoginTable>();
            RequestDispatcherNavigations = new HashSet<Request>();
            RequestEmployeeAcceptNavigations = new HashSet<Request>();
            RequestEmployeeReportNavigations = new HashSet<Request>();
            RequestEmployeeStartNavigations = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short? NumDecree { get; set; }
        public DateTime? DateDecree { get; set; }
        public byte? Post { get; set; }
        public byte? Sector { get; set; }

        public virtual Post PostNavigation { get; set; }
        public virtual Sector SectorNavigation { get; set; }
        public virtual ICollection<Lift> Lifts { get; set; }
        public virtual ICollection<LoginTable> LoginTables { get; set; }
        public virtual ICollection<Request> RequestDispatcherNavigations { get; set; }
        public virtual ICollection<Request> RequestEmployeeAcceptNavigations { get; set; }
        public virtual ICollection<Request> RequestEmployeeReportNavigations { get; set; }
        public virtual ICollection<Request> RequestEmployeeStartNavigations { get; set; }
    }
}
