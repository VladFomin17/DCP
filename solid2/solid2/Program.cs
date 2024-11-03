using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Discount percentageDiscount = new PercentageDiscount(0.8);
            Discount fixedAmountDiscount = new FixedAmountDiscount(12);

            double PurchaseAmount = 1500;

            Console.WriteLine(percentageDiscount.Calculate(PurchaseAmount));
            Console.WriteLine(fixedAmountDiscount.Calculate(PurchaseAmount));

        }
    }
}
