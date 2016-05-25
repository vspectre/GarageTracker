using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarageTracker.Domain.Tests
{
    [TestClass]
    public class MakerTest
    {
        [TestMethod]
        public void MakerNewTest()
        {
            // Arrange
            int id = 1;
            string name = "Chevy";

            // Act
            Maker make = new Maker(id, name);

            // Assert
            Assert.AreEqual(id, make.Id);
            Assert.AreEqual(name, make.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MakerInvalidIdTest()
        {
            // Arrange
            int id = -1;
            string name = "Chevy";

            // Act
            Maker make = new Maker(id, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MakerInvalidNameTest()
        {
            // Arrange
            int id = 1;
            string name = null;

            // Act
            Maker make = new Maker(id, name);
        }
    }
}
