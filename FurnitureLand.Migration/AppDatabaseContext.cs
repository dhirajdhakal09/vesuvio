using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FurnitureLand.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureLand.DatabaseMigration
{
    public class AppDatabaseContext : IdentityDbContext<Customers, Roles, Guid>
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Catalogs>(ConfigureCatalog);
            modelBuilder.Entity<Colors>(ConfigureColors);
            modelBuilder.Entity<Materials>(ConfigureMaterials);
            modelBuilder.Entity<CustomerTypes>(ConfigureCustomerTypes);
        }

        private void ConfigureCatalog(EntityTypeBuilder<Catalogs> builder)
        {
            builder.HasData
               (
                   new Catalogs
                   {
                       Id = Guid.NewGuid(),
                       Name = "Desks"
                   },
                   new Catalogs
                   {
                       Id = Guid.NewGuid(),
                       Name = "Chairs"
                   },
                   new Catalogs
                   {
                       Id = Guid.NewGuid(),
                       Name = "Tables"
                   },
                   new Catalogs
                   {
                       Id = Guid.NewGuid(),
                       Name = "File-Cabinets"
                   }
               );
        }

        private void ConfigureColors(EntityTypeBuilder<Colors> builder)
        {
            builder.HasData
               (
                   new Colors
                   {
                       Id = Guid.NewGuid(),
                       Name = "Red"
                   },
                   new Colors
                   {
                       Id = Guid.NewGuid(),
                       Name = "Green"
                   },
                   new Colors
                   {
                       Id = Guid.NewGuid(),
                       Name = "Blue",
                   },
                   new Colors
                   {
                       Id = Guid.NewGuid(),
                       Name = "Yellow"
                   }
               );
        }

        private void ConfigureCustomerTypes(EntityTypeBuilder<CustomerTypes> builder)
        {
            builder.HasData
               (
                   new CustomerTypes
                   {
                       Id = Guid.NewGuid(),
                       Name = "Corporate"
                   },
                   new CustomerTypes
                   {
                       Id = Guid.NewGuid(),
                       Name = "Home/Office"
                   },
                   new CustomerTypes
                   {
                       Id = Guid.NewGuid(),
                       Name = "Student",
                   }
               );
        }

        private void ConfigureMaterials(EntityTypeBuilder<Materials> builder)
        {
            builder.HasData
               (
                   new Materials
                   {
                       Id = Guid.NewGuid(),
                       Name = "Pine"
                   },
                   new Materials
                   {
                       Id = Guid.NewGuid(),
                       Name = "Milo"
                   },
                   new Materials
                   {
                       Id = Guid.NewGuid(),
                       Name = "Fiber",
                   }
               );
        }

        public virtual DbSet<Buyers> Buyers { get; set; }
        public virtual DbSet<Catalogs> Catalogs { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<CompanyCustomerBuyers> CompanyCustomerBuyers { get; set; }
        public virtual DbSet<CustomerFeedbacks> CustomerFeedbacks { get; set; }
        public virtual DbSet<CustomerInventories> CustomerInventories { get; set; }
        public virtual DbSet<CustomerTypes> CustomerTypes { get; set; }
        public virtual DbSet<Inventories> Inventories { get; set; }
        public virtual DbSet<InventoryAvailablilties> InventoryAvailablilties { get; set; }
        public virtual DbSet<LostShipments> LostShipments { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Refunds> Refunds { get; set; }
    }
}
