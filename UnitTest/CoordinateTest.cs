using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMartian;

namespace UnitTest
{
    [TestClass]
    public class CoordinateTest
    {

        [TestMethod]
        public void InitiateRover()
        {
            Rover rover = null;
            Cordinates cordinates = new Cordinates();

            rover = cordinates.InitRover("5 5");

            // Assert
            Assert.IsNotNull(rover);


        }

        [TestMethod]
        public void RoverPosition()
        {
            Rover rover = null;
            Cordinates cordinates = new Cordinates();

            rover = cordinates.InitRover("5 5");
            rover = cordinates.RoverPosition(rover,"2 1 E");

            // Assert
            Assert.IsNotNull(rover);


        }

        [TestMethod]
        public void RoverMovement()
        {
            Rover rover = null;
            Cordinates cordinates = new Cordinates();

            rover = cordinates.InitRover("5 5");
            rover = cordinates.RoverPosition(rover, "1 2 N");
            var result = rover.Move("LMLMLMLMM");
            // Assert
            Assert.AreEqual(1, result.GetX());
            Assert.AreEqual(3, result.GetY());
            Assert.AreEqual("N", result.GetDirection());


        }

    }
}
