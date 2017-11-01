using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public interface IStrategyBonus
    {
        double GetBonusValue(Item item);
    }
}
