using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class RegularStrategyBonus : IStrategyBonus
    {
        public double GetBonusValue(Item each, double summ)
        {
            double bonus = 0;
            if (summ > 100 && summ < 300)
            {
                bonus = 5;
            }
            if (summ >= 300 && summ <1000)
            {
            bonus =summ * 0.05;
            }
            if (summ >= 1000)
            {
            bonus = summ * 0.07;
            }
            return bonus;
        }
    }
}
