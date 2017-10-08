using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class SpecialOrderGoods : Goods

    {
        public SpecialOrderGoods(String title) : base(title)
        { }

        override public double GetDiscount(Item each)
        {
            double discount = 0;
            if (each.getQuantity() > 10)
                discount = GetSum(each) * 0.005; // 0.5%
            return discount;
        }

        override public int GetBonus(Item each)
        {
            return 0;
        }

    }
}
