using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class DamageConfiguration : IEntityTypeConfiguration<Damage>
    {
        public void Configure(EntityTypeBuilder<Damage> builder)
        {
            builder.ToTable("cdamage");

            builder.HasComment("Поломка");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("damage")
                .HasComment("Поломка");

            builder.Property(e => e.Guid).HasColumnName("guid");

            builder.Property(e => e.DamageType)
                .HasColumnName("tdamage")
                .HasComment("Тех-ая или нетех-ая поломка, по умолчанию 0 - нетех-ая");
        }
    }
}
