using System;
using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class RequestType
    {
        public RequestType()
        {
            Requests = new HashSet<Request>();
        }

        public byte Id { get; set; }
        public string Trequest { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
