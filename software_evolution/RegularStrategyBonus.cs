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
            bonus = summ * 0.05;
            return bonus;
        }
    }
}
