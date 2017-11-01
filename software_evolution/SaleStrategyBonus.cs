using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SaleStrategyBonus : IStrategyBonus
    {
        public double GetBonusValue(Item each, double summ)
        {
            double bonus = 0;
            bonus = summ * 0.01;
            return bonus;
        }
    }
}
