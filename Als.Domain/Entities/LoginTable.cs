using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class LoginTable
    {
        public byte Id { get; set; }
        public string UserNameForLogin { get; set; }
        public int EmployeeName { get; set; }

        public virtual Employee EmployeeNameNavigation { get; set; }
    }
}
