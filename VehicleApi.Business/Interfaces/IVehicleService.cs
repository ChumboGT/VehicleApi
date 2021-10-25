using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Business.Dtos;

namespace VehicleApi.Business.Interfaces
{
    interface IVehicleService
    {
        //Create
        VehicleDto CreateVehicle(VehicleDto vehicle);

        //Read
        List<VehicleDto> GetVehicles();
        VehicleDto GetVehicleById(int vehicleId);

        //Update
        bool UpdateVehicle(VehicleDto vehicle);

        //Delete
        bool DeleteVehicleById(int vehicleId);
    }
}
