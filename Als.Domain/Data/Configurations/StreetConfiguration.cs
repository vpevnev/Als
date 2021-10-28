using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class StreetConfiguration : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.ToTable("cstreet");

            builder.HasComment("Улица");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Prefix)
                .HasColumnName("prefix")
                .HasComment("Префикс");

            builder.Property(e => e.StreetName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("str_name")
                .HasComment("Название");

            builder.HasOne(d => d.PrefixNavigation)
                .WithMany(p => p.Streets)
                .HasForeignKey(d => d.Prefix)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cstreet_cprefix");
        }
    }
}
