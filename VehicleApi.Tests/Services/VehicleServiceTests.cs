using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VehicleApi.Common.Dtos;
using VehicleApi.Business.Interfaces;
using VehicleApi.Business.Services;

namespace VehicleApi.Tests.Services
{
    [TestClass]
    public class VehicleServiceTests
    {
        private IVehicleService _vehicleService;

        [TestInitialize]
        public void InitializeTestValues()
        {
            //_vehicleService = Substitute.For<IVehicleService>();
        }

        //TODO: Remove/change this once the GetVehicles() method is implemented
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetVehicles_InputIs1_ReturnNIE()
        {
            //IEnumerable<VehicleDto> vehicles =  _vehicleService.GetVehicles();
        }

        [TestMethod]
        public void GetVehicleById_NoVehicleWithEnteredId_ShouldReturnNull()
        {
            //arrange

            //act


            //assert
        }
    }
}
