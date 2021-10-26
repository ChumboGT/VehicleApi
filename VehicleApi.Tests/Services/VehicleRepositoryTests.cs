using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.DataAccessLayer.Database;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;

namespace VehicleApi.Tests.Services
{
    [TestClass]
    public class VehicleRepositoryTests
    {
        private IVehicleRepository _vehicleRepository;

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
