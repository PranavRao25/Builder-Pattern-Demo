using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a Hatchback Car
    /// </summary>
    public class HatchbackBuilder : IBuilder
    {
        private CarProduct HatchbackCar;

        /// <summary>
        /// Builds a Hatchback Car
        /// </summary>
        public void BuildCar()
        {
            HatchbackCar = new CarProduct();
            HatchbackCar.SetBootCapacity(3);
            HatchbackCar.SetSeatingCapacity(4);
            HatchbackCar.SetWheelDrive(2);
            HatchbackCar.SetEngineSize(0.8);
            HatchbackCar.SetEngineType("V6");
            HatchbackCar.SetHorsePower(80);
            HatchbackCar.SetMaximumSpeed(80);
            HatchbackCar.SetNumberOfGears(5);
        }

        /// <summary>
        /// Returns a constructed Hatchback Car
        /// </summary>
        public CarProduct GetResult()
        {
            return HatchbackCar;
        }
    }
}
