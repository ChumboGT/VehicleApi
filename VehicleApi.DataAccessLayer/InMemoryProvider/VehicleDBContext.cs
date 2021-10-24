using Microsoft.EntityFrameworkCore;
using System;

namespace VehicleApi.DataAccessLayer.InMemoryProvider
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            : base(options)
        {  }

        public DbSet<>
    }
}
