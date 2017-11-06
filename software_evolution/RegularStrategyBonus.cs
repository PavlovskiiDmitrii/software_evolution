using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class RegularStrategyBonus : IStrategyBonus
    {
        public double StandartBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;
            
            if (each.getQuantity() > 2 )
            {
                bonus = each.GetSum() * readConfingfile.BonusRegular;
            }
          
            return bonus;
        }
        public double FestiveBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;
            if (each.GetSum() > readConfingfile.SummRegular)
            {
                bonus = each.GetSum() * readConfingfile.BonusRegular;
            }

            return bonus;
        }
    }
}
