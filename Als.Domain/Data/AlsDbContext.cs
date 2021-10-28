using Als.Domain.Data.Configurations;
using Als.Domain.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Als.Domain.Data
{
    public partial class AlsDbContext : DbContext
    {
        public AlsDbContext(DbContextOptions<AlsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalSpecification> AdditionalSpecifications { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Cause> Causes { get; set; }
        public virtual DbSet<CauseAndDamage> CauseAndDamages { get; set; }
        public virtual DbSet<Damage> Damages { get; set; }
        public virtual DbSet<DoorType> DoorTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EngineType> EngineTypes { get; set; }
        public virtual DbSet<Lift> Lifts { get; set; }
        public virtual DbSet<LiftModel> LiftModels { get; set; }
        public virtual DbSet<LiftType> LiftTypes { get; set; }
        public virtual DbSet<LoginTable> LoginTables { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SecurityType> SecurityTypes { get; set; }
        public virtual DbSet<Specification> Specifications { get; set; }
        public virtual DbSet<StationType> StationTypes { get; set; }
        public virtual DbSet<StreetPrefix> StreetPrefixes { get; set; }
        public virtual DbSet<Street> Streets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.ApplyConfiguration(new AdditionalSpecificationConfiguration());

            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            
            modelBuilder.ApplyConfiguration(new CauseConfiguration());

            modelBuilder.Entity<CauseAndDamage>(entity =>
            {
                entity.ToTable("CauseAndDamage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DamageType).HasColumnName("damageType");

                entity.Property(e => e.IsCause).HasColumnName("isCause");

                entity.Property(e => e.IsDamage).HasColumnName("isDamage");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.ApplyConfiguration(new DamageConfiguration());

            modelBuilder.ApplyConfiguration(new DoorTypeConfiguration());

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            modelBuilder.ApplyConfiguration(new EngineTypeConfiguration());

            modelBuilder.ApplyConfiguration(new LiftConfiguration());

            modelBuilder.ApplyConfiguration(new LiftModelConfiguration());

            modelBuilder.ApplyConfiguration(new LiftTypeConfiguration());

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.ToTable("login_table");

                entity.HasComment("Авторизация");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasComment("ФИО сотрудника");

                entity.Property(e => e.UserNameForLogin)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("user_name_for_login")
                    .HasComment("Имя пользователя");

                entity.HasOne(d => d.EmployeeNameNavigation)
                    .WithMany(p => p.LoginTables)
                    .HasForeignKey(d => d.EmployeeName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_login_table_login_table");
            });

            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());

            modelBuilder.ApplyConfiguration(new MarkConfiguration());

            modelBuilder.ApplyConfiguration(new OwnerConfiguration());

            modelBuilder.ApplyConfiguration(new PlaceConfiguration());

            modelBuilder.ApplyConfiguration(new PostConfiguration());

            modelBuilder.ApplyConfiguration(new RequestConfiguration());

            modelBuilder.ApplyConfiguration(new RequestTypeConfiguration());

            modelBuilder.ApplyConfiguration(new SectorConfiguration());

            modelBuilder.ApplyConfiguration(new SecurityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new SpecificationConfiguration());

            modelBuilder.ApplyConfiguration(new StationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new StreetConfiguration());

            modelBuilder.ApplyConfiguration(new StreetPrefixConfiguration());
        }
    }
}
