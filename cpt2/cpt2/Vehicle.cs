using cpt2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cpt2
{
    public class Vehicle 
    {
        public string VehicleName;
        public int MaxSpeed;
        public string Color;
        public Vehicle(string vehicleName = "Unknown", int maxSpeed = 0, string color = "Unknown")
        {
            VehicleName = vehicleName;
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public void getMaxSpeed() => Console.WriteLine($"Максимальная скорость {VehicleName}: {MaxSpeed} км/ч");
        public void getColor() => Console.WriteLine($"Цвет транспорта {VehicleName}: {Color}");

        public void getInfo()
        {
            Console.WriteLine($"Информация о транспорте {VehicleName}");
            getMaxSpeed();
            getColor();
        }
    }
}
