using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a Sedan Car
    /// </summary>
    public class SedanBuilder : IBuilder
    {
        private CarProduct SedanCar;

        /// <summary>
        /// Builds a Sedan Car
        /// </summary>
        public void BuildCar()
        {
            SedanCar = new CarProduct();
            SedanCar.SetBootCapacity(9);
            SedanCar.SetSeatingCapacity(4);
            SedanCar.SetWheelDrive(2);
            SedanCar.SetEngineSize(1);
            SedanCar.SetEngineType("V6");
            SedanCar.SetHorsePower(90);
            SedanCar.SetMaximumSpeed(100);
            SedanCar.SetNumberOfGears(6);
        }

        /// <summary>
        /// Returns a constructed Sedan Car
        /// </summary>
        public CarProduct GetResult()
        {
            return SedanCar;
        }
    }
}
