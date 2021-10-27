using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Business.Interfaces;
using VehicleApi.Common.Dtos;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;

namespace VehicleApi.Business.Services
{
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async ValueTask<VehicleDto> CreateVehicle(VehicleDto vehicle)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> DeleteVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<VehicleDto> GetVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IEnumerable<VehicleDto>> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> UpdateVehicle(VehicleDto vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
