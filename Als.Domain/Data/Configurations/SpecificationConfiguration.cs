using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class SpecificationConfiguration : IEntityTypeConfiguration<Specification>
    {
        public void Configure(EntityTypeBuilder<Specification> builder)
        {
            builder.ToTable("tech_specif");

            builder.HasComment("Технические характеристики лифта");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Capacity)
                .HasColumnName("capacity")
                .HasComment("Грузоподъемность");

            builder.Property(e => e.Door)
                .HasColumnName("door")
                .HasComment("Тип дверей");

            builder.Property(e => e.Lift)
                .HasColumnName("lift")
                .HasComment("Тип лифта");

            builder.Property(e => e.Speed)
                .HasColumnName("speed")
                .HasComment("Скорость");

            builder.HasOne(d => d.DoorNavigation)
                .WithMany(p => p.TechSpecifs)
                .HasForeignKey(d => d.Door)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tech_specif_type_door");

            builder.HasOne(d => d.LiftNavigation)
                .WithMany(p => p.TechSpecifs)
                .HasForeignKey(d => d.Lift)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tech_specif_type_lift");
        }
    }
}
