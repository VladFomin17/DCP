using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid3
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Пингвины не могут летать.");
        }

    }
}
