﻿using Microsoft.EntityFrameworkCore;
using TMS.Data.Enums;
using TMS.Data.Models;

namespace TMS.Data.Context
{
    public class TMSContext : DbContext
    {
        public TMSContext(DbContextOptions<TMSContext> options) : base(options)
        { }

        public DbSet<ProductionRecord> ProductionRecords { get; set; }

        public DbSet<TyreProduction> TyreProductions { get; set; }

        public DbSet<TyreSales> TyreSales { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TyreProduction>()
               .HasOne(tp => tp.Operator)
               .WithMany(u => u.TyreProductions)
               .HasForeignKey(tp => tp.OperatorId)
               .OnDelete(DeleteBehavior.Restrict);

            // Relationship: TyreProduction and TyreSales
            modelBuilder.Entity<TyreSales>()
                .HasOne(ts => ts.ReferenceProduction)
                .WithMany(tp => tp.TyreSales)
                .HasForeignKey(ts => ts.ReferenceProductionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "operator1", Password = "hashed password", UserRole = Enums.UserRole.ProductionOperator },
                new User { Id = 2, Username = "supervisor1", Password = "hashed password", UserRole = Enums.UserRole.QualitySupervisor },
                new User { Id = 3, Username = "leader1", Password = "hashed password", UserRole = Enums.UserRole.BusinessUnitLeader }

                );

            modelBuilder.Entity<TyreProduction>().HasData(
                new TyreProduction { Id = 1, TyreCode = "T123", Quantity = 100, OperatorId = 1, ProductionDate = DateTime.Now, ProductionShift = ProductionShift.Morning, MachineNumber = "M001" },
                new TyreProduction { Id = 2, TyreCode = "T124", Quantity = 150, OperatorId = 1, ProductionDate = DateTime.Now, ProductionShift = ProductionShift.Night, MachineNumber = "M002" }
            );

            modelBuilder.Entity<TyreSales>().HasData(
                new TyreSales { Id = 1, TyreName = "T123", QuantitySold = 50, UnitOfMeasure = "pieces", Price = 100.00M, DateOfSale = DateTime.Now, ReferenceProductionId = 1, DestinationMarket = "Local", PurchasingCompany = "ABC Ltd." },
                new TyreSales { Id = 2, TyreName = "T124", QuantitySold = 30, UnitOfMeasure = "pieces", Price = 120.00M, DateOfSale = DateTime.Now, ReferenceProductionId = 2, DestinationMarket = "International", PurchasingCompany = "XYZ Corp." }
            );
        }






    }
}