using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class StationTypeRepository : Repository<StationType>, IStationTypeRepository
    {
        public StationTypeRepository(AlsDbContext context)
            : base (context)
        { }
    }
}
