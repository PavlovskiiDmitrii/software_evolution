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
            if (summ > 100 && summ < 500)
            {
                discount = summ*0.02;
            }
            return discount;
        }
    }
}
