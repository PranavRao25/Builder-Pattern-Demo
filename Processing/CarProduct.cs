using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class CarProduct
    {
        private string EngineType = "";
        private int HorsePower;
        private int WheelDrive;
        private double EngineSize;
        private int SeatingCapacity;
        private int BootCapacity;
        private int MaximumSpeed;
        private int NumberOfGears;

        /// <summary>
        /// Set the engine type for the car
        /// </summary>
        /// <param name="givenEngineType">Engine Type the car must have</param>
        public void SetEngineType(string givenEngineType)
        {
            if(givenEngineType.Equals("V8") || givenEngineType.Equals("V6"))
            {
                EngineType = givenEngineType;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the horse power for the car
        /// </summary>
        /// <param name="givenHorsePower">Horse Power the car must have</param>
        public void SetHorsePower(int givenHorsePower)
        {
            if (givenHorsePower > 0)
            {
                HorsePower = givenHorsePower;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the wheel drive for the car
        /// </summary>
        /// <param name="givenWheelDrive">Wheel Drive the car must have</param>
        public void SetWheelDrive(int givenWheelDrive)
        {
            if (givenWheelDrive > 0)
            {
                WheelDrive = givenWheelDrive;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the engine size for the car
        /// </summary>
        /// <param name="givenEngineSize">Engine Size the car must have</param>
        public void SetEngineSize(double givenEngineSize)
        {
            if(givenEngineSize > 0.0)
            {
                EngineSize = givenEngineSize;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the seating capacity for the car
        /// </summary>
        /// <param name="givenSeatingCapacity">Seating Capacity the car must have</param>
        public void SetSeatingCapacity(int givenSeatingCapacity)
        {
            if (givenSeatingCapacity > 0)
            {
                SeatingCapacity = givenSeatingCapacity;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the boot capacity for the car
        /// </summary>
        /// <param name="givenBootCapacity">Boot Capacity the car must have</param>
        public void SetBootCapacity(int givenBootCapacity)
        {
            if (givenBootCapacity >= 0)
            {
                BootCapacity = givenBootCapacity;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the maximum speed for the car
        /// </summary>
        /// <param name="givenMaximumSpeed">Maximum Speed the car must have</param>
        public void SetMaximumSpeed(int givenMaximumSpeed)
        {
            if (givenMaximumSpeed > 0)
            {
                MaximumSpeed = givenMaximumSpeed;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Set the number of gears for the car
        /// </summary>
        /// <param name="givenNumberOfGears">Number of Gears the car must have</param>
        public void SetNumberOfGears(int givenNumberOfGears)
        {
            if (givenNumberOfGears > 0)
            {
                NumberOfGears = givenNumberOfGears;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Displays information about the car
        /// </summary>
        public string DisplayInfo()
        {
            var CarInfo = new StringBuilder();
            CarInfo.AppendLine($"The Car has Engine Type as {EngineType}.");
            CarInfo.AppendLine($"The engine size is {EngineSize} Litres.");
            CarInfo.AppendLine($"It has {HorsePower} HP.");
            CarInfo.AppendLine($"It is a {WheelDrive} Wheel Drive.");
            CarInfo.AppendLine($"The seating capacity is {SeatingCapacity}.");
            CarInfo.AppendLine($"The boot capacity is {BootCapacity} cubic-feet.");
            CarInfo.AppendLine($"The maximum speed is {MaximumSpeed}.");
            CarInfo.AppendLine($"The number of gears in it is {NumberOfGears}.");
            return CarInfo.ToString();
        }
    }
}
