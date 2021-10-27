using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("owner");

            builder.HasComment("Владелец");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.ContactPerson)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("contact_person")
                .HasComment("Контактное лицо");

            builder.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_phone")
                .HasComment("Контактный номер");

            builder.Property(e => e.Director)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("director")
                .HasComment("Директор");

            builder.Property(e => e.FullOrg)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("full_org")
                .HasComment("Полное наименование");

            builder.Property(e => e.Org)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("org")
                .HasComment("Организация");

            builder.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone")
                .HasComment("Телефон");

            builder.Property(e => e.Post)
                .HasColumnName("post")
                .HasComment("Должность");

            builder.HasOne(d => d.PostNavigation)
                .WithMany(p => p.Owners)
                .HasForeignKey(d => d.Post)
                .HasConstraintName("FK_owner_cpost");
        }
    }
}
