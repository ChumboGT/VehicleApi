using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VehicleApi.Business.Dtos;
using VehicleApi.Business.Services;

namespace VehicleApi.Tests.Services
{
    [TestClass]
    public class VehicleServiceTests
    {
        private readonly VehicleService _vehicleService;

        public VehicleServiceTests()
        {
            _vehicleService = new VehicleService();
        }

        //TODO: Remove/change this once the GetVehicles() method is implemented
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetVehicles_InputIs1_ReturnNIE()
        {
            List<VehicleDto> vehicles =  _vehicleService.GetVehicles();
        }
    }
}
