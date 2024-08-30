﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a SUV Car
    /// </summary>
    public class SUVBuilder : IBuilder
    {
        private CarProduct SuvCar;

        /// <summary>
        /// Builds a SUV Car
        /// </summary>
        public void BuildCar()
        {
            SuvCar = new CarProduct();
            SuvCar.SetBootCapacity(5);
            SuvCar.SetSeatingCapacity(8);
            SuvCar.SetWheelDrive(4);
            SuvCar.SetEngineSize(1.2);
            SuvCar.SetEngineType("V8");
            SuvCar.SetHorsePower(100);
            SuvCar.SetMaxSpeed(80);
            SuvCar.SetNumGears(5);
        }

        /// <summary>
        /// Returns a constructed SUV Car
        /// </summary>
        public CarProduct GetResult()
        {
            return SuvCar;
        }
    }
}
