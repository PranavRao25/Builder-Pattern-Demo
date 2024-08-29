using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class MUVBuilder : IBuilder
    {
        private CarProduct _muvCar;

        public void BuildCar()
        {
            _muvCar = new CarProduct();
            _muvCar.SetBootCapacity(8);
            _muvCar.SetSeatingCapacity(10);
            _muvCar.SetWheelDrive(4);
            _muvCar.SetEngineSize(1.3);
            _muvCar.SetEngineType("V6");
            _muvCar.SetHorsePower(80);
            _muvCar.SetMaxSpeed(80);
            _muvCar.SetNumGears(6);
        }

        public CarProduct GetResult()
        {
            return _muvCar;
        }
    }
}
