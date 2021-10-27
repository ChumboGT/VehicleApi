using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleApi.Common.Dtos;

namespace VehicleApi.Business.Interfaces
{
    public interface IVehicleService
    {
        //Create
        ValueTask<VehicleDto> CreateVehicle(VehicleDto vehicle);

        //Read
        ValueTask<IEnumerable<VehicleDto>> GetVehicles();
        ValueTask<VehicleDto> GetVehicleById(int vehicleId);

        //Update
        ValueTask<bool> UpdateVehicle(VehicleDto vehicle);

        //Delete
        ValueTask<bool> DeleteVehicleById(int vehicleId);
    }
}
