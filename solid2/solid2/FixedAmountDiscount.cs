using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2
{
    public class FixedAmountDiscount : Discount
    {
        double DiscountAmount { get; set; }

        public FixedAmountDiscount(double discountAmount)
        {
            DiscountAmount = discountAmount;
        }
        public override double Calculate(double purchaseAmount)
        {
            return purchaseAmount - DiscountAmount;
        }
    }
}
