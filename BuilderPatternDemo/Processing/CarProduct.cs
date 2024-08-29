using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class CarProduct
    {
        private string engineType = "";
        private int horsePower;
        private int wheelDrive;
        private double engineSize;
        private int seatingCapacity;
        private int bootCapacity;
        private int maxSpeed;
        private int numGears;

        public void SetEngineType(string givenEngineType)
        {
            engineType = givenEngineType;
        }

        public void SetHorsePower(int givenHorsePower)
        {
            horsePower = givenHorsePower;
        }

        public void SetWheelDrive(int givenWheelDrive)
        {
            wheelDrive = givenWheelDrive;
        }

        public void SetEngineSize(double givenEngineSize)
        {
            engineSize = givenEngineSize;
        }

        public void SetSeatingCapacity(int givenSeatingCapacity)
        {
            seatingCapacity = givenSeatingCapacity;
        }

        public void SetBootCapacity(int givenBootCapacity)
        {
            bootCapacity = givenBootCapacity;
        }

        public void SetMaxSpeed(int givenMaxSpeed)
        {
            maxSpeed = givenMaxSpeed;
        }

        public void SetNumGears(int givenNumGears)
        {
            numGears = givenNumGears;
        }

        public string DisplayInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The Car has Engine Type as {engineType}.");
            sb.AppendLine($"The engine size is {engineSize} Litres.");
            sb.AppendLine($"It has {horsePower} HP.");
            sb.AppendLine($"It is a {wheelDrive} Wheel Drive.");
            sb.AppendLine($"The seating capacity is {seatingCapacity}.");
            sb.AppendLine($"The boot capacity is {bootCapacity} cubic-feet.");
            sb.AppendLine($"The maximum speed is {maxSpeed}.");
            sb.AppendLine($"The number of gears in it is {numGears}.");
            return sb.ToString();
        }
    }
}
