using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Vehicle Govnovoz = new Vehicle("Говновоз", 1488, "govno");

            Govnovoz.getColor();
            Govnovoz.getInfo();

            Car LadaGranta = new Car("Лада Гранта", 78, "raspberry", 0.1);

            LadaGranta.getEngineCapacity();
            LadaGranta.getInfo();

            Bicycle Velic = new Bicycle("Дедовский велик");
            Velic.getInfo();
        }
    }
}
