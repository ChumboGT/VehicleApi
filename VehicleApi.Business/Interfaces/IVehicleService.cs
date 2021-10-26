using System.Collections.Generic;
using VehicleApi.Common.Dtos;

namespace VehicleApi.Business.Interfaces
{
    public interface IVehicleService
    {
        //Create
        VehicleDto CreateVehicle(VehicleDto vehicle);

        //Read
        IEnumerable<VehicleDto> GetVehicles();
        VehicleDto GetVehicleById(int vehicleId);

        //Update
        bool UpdateVehicle(VehicleDto vehicle);

        //Delete
        bool DeleteVehicleById(int vehicleId);
    }
}
