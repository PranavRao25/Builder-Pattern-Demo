/******************************************************************************
 * Filename    = UnitTest.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = BuilderPatternDemoTest
 *
 * Description = Unit Tests
 *****************************************************************************/

using NUnit.Framework;
using System;
using System.Text;
using Processing;
using Execution;

namespace BuilderPatternTest
{
    /// <summary>
    /// Unit tests for the builder
    /// </summary>
    [TestFixture]
    public class UnitTest
    {
        /// <summary>
        /// Unit tests for hatchback car construction
        /// </summary>
        [Test]
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
            Assert.AreEqual(HatchbackDirectorcCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for sedan car construction
        /// </summary>
        [Test]
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
            CarInfo.AppendLine($"It is a {2} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {4}.");
            CarInfo.AppendLine($"The boot capacity is {9} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {100}.");
            CarInfo.AppendLine($"The number of gears in it is {6}.");
            Assert.AreEqual(SedanCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for SUV car construction
        /// </summary>
        [Test]
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
            Assert.AreEqual(SuvCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for MUV car construction
        /// </summary>
        [Test]
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
            Assert.AreEqual(MuvCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for convertible car construction
        /// </summary>
        [Test]
        public void TestDirectorConvertible()
        {
            Director ConvertibleDirector = new Director(5);
            ConvertibleDirector.ConstructCar();
            CarProduct ConvertibleCarProduct = ConvertibleDirector.GetCarProduct();
            string ConvertibleCarInfo = ConvertibleCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V8"}.");
            CarInfo.AppendLine($"The engine size is {1.2} Litres.");
            CarInfo.AppendLine($"It has {120} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {2}.");
            CarInfo.AppendLine($"The boot capacity is {0} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {140}.");
            CarInfo.AppendLine($"The number of gears in it is {6}.");
            Assert.AreEqual(ConvertibleCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for coupe car construction
        /// </summary>
        [Test]
        public void TestDirectorCoupe()
        {
            Director CoupeDirector = new Director(6);
            CoupeDirector.ConstructCar();
            CarProduct CoupeCarProduct = CoupeDirector.GetCarProduct();
            string CoupeCarInfo = CoupeCarProduct.DisplayInfo();
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {"V8"}.");
            CarInfo.AppendLine($"The engine size is {1.5} Litres.");
            CarInfo.AppendLine($"It has {160} HP.");
            CarInfo.AppendLine($"It is a {4} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {2}.");
            CarInfo.AppendLine($"The boot capacity is {0} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {160}.");
            CarInfo.AppendLine($"The number of gears in it is {7}.");
            Assert.AreEqual(CoupeCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests for pickup car construction
        /// </summary>
        [Test]
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
            Assert.AreEqual(PickupCarInfo, CarInfo.ToString());
        }

        /// <summary>
        /// Unit tests if user choice is not a string
        /// </summary>
        [Test]
        public void TestDirectorString()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                // Director StringDirector = new Director("7");
                Director NegativeDirector = new Director(-2);
                Director GreaterThanSevenDirector = new Director(10);
                // Director FloatDirector = new Director(7.2);
            }, "Incorrect input provided.");
        }

        /// <summary>
        /// Unit tests if user choice is not negative number
        /// </summary>
        [Test]
        public void TestDirectorNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Director CarDirector = new Director(-2);
            }, "Incorrect input provided.");
        }

        /// <summary>
        /// Unit tests if user choice is not greater than seven
        /// </summary>
        [Test]
        public void TestDirectorGreaterThanSeven()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Director CarDirector = new Director(10);
            }, "Incorrect input provided.");
        }

        

        /// <summary>
        /// Unit tests for Car Product Setters
        /// </summary>
        [Test]
        public void TestCarProduct()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CarProduct Car = new CarProduct();
                Car.SetBootCapacity(-8);
                //Car.SetBootCapacity("-8");
                //Car.SetBootCapacity(-8.5);
                Car.SetSeatingCapacity(-10);
                //Car.SetSeatingCapacity("10");
                //Car.SetSeatingCapacity(-10.3);
                //Car.SetWheelDrive(4.5);
                //Car.SetWheelDrive("4");
                Car.SetWheelDrive(-4);
                Car.SetEngineSize(-1.3);
                //Car.SetEngineSize("1.3");
                Car.SetEngineType("V6");
                //Car.SetEngineType(1);
                //Car.SetEngineType(-1.3);
                Car.SetHorsePower(-80);
                //Car.SetHorsePower("80");
                //Car.SetHorsePower(-80.3);
                Car.SetMaximumSpeed(-80);
                //Car.SetMaximumSpeed("80");
                //Car.SetMaximumSpeed(80.8);
                Car.SetNumberOfGears(-6);
                //Car.SetNumberOfGears("6");
                //Car.SetNumberOfGears(-6.9);
            }, "Incorrect input");
        }
    }
}
