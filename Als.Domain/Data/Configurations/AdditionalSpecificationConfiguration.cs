using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class AdditionalSpecificationConfiguration : IEntityTypeConfiguration<AdditionalSpecification>
    {
        public void Configure(EntityTypeBuilder<AdditionalSpecification> builder)
        {
            builder.ToTable("dop_tech_specif");

            builder.HasComment("Дополнительные характеристики");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.CabinRopesAmount)
                .HasColumnName("crope_cab")
                .HasComment("Количество канатов кабины");

            builder.Property(e => e.CabinRopeDiameter)
                .HasColumnName("drope_cab")
                .HasComment("Диаметр каната кабины");

            builder.Property(e => e.OsRopeDiameter)
                .HasColumnName("drope_os")
                .HasComment("Диаметр каната Ограничителя Скорости");

            builder.Property(e => e.Kvsh)
                .HasColumnName("kvsh")
                .HasComment("КанатоВедущий Шкив");

            builder.Property(e => e.CabinRopeLength)
                .HasColumnName("lrope_cab")
                .HasComment("Длина каната кабины");

            builder.Property(e => e.OsRopeLength)
                .HasColumnName("lrope_os")
                .HasComment("Длина каната Ограничителя Скорости");

            builder.Property(e => e.Security)
                .HasColumnName("security")
                .HasComment("Защита проникновения в шахту");
        }
    }
}
