using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class RequestRepository : Repository<Request>, IRequestRepository
    {
        public RequestRepository(AlsDbContext context)
            : base(context)
        { }
}
}
