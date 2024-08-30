using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Processing;
using Execution;
using System.Runtime.Remoting.Channels;
using System.IO;

namespace BuilderPatternTest
{
    /// <summary>
    /// Unit tests for the builder
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit tests for hatchback car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorHatchback()
        {
            Director HatchbackDirector = new Director(1);
            HatchbackDirector.ConstructCar();
            CarProduct HatchbackDirectorcCarProduct = HatchbackDirector.GetCarProduct();
            string HatchbackDirectorcCarInfo = HatchbackDirectorcCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V6"}.");
            CarInfo.AppendLine($"The engine size is {0.8} Litres.");
            CarInfo.AppendLine($"It has {80} HP.");
            CarInfo.AppendLine($"It is a {2} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {4}.");
            CarInfo.AppendLine($"The boot capacity is {3} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {80}.");
            CarInfo.AppendLine($"The number of gears in it is {5}.");
            Assert.Equal(HatchbackDirectorcCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for sedan car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorSedan()
        {
            Director SedanDirector = new Director(2);
            SedanDirector.ConstructCar();
            CarProduct SedanCarProduct = SedanDirector.GetCarProduct();
            string SedanCarInfo = SedanCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V6"}.");
            CarInfo.AppendLine($"The engine size is {1} Litres.");
            CarInfo.AppendLine($"It has {90} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {4}.");
            CarInfo.AppendLine($"The boot capacity is {9} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {100}.");
            CarInfo.AppendLine($"The number of gears in it is {6}.");
            Assert.Equal(SedanCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for SUV car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorSUV()
        {
            Director SuvDirector = new Director(3);
            SuvDirector.ConstructCar();
            CarProduct SuvCarProduct = SuvDirector.GetCarProduct();
            string SuvCarInfo = SuvCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V8"}.");
            CarInfo.AppendLine($"The engine size is {1.2} Litres.");
            CarInfo.AppendLine($"It has {100} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {8}.");
            CarInfo.AppendLine($"The boot capacity is {5} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {80}.");
            CarInfo.AppendLine($"The number of gears in it is {5}.");
            Assert.Equal(SuvCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for MUV car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorMUV()
        {
            Director MuvDirector = new Director(4);
            MuvDirector.ConstructCar();
            CarProduct MuvCarProduct = MuvDirector.GetCarProduct();
            string MuvCarInfo = MuvCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V6"}.");
            CarInfo.AppendLine($"The engine size is {1.3} Litres.");
            CarInfo.AppendLine($"It has {80} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {10}.");
            CarInfo.AppendLine($"The boot capacity is {8} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {80}.");
            CarInfo.AppendLine($"The number of gears in it is {6}.");
            Assert.Equal(MuvCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for convertible car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorConvertible()
        {
            Director ConvertibleDirector = new Director(5);
            ConvertibleDirector.ConstructCar();
            CarProduct ConvertibleCarProduct = ConvertibleDirector.GetCarProduct();
            string ConvertibleCarInfo = ConvertibleCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V*"}.");
            CarInfo.AppendLine($"The engine size is {1.2} Litres.");
            CarInfo.AppendLine($"It has {120} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {2}.");
            CarInfo.AppendLine($"The boot capacity is {0} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {140}.");
            CarInfo.AppendLine($"The number of gears in it is {6}.");
            Assert.Equal(ConvertibleCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for coupe car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorCoupe()
        {
            Director CoupeDirector = new Director(6);
            CoupeDirector.ConstructCar();
            CarProduct CoupeCarProduct = CoupeDirector.GetCarProduct();
            string CoupeCarInfo = CoupeCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V8"}.");
            CarInfo.AppendLine($"The engine size is {1.6} Litres.");
            CarInfo.AppendLine($"It has {160} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {2}.");
            CarInfo.AppendLine($"The boot capacity is {0} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {160}.");
            CarInfo.AppendLine($"The number of gears in it is {7}.");
            Assert.Equal(CoupeCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for pickup car construction
        /// </summary>
        [TestMethod]
        public void TestDirectorPickup()
        {
            Director PickupDirector = new Director(7);
            PickupDirector.ConstructCar();
            CarProduct PickupCarProduct = PickupDirector.GetCarProduct();
            string PickupCarInfo = PickupCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V8"}.");
            CarInfo.AppendLine($"The engine size is {1} Litres.");
            CarInfo.AppendLine($"It has {120} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {2}.");
            CarInfo.AppendLine($"The boot capacity is {20} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {60}.");
            CarInfo.AppendLine($"The number of gears in it is {5}.");
            Assert.Equal(PickupCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests if user choice is not a string
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect input provided.")]
        public void TestDirectorString()
        {
            Director StringDirector = new Director("7");
            Director NegativeDirector = new Director(-2);
            Director GreaterThanSevenDirector = new Director(10);
            Director FLoatDirector = new Director(7.2);
        }

        /// <summary>
        /// Unit tests if user choice is not negative number
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect input provided.")]
        public void TestDirectorNegative()
        {
            Director CarDirector = new Director(-2);
        }

        /// <summary>
        /// Unit tests if user choice is not greater than seven
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect input provided.")]
        public void TestDirectorGreaterThanSeven()
        {
            Director CarDirector = new Director(10);
        }

        /// <summary>
        /// Unit tests if user choice is not a float
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect input provided.")]
        public void TestDirectorFloat()
        {
            Director CarDirector = new Director(7.2);
        }

        /// <summary>
        /// Unit tests for Car Product Setters
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect input")]
        public void TestCarProduct()
        {
            CarProduct Car = new CarProduct();
            Car.SetBootCapacity(-8);
            Car.SetBootCapacity("-8");
            Car.SetBootCapacity(-8.5);
            Car.SetSeatingCapacity(-10);
            Car.SetSeatingCapacity("10");
            Car.SetSeatingCapacity(-10.3);
            Car.SetWheelDrive(4.5);
            Car.SetWheelDrive("4");
            Car.SetWheelDrive(-4);
            Car.SetEngineSize(-1.3);
            Car.SetEngineSize("1.3");
            Car.SetEngineType("V6");
            Car.SetEngineType(1);
            Car.SetEngineType(-1.3);
            Car.SetHorsePower(-80);
            Car.SetHorsePower("80");
            Car.SetHorsePower(-80.3);
            Car.SetMaxSpeed(-80);
            Car.SetMaxSpeed("80");
            Car.SetMaxSpeed(80.8);
            Car.SetNumGears(-6);
            Car.SetNumGears("6");
            Car.SetNumGears(-6.9);
        }
    }
}
