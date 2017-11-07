using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class SaleStrategyDiscount : IStrategyDiscount
    {
        public double StandartDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;

            if (each.getQuantity() > 3)
            {
                discount = each.GetSum() * readConfingfile.DiscounSale;
            }

            return discount;
        }
        public double FestiveDiscountValue(Item each, ReadConfingfile readConfingfile)
        {
            double discount = 0;
            if (each.GetSum() > readConfingfile.SummSale)
            {
                discount = each.GetSum() * readConfingfile.DiscounSale;
            }

            return discount;
        }
    }
}
