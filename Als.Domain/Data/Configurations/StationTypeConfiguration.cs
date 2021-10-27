using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class StationTypeConfiguration : IEntityTypeConfiguration<StationType>
    {
        public void Configure(EntityTypeBuilder<StationType> builder)
        {
            builder.ToTable("type_station");

            builder.HasComment("Тип станции");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tstation")
                .HasComment("Тип станции");
        }
    }
}
