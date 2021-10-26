using Microsoft.EntityFrameworkCore;
using System;
using VehicleApi.Entities.Models;

//TODO: Should probably move to VehicleApi.DataAccessLayer.Database.SQLite
namespace VehicleApi.DataAccessLayer.SQLite
{
    public class VehicleSQLiteDBContext : DbContext
    {
        private const string DbPath = "VehicleDB.db";

        public DbSet<Vehicle> Vehicles { get; set; }

        public VehicleSQLiteDBContext(DbContextOptions<VehicleSQLiteDBContext> options)
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
