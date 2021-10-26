using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.Common.Dtos;
using VehicleApi.Common.Interfaces.Database;
using VehicleApi.DataAccessLayer.Database.Entities;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;

namespace VehicleApi.DataAccessLayer.Database
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleSQLiteDBContext _context;

        public VehicleRepository(VehicleSQLiteDBContext context)
        {
            _context = context;
        }

        public IEnumerable<VehicleEntity> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public void InsertVehicle(VehicleEntity vehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(VehicleEntity vehicle)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
