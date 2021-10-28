using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class DoorTypeRepository : Repository<DoorType>, IDoorTypeRepository
    {
        public DoorTypeRepository(AlsDbContext context)
            : base(context)
        { }
    }
}
