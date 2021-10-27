using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Als.Domain.Data.Configurations
{
    public class LiftConfiguration : IEntityTypeConfiguration<Lift>
    {
        public void Configure(EntityTypeBuilder<Lift> builder)
        {
            builder.ToTable("lift");

            builder.HasComment("Лифт");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Address)
                .HasColumnName("address")
                .HasComment("Адрес");

            builder.Property(e => e.CropeCab)
                .HasColumnName("crope_cab")
                .HasComment("Кол-во канатов кабины");

            builder.Property(e => e.DiagnosticsDate)
                .HasColumnType("date")
                .HasColumnName("diagnostics_date")
                .HasComment("Дата диагностики");

            builder.Property(e => e.DropeCab)
                .HasColumnName("drope_cab")
                .HasComment("Диаметр каната кабины");

            builder.Property(e => e.DropeOs)
                .HasColumnName("drope_os")
                .HasComment("Диаметр каната Ограничителя Скорости");

            builder.Property(e => e.Engine)
                .HasColumnName("engine")
                .HasComment("Тип двигателя");

            builder.Property(e => e.FactoryNum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("factory_num")
                .HasComment("Заводской номер");

            builder.Property(e => e.InspectionDate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("inspection_date")
                .HasComment("Дата освидетельствования");

            builder.Property(e => e.Kvsh)
                .HasColumnName("kvsh")
                .HasComment("КанатоВедущий Шкив");

            builder.Property(e => e.LropeCab)
                .HasColumnName("lrope_cab")
                .HasComment("Длина каната кабины");

            builder.Property(e => e.LropeOs)
                .HasColumnName("lrope_os")
                .HasComment("Длина каната Ограничителя Скорости");

            builder.Property(e => e.ManufactureDate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("manufacture_date")
                .HasComment("Дата изготовления");

            builder.Property(e => e.Manufacturer)
                .HasColumnName("manufacturer")
                .HasComment("Производитель");

            builder.Property(e => e.Mechanic)
                .HasColumnName("mechanic")
                .HasComment("Механик");

            builder.Property(e => e.Model)
                .HasColumnName("model")
                .HasComment("Модель");

            builder.Property(e => e.MropeCab)
                .HasColumnName("mrope_cab")
                .HasComment("Марка каната кабины");

            builder.Property(e => e.Owner)
                .HasColumnName("owner")
                .HasComment("Владелец");

            builder.Property(e => e.Porch)
                .HasColumnName("porch")
                .HasComment("Подъезд");

            builder.Property(e => e.RegNum)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reg_num")
                .HasComment("Регистрационный номер");

            builder.Property(e => e.Security)
                .HasColumnName("security")
                .HasComment("Защита");

            builder.Property(e => e.StartUpDate)
                .HasColumnType("date")
                .HasColumnName("start_up_date")
                .HasComment("Дата ввода в эксплуатацию");

            builder.Property(e => e.Station)
                .HasColumnName("station")
                .HasComment("Тип станции");

            builder.Property(e => e.StopNum)
                .HasColumnName("stop_num")
                .HasComment("Кол-во остановок (этажей)");

            builder.Property(e => e.TechSpecif)
                .HasColumnName("tech_specif")
                .HasComment("Технические характеристики");

            builder.HasOne(d => d.AddressNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Address)
                .HasConstraintName("FK_lift_address");

            builder.HasOne(d => d.EngineNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Engine)
                .HasConstraintName("FK_lift_type_engine");

            builder.HasOne(d => d.ManufacturerNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Manufacturer)
                .HasConstraintName("FK_lift_manufacturer");

            builder.HasOne(d => d.MechanicNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Mechanic)
                .HasConstraintName("FK_lift_employee");

            builder.HasOne(d => d.ModelNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Model)
                .HasConstraintName("FK_lift_cmodel");

            builder.HasOne(d => d.MropeCabNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.MropeCab)
                .HasConstraintName("FK_lift_cmark");

            builder.HasOne(d => d.OwnerNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Owner)
                .HasConstraintName("FK_lift_owner");

            builder.HasOne(d => d.SecurityNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Security)
                .HasConstraintName("FK_lift_security");

            builder.HasOne(d => d.StationNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.Station)
                .HasConstraintName("FK_lift_type_station");

            builder.HasOne(d => d.TechSpecifNavigation)
                .WithMany(p => p.Lifts)
                .HasForeignKey(d => d.TechSpecif)
                .HasConstraintName("FK_lift_tech_specif");
        }
    }
}
