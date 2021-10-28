using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class PlaceRepository : Repository<Place>, IPlaceRepository
    {
        public PlaceRepository(AlsDbContext context)
            : base(context)
        { }
}
}
