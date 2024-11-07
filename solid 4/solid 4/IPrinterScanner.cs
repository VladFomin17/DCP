using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_4
{
    internal interface IPrinterScanner
    {
        void Print(string document);
        void Scan(string document);
    }
}
