using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee");

            builder.HasComment("Сотрудник");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.DateDecree)
                .HasColumnType("date")
                .HasColumnName("date_decree")
                .HasComment("Дата приказа");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name")
                .HasComment("ФИО");

            builder.Property(e => e.NumDecree)
                .HasColumnName("num_decree")
                .HasComment("Номер приказа");

            builder.Property(e => e.Post)
                .HasColumnName("post")
                .HasComment("Должность");

            builder.Property(e => e.Sector)
                .HasColumnName("sector")
                .HasComment("Участок");

            builder.HasOne(d => d.PostNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.Post)
                .HasConstraintName("FK_employee_cpost");

            builder.HasOne(d => d.SectorNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.Sector)
                .HasConstraintName("FK_employee_csector");
        }
    }
}
