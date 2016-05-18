﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GarageTracker.Domain;
using NSubstitute;

namespace GarageTracker.Domain.Tests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void NewVehicleTest()
        {
            // Act
            Vehicle vehicle = new Vehicle();
            
            // Assert
            Assert.IsNotNull(vehicle);
            Assert.AreEqual(0, vehicle.VehicleId);
        }

        [TestMethod]
        public void VehicleIdTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            vehicle.VehicleId = 1;

            // Assert
            Assert.AreEqual(1, vehicle.VehicleId);
        }

        [TestMethod]
        public void VehicleVINTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            vehicle.VIN = "1G1ZG57B984193351";

            // Assert
            Assert.AreEqual("1G1ZG57B984193351", vehicle.VIN);
        }

        [TestMethod]
        public void VehicleSetYearTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            vehicle.SetYear(2000);

            // Assert
            Assert.AreEqual(2000, vehicle.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSetYearLowOutofRangeTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();

            // Act
            vehicle.SetYear(1885);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSetYearHighOutofRangeTest()
        {
            // Arrange
            int futureYear = DateTime.Now.AddYears(2).Year;
            Vehicle vehicle = new Vehicle();

            // Act
            vehicle.SetYear(futureYear);
        }

        [TestMethod]
        public void VehicleSetMakerTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            Maker maker = new Maker();

            // Act
            vehicle.SetMake(maker);

            // Assert
            Assert.AreSame(maker, vehicle.Make);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VehicleSetMakerNullTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            Maker make = null;

            // Act
            vehicle.SetMake(make);
        }

        [TestMethod]
        public void VehicleSetModelTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            Maker make = new Maker() { Id = 1, Name = "Maker 1" };
            Model model = new Model() { MakerId = 1 };

            // Act
            vehicle.SetMake(make);
            vehicle.SetModel(model);

            // Assert
            Assert.AreEqual(vehicle.Make.Id, vehicle.Model.MakerId);
            Assert.AreSame(model, vehicle.Model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VehicleSetModelNullTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            Model model = null;

            // Act
            vehicle.SetModel(model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleSetModelMakerNotSetTest()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            Model model = new Model();

            // Act
            vehicle.SetModel(model);
        }
    }
}
