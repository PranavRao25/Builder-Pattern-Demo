using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    /// <summary>
    /// Builder for a Pickup Car
    /// </summary>
    public class PickupBuilder : IBuilder
    {
        private CarProduct PickupCar;

        /// <summary>
        /// Builds a Pickup Car
        /// </summary>
        public void BuildCar()
        {
            PickupCar = new CarProduct();
            PickupCar.SetBootCapacity(20);
            PickupCar.SetSeatingCapacity(2);
            PickupCar.SetWheelDrive(4);
            PickupCar.SetEngineSize(1);
            PickupCar.SetEngineType("V8");
            PickupCar.SetHorsePower(120);
            PickupCar.SetMaximumSpeed(60);
            PickupCar.SetNumberOfGears(5);
        }

        /// <summary>
        /// Returns a constructed Pickup Car
        /// </summary>
        public CarProduct GetResult()
        {
            return PickupCar;
        }
    }
}
