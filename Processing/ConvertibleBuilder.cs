using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class ConvertibleBuilder : IBuilder
    {
        private CarProduct _convertibleCar;

        public void BuildCar()
        {
            _convertibleCar = new CarProduct();
            _convertibleCar.SetBootCapacity(0);
            _convertibleCar.SetSeatingCapacity(2);
            _convertibleCar.SetWheelDrive(4);
            _convertibleCar.SetEngineSize(1.2);
            _convertibleCar.SetEngineType("V8");
            _convertibleCar.SetHorsePower(120);
            _convertibleCar.SetMaxSpeed(140);
            _convertibleCar.SetNumGears(6);
        }

        public CarProduct GetResult()
        {
            return _convertibleCar;
        }
    }
}
