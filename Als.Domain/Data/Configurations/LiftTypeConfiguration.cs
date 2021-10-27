using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class LiftTypeConfiguration : IEntityTypeConfiguration<LiftType>
    {
        public void Configure(EntityTypeBuilder<LiftType> builder)
        {
            builder.ToTable("type_lift");

            builder.HasComment("тип лифта");

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
                .HasColumnName("tlift")
                .HasComment("Тип лифта");
        }
    }
}
