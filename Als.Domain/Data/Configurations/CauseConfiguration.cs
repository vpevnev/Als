using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class CauseConfiguration : IEntityTypeConfiguration<Cause>
    {
        public void Configure(EntityTypeBuilder<Cause> builder)
        {
            builder.HasKey(e => e.Guid);

            builder.ToTable("ccause");

            builder.HasComment("Причина");

            builder.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("guid");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cause")
                .HasComment("Причина");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        }
    }
}
