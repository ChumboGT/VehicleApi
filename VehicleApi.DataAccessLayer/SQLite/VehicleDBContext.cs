using Microsoft.EntityFrameworkCore;
using System;
using VehicleApi.Entities.Models;

namespace VehicleApi.DataAccessLayer.SQLite
{
    public class VehicleDbContext : DbContext
    {
        private const string DbPath = "VehicleDB.db";

        public DbSet<Vehicle> Vehicles { get; set; }

        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            : base(options)
        {  }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            options.UseSQLite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
        }
    }
}
