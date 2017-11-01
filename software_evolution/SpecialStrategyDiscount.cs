using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SpecialStrategyDiscount : IStrategyDiscount
    {
        public double GetDiscountValue(Item each)
        {
            double discount = 0;
            if (each.getQuantity() > 10)
                discount = GetSum(each) * 0.05; // 0.5%
            return discount;
        }
    }
}
