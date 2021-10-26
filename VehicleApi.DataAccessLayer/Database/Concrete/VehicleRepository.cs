using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;
using VehicleApi.Entities.Models;

namespace VehicleApi.DataAccessLayer.Database
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleSQLiteDBContext _context;

        public VehicleRepository(VehicleSQLiteDBContext context)
        {
            _context = context;
        }

        public async ValueTask<IEnumerable<Vehicle>> GetVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async ValueTask<Vehicle> GetVehicleById(int vehicleId)
        {
            return await _context.Vehicles.FindAsync(vehicleId);
        }

        public async void InsertVehicle(Vehicle vehicle)
        {
            await _context.Vehicles.AddAsync(vehicle);
        }

        public async void DeleteVehicle(int vehicleId)
        {
            Vehicle vehicle = await _context.Vehicles.FindAsync(vehicleId);
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
        }

        public async void UpdateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Update(vehicle);
            await _context.SaveChangesAsync();
        }

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
