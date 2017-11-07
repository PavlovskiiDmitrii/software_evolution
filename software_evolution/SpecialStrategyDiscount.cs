using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
  public  class SpecialStrategyDiscount : IStrategyDiscount
    {
        public double StandartDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;

            if (each.getQuantity() > 10)
            {
                discount = each.GetSum() * readConfingfile.DiscounSpecial;
            }

            return discount;
        }
        public double FestiveDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;
            if (each.GetSum() > readConfingfile.SummSpesial)
            {
                discount = each.GetSum() * readConfingfile.DiscounSpecial;
            }

            return discount;
        }
    }
}
