using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class LiftModelRepository : Repository<LiftModel>, ILiftModelRepository
    {
        public LiftModelRepository(AlsDbContext context)
            : base(context)
        { }
}
}
