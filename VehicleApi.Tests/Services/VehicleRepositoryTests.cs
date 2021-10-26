using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.DataAccessLayer.Database;
using VehicleApi.DataAccessLayer.Database.Entities;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;

namespace VehicleApi.Tests.Services
{
    [TestClass]
    public class VehicleRepositoryTests
    {
        private IVehicleRepository _vehicleRepository;
        private static List<VehicleEntity> _fakeDatabase = 
            new List<VehicleEntity>()
            {
                new VehicleEntity()
                {
                    Id = 1,
                    Year = 2021,
                    Make = "Nissan",
                    Model = "GT-R"
                },
                new VehicleEntity()
                {
                    Id = 2,
                    Year = 2016,
                    Make = "Ford",
                    Model = "Shelby Mustang GT350"
                },
                new VehicleEntity()
                {
                    Id = 3,
                    Year = 1971,
                    Make = "Plymouth",
                    Model = "Hemi 'Cuda"
                },
                new VehicleEntity()
                {
                    Id = 4,
                    Year = 1983,
                    Make = "DMC",
                    Model = "DeLorean"
                }
            }; 

        [TestInitialize]
        public void InitializeTestValues()
        {
            var mockedContext = NSubstitute.Substitute.For<VehicleSQLiteDBContext>();
            
            
            _vehicleRepository = new VehicleRepository(mockedContext);
        }

        [TestMethod]
        public void GetVehicles_ReturnsIEnumerableOfVehicleEntity()
        {

        }

        [TestMethod]
        public void InsertVehicle_InsertsVehicleViaContext()
        {

        }
    }
}
