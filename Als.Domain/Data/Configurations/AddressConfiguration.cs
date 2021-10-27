using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.HasComment("Адрес");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.PorchesAmount)
                .HasColumnName("col_porch")
                .HasComment("Количество подъездов");

            builder.Property(e => e.House)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("house")
                .HasComment("Дом");

            builder.Property(e => e.Place)
                .HasColumnName("place")
                .HasComment("Район города");

            builder.Property(e => e.Street)
                .HasColumnName("street")
                .HasComment("Улица");

            builder.HasOne(d => d.PlaceNavigation)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Place)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_address_address");

            builder.HasOne(d => d.StreetNavigation)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Street)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_address_cstreet");
        }
    }
}
