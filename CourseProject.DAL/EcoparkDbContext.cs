using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CourseProject.DAL
{
    public partial class EcoparkDbContext : DbContext
    {
        public EcoparkDbContext()
            : base("name=EcoparkDbContext")
        {
        }

        public virtual DbSet<Agreement> Agreement { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseCategory> HouseCategory { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceList> ServiceList { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<Work> Work { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agreement>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Agreement>()
                .HasMany(e => e.House)
                .WithMany(e => e.Agreement)
                .Map(m => m.ToTable("AgreementHouseList").MapLeftKey("IDAgreement").MapRightKey("IDHouse"));

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shift)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.IDAdmin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shift1)
                .WithRequired(e => e.Employee1)
                .HasForeignKey(e => e.IDEmployeeOnReception)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shift2)
                .WithRequired(e => e.Employee2)
                .HasForeignKey(e => e.IDFirstCleaner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shift3)
                .WithRequired(e => e.Employee3)
                .HasForeignKey(e => e.IDSecondCleaner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shift4)
                .WithRequired(e => e.Employee4)
                .HasForeignKey(e => e.IDThirdCleaner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Visit)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.IDEmployeeOnReception)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HouseCategory>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HouseCategory>()
                .HasMany(e => e.House)
                .WithRequired(e => e.HouseCategory)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceList)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Agreement)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.IDCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Visit)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visit>()
                .HasMany(e => e.ServiceList)
                .WithRequired(e => e.Visit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Work>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Work1)
                .HasForeignKey(e => e.Work)
                .WillCascadeOnDelete(false);
        }
    }
}
