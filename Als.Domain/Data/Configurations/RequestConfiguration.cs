using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable("request");

            builder.HasComment("Заявка");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Cause)
                .HasColumnName("cause")
                .HasComment("Причина");

            builder.Property(e => e.CauseFloor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cause_floor")
                .IsFixedLength(true);

            builder.Property(e => e.CauseGuid).HasColumnName("causeGUID");

            builder.Property(e => e.Damage)
                .HasColumnName("damage")
                .HasComment("Поломка");

            builder.Property(e => e.DamageFloor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("damage_floor")
                .IsFixedLength(true);

            builder.Property(e => e.DamageGuid).HasColumnName("damageGUID");

            builder.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("delivery_date")
                .HasComment("Дата поступления");

            builder.Property(e => e.Dispatcher)
                .HasColumnName("dispatcher")
                .HasComment("Диспетчер");

            builder.Property(e => e.EmployeeAccept)
                .HasColumnName("employee_accept")
                .HasComment("Сотрудник принявший");

            builder.Property(e => e.EmployeeReport)
                .HasColumnName("employee_report")
                .HasComment("Сотрудник сообщивший");

            builder.Property(e => e.EmployeeStart)
                .HasColumnName("employee_start")
                .HasComment("Сотрудник запустивший");

            builder.Property(e => e.Lift)
                .HasColumnName("lift")
                .HasComment("Лифт");

            builder.Property(e => e.RuntimeDate)
                .HasColumnType("datetime")
                .HasColumnName("runtime_date")
                .HasComment("Дата выполнения");

            builder.Property(e => e.TransferDate)
                .HasColumnType("datetime")
                .HasColumnName("transfer_date")
                .HasComment("Дата передачи механику");

            builder.Property(e => e.Trequest)
                .HasColumnName("trequest")
                .HasComment("Тип заявки");

            builder.HasOne(d => d.CauseGu)
                .WithMany(p => p.RequestCauseGus)
                .HasForeignKey(d => d.CauseGuid)
                .HasConstraintName("FK_request_CauseAndDamage(Cause)");

            builder.HasOne(d => d.DamageGu)
                .WithMany(p => p.RequestDamageGus)
                .HasForeignKey(d => d.DamageGuid)
                .HasConstraintName("FK_request_CauseAndDamage(Damage)");

            builder.HasOne(d => d.DispatcherNavigation)
                .WithMany(p => p.RequestDispatcherNavigations)
                .HasForeignKey(d => d.Dispatcher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_request_employee");

            builder.HasOne(d => d.EmployeeAcceptNavigation)
                .WithMany(p => p.RequestEmployeeAcceptNavigations)
                .HasForeignKey(d => d.EmployeeAccept)
                .HasConstraintName("FK_request_employee3");

            builder.HasOne(d => d.EmployeeReportNavigation)
                .WithMany(p => p.RequestEmployeeReportNavigations)
                .HasForeignKey(d => d.EmployeeReport)
                .HasConstraintName("FK_request_employee2");

            builder.HasOne(d => d.EmployeeStartNavigation)
                .WithMany(p => p.RequestEmployeeStartNavigations)
                .HasForeignKey(d => d.EmployeeStart)
                .HasConstraintName("FK_request_employee1");

            builder.HasOne(d => d.LiftNavigation)
                .WithMany(p => p.Requests)
                .HasForeignKey(d => d.Lift)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_request_lift");

            builder.HasOne(d => d.TrequestNavigation)
                .WithMany(p => p.Requests)
                .HasForeignKey(d => d.Trequest)
                .HasConstraintName("FK_request_type_request");
        }
    }
}
