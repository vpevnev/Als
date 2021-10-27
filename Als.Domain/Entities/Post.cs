using System.Collections.Generic;

#nullable disable

namespace Als.Domain.Entities
{
    public partial class Post
    {
        public Post()
        {
            Employees = new HashSet<Employee>();
            Owners = new HashSet<Owner>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string OrganizationType { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
