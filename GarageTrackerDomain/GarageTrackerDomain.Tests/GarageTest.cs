using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;
using Moq;
using NSubstitute;

namespace GarageTracker.Domain.Tests
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void GarageNewTest()
        {
            // Arrange
            IPrincipal principal = Substitute.For<IPrincipal>();

            // Act
            Garage garage = new Garage(principal);

            // Arrange
            Assert.AreEqual(principal, garage.Owner);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GarageNullOwnerTest()
        {
            // Arrange
            IPrincipal principal = null;

            // Act
            Garage garage = new Garage(principal);
        }

        [TestMethod]
        public void GargeVehicleListTest()
        {
            // Arrange
            IPrincipal principal = Substitute.For<IPrincipal>();

            // Act
            Garage garage = new Garage(principal);

            // Assert
            Assert.IsNotNull(garage.Vehicles, "vehicles collection is null");
            Assert.AreEqual(0, garage.Vehicles.Count, "vehicles collection is not empty");
        }
    }
}
