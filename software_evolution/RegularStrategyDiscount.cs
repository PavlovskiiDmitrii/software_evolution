using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class RegularStrategyDiscount : IStrategyDiscount
    {
        public double StandartDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;

            if (each.getQuantity() > 2)
            {
                discount = each.GetSum() * readConfingfile.DiscounRegular;
            }

            return discount;
        }
        public double FestiveDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;
            if (each.GetSum() > readConfingfile.SummRegular)
            {
                discount = each.GetSum() * readConfingfile.DiscounRegular;
            }

            return discount;
        }
    }
}
