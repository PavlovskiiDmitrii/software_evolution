using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SpecialStrategyBonus : IStrategyBonus
    {
        public double StandartBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;

            if (each.getQuantity() > 5)
            {
                bonus = each.GetSum() * readConfingfile.BonusSpesial;
            }

            return bonus;
        }
        public double FestiveBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;
            if (each.GetSum() > readConfingfile.SummSpesial)
            {
                bonus = each.GetSum() * readConfingfile.BonusSpesial;
            }

            return bonus;
        }
    }
}
