using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class MarkRepository : Repository<Mark>, IMarkRepository
    {
        public MarkRepository(AlsDbContext context)
            : base(context)
        { }
    }
}
