using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Common.Dtos;
using VehicleApi.DataAccessLayer.Database.Entities;

namespace VehicleApi.DataAccessLayer.Database.Interfaces
{
    public interface IVehicleRepository
    {
        IEnumerable<VehicleEntity> GetVehicles();
        void InsertVehicle(VehicleEntity vehicle);
        void DeleteVehicle(int vehicleId);
        void UpdateVehicle(VehicleEntity vehicle);
        void Save();
    }
}
