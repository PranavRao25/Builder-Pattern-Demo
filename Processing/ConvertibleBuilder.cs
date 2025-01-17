﻿/******************************************************************************
 * Filename    = ConvertibleBuilder.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = Processing
 *
 * Description = Builder for Convertible Car
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a Convertible Car
    /// </summary>
    public class ConvertibleBuilder : IBuilder
    {
        private CarProduct ConvertibleCar;

        /// <summary>
        /// Builds a Convertible Car
        /// </summary>
        public void BuildCar()
        {
            ConvertibleCar = new CarProduct();
            ConvertibleCar.SetBootCapacity(0);
            ConvertibleCar.SetSeatingCapacity(2);
            ConvertibleCar.SetWheelDrive(4);
            ConvertibleCar.SetEngineSize(1.2);
            ConvertibleCar.SetEngineType("V8");
            ConvertibleCar.SetHorsePower(120);
            ConvertibleCar.SetMaximumSpeed(140);
            ConvertibleCar.SetNumberOfGears(6);
        }

        /// <summary>
        /// Returns a constructed Convertible Car
        /// </summary>
        public CarProduct GetResult()
        {
            return ConvertibleCar;
        }
    }
}
