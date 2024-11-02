using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt2
{
    public class Bicycle : Vehicle
    {
        public int NumberOfWheels;
        public Bicycle(string vehicleName = "Unknown", int maxSpeed = 0, string color = "Unknown", int numberOfWheels = 2) : base(vehicleName, maxSpeed, color)
        {
            NumberOfWheels = numberOfWheels;
        }
        public void getNumberOfWheels() => Console.WriteLine($"Количество колес {VehicleName}: {NumberOfWheels}");
        public void getInfo()
        {
            base.getInfo();
            getNumberOfWheels();
        }
    }
}
