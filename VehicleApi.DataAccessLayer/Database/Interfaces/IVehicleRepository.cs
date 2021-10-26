using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleApi.Entities.Models;

namespace VehicleApi.DataAccessLayer.Database.Interfaces
{
    public interface IVehicleRepository
    {
        ValueTask<IEnumerable<Vehicle>> GetVehicles();
        ValueTask<Vehicle> GetVehicleById(int vehicleId);
        void InsertVehicle(Vehicle vehicle);
        void DeleteVehicle(int vehicleId);
        void UpdateVehicle(Vehicle vehicle);
        void Save();
    }
}
