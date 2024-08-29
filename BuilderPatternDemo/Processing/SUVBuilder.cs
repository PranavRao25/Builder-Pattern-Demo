using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class SUVBuilder : IBuilder
    {
        private CarProduct _suvCar;

        public void BuildCar()
        {
            _suvCar = new CarProduct();
            _suvCar.SetBootCapacity(5);
            _suvCar.SetSeatingCapacity(8);
            _suvCar.SetWheelDrive(4);
            _suvCar.SetEngineSize(1.2);
            _suvCar.SetEngineType("V8");
            _suvCar.SetHorsePower(100);
            _suvCar.SetMaxSpeed(80);
            _suvCar.SetNumGears(5);
        }

        public CarProduct GetResult()
        {
            return _suvCar;
        }
    }
}
