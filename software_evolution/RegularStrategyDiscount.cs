using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class RegularStrategyDiscount : IStrategyDiscount
    {
        public double GetDiscountValue(Item each, double summ)
        {
            double discount = 0;
            if (each.getQuantity() > 2)
                discount = summ * 0.03; // 3%
            return discount;
        }
    }
}
