using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SpecialStrategyDiscount : IStrategyDiscount
    {
        public double GetDiscountValue(Item each, double summ)
        {
            double discount = 0;
            if (summ > 100 && summ < 300)
            {
                discount = summ*0.01;
            }
            if (summ >= 300 && summ < 1000)
            {
                discount = summ * 0.05;
            }
            if (summ >= 1000)
            {
                discount = summ * 0.07;
            }
            return discount;
        }
    }
}
