using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class CoupeBuilder : IBuilder
    {
        private CarProduct _coupeCar;

        public void BuildCar()
        {
            _coupeCar = new CarProduct();
            _coupeCar.SetBootCapacity(0);
            _coupeCar.SetSeatingCapacity(2);
            _coupeCar.SetWheelDrive(4);
            _coupeCar.SetEngineSize(1.5);
            _coupeCar.SetEngineType("V8");
            _coupeCar.SetHorsePower(160);
            _coupeCar.SetMaxSpeed(160);
            _coupeCar.SetNumGears(7);
        }

        public CarProduct GetResult()
        {
            return _coupeCar;
        }
    }
}
