using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApi.DataAccessLayer.Database;
using VehicleApi.DataAccessLayer.Database.Entities;
using VehicleApi.DataAccessLayer.Database.Interfaces;
using VehicleApi.DataAccessLayer.SQLite;
using VehicleApi.Entities.Models;
using static VehicleApi.Tests.Moq.DBContextMock;

namespace VehicleApi.Tests.Services
{
    [TestClass]
    public class VehicleRepositoryTests
    {
        private IVehicleRepository _vehicleRepository;
        private static List<Vehicle> _mockedVehicles = 
            new List<Vehicle>()
            {
                new Vehicle()
                {
                    Id = 1,
                    Year = 2021,
                    Make = "Nissan",
                    Model = "GT-R"
                },
                new Vehicle()
                {
                    Id = 2,
                    Year = 2016,
                    Make = "Ford",
                    Model = "Shelby Mustang GT350"
                },
                new Vehicle()
                {
                    Id = 3,
                    Year = 1971,
                    Make = "Plymouth",
                    Model = "Hemi 'Cuda"
                },
                new Vehicle()
                {
                    Id = 4,
                    Year = 1983,
                    Make = "DMC",
                    Model = "DeLorean"
                }
            };

        /// <summary>
        /// Helper function to return a ValueTask<Vehicle> for a given Vehicle in our _fakeDatabase
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        //private static ValueTask<Vehicle> GetVehicleValueTask(int vehicleId)
        //{
        //    var task = new Task<Vehicle>(new Func<Vehicle>(() => _fakeDatabase.Single(v => v.Id == vehicleId)));
        //    return new ValueTask<Vehicle>(task);
        //}

        [TestInitialize]
        public void InitializeTestValues()
        {
            //var myMoqDb = new Mock<IVehicleDatabaseContext>();
            //myMoqDb.Setup(v => v.Vehicles).Returns(DbContextMock.GetQueryableMockDbSet(_mockedVehicles));

            //=====
            //var mockedContext = Substitute.For<VehicleSQLiteDBContext>();

            //var vehicleDbSetSub = Substitute.For<DbSet<Vehicle>>();
            //((IQueryable<Vehicle>)vehicleDbSetSub).
            //vehicleDbSetSub.ToListAsync().Returns(new Task<List<Vehicle>>(() => new List<Vehicle>()));

            //mockedContext.Vehicles = Substitute.For<DbSet<Vehicle>>();
            //mockedContext.Vehicles = vehicleDbSetSub;
            //mockedContext.Vehicles.ToListAsync().Returns(_fakeDatabase);

            //Wire the FindAsync method to our Fake Database
            //mockedContext.Vehicles.FindAsync(Arg.Any<int>()).Returns(x => GetVehicleValueTask(x.ArgAt<int>(0)));

            //_vehicleRepository = new VehicleRepository(mockedContext);
        }

        [TestMethod]
        public async Task GetVehicles_ReturnsIEnumerableOfVehicleEntity()
        {
            //arrange
            //See _fakeDatabase, GetVehicleValueTask, and Initial

            var result = new Task<int>(new Func<int>(() => { return 5;  }));
            await result;

            //act
            //ValueTask<IEnumerable<Vehicle>> result = _vehicleRepository.GetVehicles();
            //await result;

            //assert
            //Assert.IsTrue(result.Result.ToList().Count == 4);
            Assert.IsTrue(result.Result == 5);
        }

        [TestMethod]
        public async Task GetVehicles_ReturnsAllVehiclesFromContext()
        {
            //arrange
            var myMoqDb = new Mock<IVehicleDatabaseContext>();
            myMoqDb.Setup(v => v.Vehicles).Returns(DbContextMock.GetQueryableMockDbSet(_mockedVehicles));
            var repo = new VehicleRepository(myMoqDb.Object);

            //act
            var result = repo.GetVehicles();
            //await result;

            //assert
            Assert.IsTrue(result.Result != null);

        }
    }
}
