﻿/******************************************************************************
 * Filename    = MUVBuilder.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = Processing
 *
 * Description = Builder for MUV Car
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a MUV Car
    /// </summary>
    public class MUVBuilder : IBuilder
    {
        private CarProduct MuvCar;

        /// <summary>
        /// Builds a MUV Car
        /// </summary>
        public void BuildCar()
        {
            MuvCar = new CarProduct();
            MuvCar.SetBootCapacity(8);
            MuvCar.SetSeatingCapacity(10);
            MuvCar.SetWheelDrive(4);
            MuvCar.SetEngineSize(1.3);
            MuvCar.SetEngineType("V6");
            MuvCar.SetHorsePower(80);
            MuvCar.SetMaximumSpeed(80);
            MuvCar.SetNumberOfGears(6);
        }

        /// <summary>
        /// Returns a constructed MUV Car
        /// </summary>
        public CarProduct GetResult()
        {
            return MuvCar;
        }
    }
}
