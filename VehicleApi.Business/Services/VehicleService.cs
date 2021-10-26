using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Business.Interfaces;
using VehicleApi.Common.Dtos;
using VehicleApi.DataAccessLayer.SQLite;

namespace VehicleApi.Business.Services
{
    public class VehicleService : IVehicleService
    {
        private static VehicleSQLiteDBContext _vehicleSQLiteDBContext;

        public VehicleService(VehicleSQLiteDBContext vehicleSQLiteDBContext)
        {
            _vehicleSQLiteDBContext = vehicleSQLiteDBContext;
        }

        public VehicleDto CreateVehicle(VehicleDto vehicle)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public VehicleDto GetVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VehicleDto> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public bool UpdateVehicle(VehicleDto vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
