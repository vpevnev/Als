using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class SecurityTypeConfiguration : IEntityTypeConfiguration<SecurityType>
    {
        public void Configure(EntityTypeBuilder<SecurityType> builder)
        {
            builder.ToTable("security");

            builder.HasComment("Защита");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(e => e.Protection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protection")
                .HasComment("Защита");
        }
    }
}
