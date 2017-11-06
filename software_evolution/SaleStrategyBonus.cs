using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class SaleStrategyBonus : IStrategyBonus
    {
        public double StandartBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;

            if (each.getQuantity() > 10)
            {
                bonus = each.GetSum() * readConfingfile.BonusSale;
            }

            return bonus;
        }
        public double FestiveBonusValue(Item each, ReadConfingfile readConfingfile)
        {
            double bonus = 0;
            if (each.GetSum() > readConfingfile.SummSale)
            {
                bonus = each.GetSum() * readConfingfile.BonusSale;
            }

            return bonus;
        }
    }
}
