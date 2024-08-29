using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Processing;
using Execution;
using System.Runtime.Remoting.Channels;
using System.IO;

namespace BuilderPatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDirector()
        {
            Director director = new Director(1);
            director.ConstructCar();
            CarProduct car = director.GetCarProduct();
        }
    }
}
