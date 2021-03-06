using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class LiftModelConfiguration : IEntityTypeConfiguration<LiftModel>
    {
        public void Configure(EntityTypeBuilder<LiftModel> builder)
        {
            builder.ToTable("cmodel");

            builder.HasComment("Каталог моделей");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("model")
                .HasComment("Модель");
        }
    }
}
