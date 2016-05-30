using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarageTracker.Domain.Tests
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void ModelNewTest()
        {
            // Arrange
            int id = 1;
            int makerId = 1;
            string name = "Camaro";

            // Act
            Model model = new Model(id, makerId, name);

            // Assert
            Assert.AreEqual(id, model.Id);
            Assert.AreEqual(makerId, model.MakerId);
            Assert.AreEqual(name, model.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModelInvalidIdTest()
        {
            // Arrange
            int id = -1;

            // Act
            Model model = new Model(id, 1, "Camaro");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModelInvalidMakerIdTest()
        {
            // Arrange
            int makerId = -1;

            // Act
            Model model = new Model(1, makerId, "Camaro");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ModelInvalidNameTest()
        {
            // Arrange
            string name = null;

            // Act
            Model model = new Model(1, 1, name);
        }
    }
}
