using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
  public  class RegularStrategyBonus : IStrategyBonus
    {
        public double StandartBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            return each.GetSum() * readConfingfile.BonusRegular;
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
