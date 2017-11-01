using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SpecialStrategyBonus : IStrategyBonus
    {
        public double GetBonusValue(Item item)
        {
            return 0;
        }
    }
}
