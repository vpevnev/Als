using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class StreetPrefixConfiguration : IEntityTypeConfiguration<StreetPrefix>
    {
        public void Configure(EntityTypeBuilder<StreetPrefix> builder)
        {
            builder.ToTable("cprefix");

            builder.HasComment("Префикс");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(e => e.Abb)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("abb")
                .HasComment("Сокращение");

            builder.Property(e => e.Prefix)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prefix")
                .HasComment("Префикс");
        }
    }
}
