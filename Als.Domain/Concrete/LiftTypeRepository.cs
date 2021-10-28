using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class LiftTypeRepository : Repository<LiftType>, ILiftTypeRepository
    {
        public LiftTypeRepository(AlsDbContext context)
            : base(context)
        { }
    }
}
