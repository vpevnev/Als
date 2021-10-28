using Als.Domain.Abstract;
using Als.Domain.Data;
using Als.Domain.Entities;

namespace Als.Domain.Concrete
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AlsDbContext context)
            : base(context)
        { }
}
}
