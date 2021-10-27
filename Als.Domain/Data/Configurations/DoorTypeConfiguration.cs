using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class DoorTypeConfiguration : IEntityTypeConfiguration<DoorType>
    {
        public void Configure(EntityTypeBuilder<DoorType> builder)
        {
            builder.ToTable("type_door");

            builder.HasComment("Тип дверей");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(e => e.Abb)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("abb")
                .HasComment("Аббревиатура");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tdoor")
                .HasComment("Тип дверей");
        }
    }
}
