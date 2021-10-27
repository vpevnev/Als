using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class PrefixConfiguration : IEntityTypeConfiguration<Cprefix>
    {
        public void Configure(EntityTypeBuilder<Cprefix> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
