using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt2
{
    public class Car : Vehicle
    {
        public double EngineCapacity;
        public Car(string vehicleName = "Unknown", int maxSpeed = 0, string color = "Unknown", double engineCapacity = 0) : base(vehicleName, maxSpeed, color)
        {
            EngineCapacity = engineCapacity;
        }

        public void getEngineCapacity() => Console.WriteLine($"Вместимость двигателя {VehicleName}: {EngineCapacity} л.");
        public void getInfo()
        {
            base.getInfo();
            getEngineCapacity();
        }
    }
}
