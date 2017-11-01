using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SaleStrategyDiscount : IStrategyDiscount
    {
        public double GetDiscountValue(Item each, double summ)
        {
            double discount = 0;
            if (each.getQuantity() > 3)
                discount = summ * 0.01; // 0.1%
            return discount;
        }
    }
}
