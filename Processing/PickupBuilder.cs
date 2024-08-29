using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class PickupBuilder : IBuilder
    {
        private CarProduct _pickupCar;

        public void BuildCar()
        {
            _pickupCar = new CarProduct();
            _pickupCar.SetBootCapacity(20);
            _pickupCar.SetSeatingCapacity(2);
            _pickupCar.SetWheelDrive(4);
            _pickupCar.SetEngineSize(1);
            _pickupCar.SetEngineType("V8");
            _pickupCar.SetHorsePower(120);
            _pickupCar.SetMaxSpeed(60);
            _pickupCar.SetNumGears(5);
        }

        public CarProduct GetResult()
        {
            return _pickupCar;
        }
    }
}
