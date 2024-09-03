/******************************************************************************
 * Filename    = CoupeBuilder.cs
 *
 * Author      = Pranav Guruprasad Rao
 *
 * Product     = BuilderPatternDemo
 * 
 * Project     = Processing
 *
 * Description = Builder for Coupe Car
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a Coupe Car
    /// </summary>
    public class CoupeBuilder : IBuilder
    {
        private CarProduct CoupeCar;

        /// <summary>
        /// Builds a Coupe Car
        /// </summary>
        public void BuildCar()
        {
            CoupeCar = new CarProduct();
            CoupeCar.SetBootCapacity(0);
            CoupeCar.SetSeatingCapacity(2);
            CoupeCar.SetWheelDrive(4);
            CoupeCar.SetEngineSize(1.5);
            CoupeCar.SetEngineType("V8");
            CoupeCar.SetHorsePower(160);
            CoupeCar.SetMaximumSpeed(160);
            CoupeCar.SetNumberOfGears(7);
        }

        /// <summary>
        /// Returns a constructed Coupe Car
        /// </summary>
        public CarProduct GetResult()
        {
            return CoupeCar;
        }
    }
}
