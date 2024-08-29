using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class HatchbackBuilder : IBuilder
    {
        private CarProduct _hatchbackCar;

        public void BuildCar()
        {
            _hatchbackCar = new CarProduct();
            _hatchbackCar.SetBootCapacity(3);
            _hatchbackCar.SetSeatingCapacity(4);
            _hatchbackCar.SetWheelDrive(2);
            _hatchbackCar.SetEngineSize(0.8);
            _hatchbackCar.SetEngineType("V6");
            _hatchbackCar.SetHorsePower(80);
            _hatchbackCar.SetMaxSpeed(80);
            _hatchbackCar.SetNumGears(5);
        }

        public CarProduct GetResult()
        {
            return _hatchbackCar;
        }
    }
}
