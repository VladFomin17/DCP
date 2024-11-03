using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2
{
    public abstract class Discount
    {

        public abstract double Calculate(double purchaseAmount);
    }
}
