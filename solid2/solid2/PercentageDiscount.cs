using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2
{
    public class PercentageDiscount : Discount
    {
        double DiscountPercentage {  get; set; }

        public PercentageDiscount(double discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public override double Calculate(double purchaseAmount)
        {
            return purchaseAmount * (1 - DiscountPercentage/100);
        }
    }
}
