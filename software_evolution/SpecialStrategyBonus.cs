using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SpecialStrategyBonus : IStrategyBonus
    {
        public double GetBonusValue(Item item, double summ)
        {
            double bonus = 0;
            if (summ > 500)
            {
                bonus = (summ/item.getPrice())*5;
            }
            return bonus;
        }
    }
}
