using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class SectorRepository : Repository<Sector>, ISectorRepository
    {
        public SectorRepository(AlsDbContext context)
            : base(context)
        { }
}
}
