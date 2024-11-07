using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_4
{
    internal class Printer : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печатаю документ: {document}");
        }
    }
}
