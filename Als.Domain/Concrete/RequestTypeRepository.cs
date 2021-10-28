using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class RequestTypeRepository : Repository<RequestType>, IRequestTypeRepository
    {
        public RequestTypeRepository(AlsDbContext context)
            : base(context)
        { }
}
}
