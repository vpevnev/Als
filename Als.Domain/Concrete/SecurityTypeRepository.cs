using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class SecurityTypeRepository : Repository<SecurityType>, ISecurityTypeRepository
    {
        public SecurityTypeRepository(AlsDbContext context)
            : base(context)
        { }
}
}
