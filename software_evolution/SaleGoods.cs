using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class SaleGoods : Goods
    {
        public SaleGoods(String title) : base(title)
        { }


        override public double GetDiscount(Item each)
        {
            double discount = 0;
            if (each.getQuantity() > 3)
                discount = GetSum(each) * 0.01; // 0.1%
            return discount;
        }

        override public int GetBonus(Item each)
        {
            int bonus = 0;
            bonus = (int)(GetSum(each) * 0.01);
            return bonus;
        }

    }
}
