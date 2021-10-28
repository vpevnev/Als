using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class EngineTypeRepository : Repository<EngineType>, IEngineTypeRepository
    {
        public EngineTypeRepository(AlsDbContext context)
            : base(context)
        { }
}
}
