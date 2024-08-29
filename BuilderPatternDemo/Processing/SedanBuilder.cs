using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class SedanBuilder : IBuilder
    {
        private CarProduct _sedanCar;

        public void BuildCar()
        {
            _sedanCar = new CarProduct();
            _sedanCar.SetBootCapacity(9);
            _sedanCar.SetSeatingCapacity(4);
            _sedanCar.SetWheelDrive(2);
            _sedanCar.SetEngineSize(1);
            _sedanCar.SetEngineType("V6");
            _sedanCar.SetHorsePower(90);
            _sedanCar.SetMaxSpeed(100);
            _sedanCar.SetNumGears(6);
        }

        public CarProduct GetResult()
        {
            return _sedanCar;
        }
    }
}
