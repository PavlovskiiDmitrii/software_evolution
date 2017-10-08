using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class RegularGoods : Goods
    {

        public RegularGoods(String title) : base(title)
        { }


        override public double GetDiscount(Item each)
        {
            double discount = 0;
            if (each.getQuantity() > 2)
                discount = GetSum(each) * 0.03; // 3%
            return discount;
        }

        override public int GetBonus(Item each)
        {
            int bonus = 0;
            bonus = (int)(GetSum(each) * 0.05);
            return bonus;
        }
    }
}
