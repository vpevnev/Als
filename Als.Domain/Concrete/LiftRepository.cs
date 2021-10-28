using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class LiftRepository : Repository<Lift>, ILiftRepository
    {
        public LiftRepository(AlsDbContext context)
            : base(context)
        { }
    }
}
