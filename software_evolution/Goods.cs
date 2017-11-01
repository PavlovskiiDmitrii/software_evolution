using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class Goods
    {
        protected String _title;
        public IStrategyBonus _istrategyBonus;
        public IStrategyDiscount _istrategyDiscount;
        public double summ;

        public Goods(String title, IStrategyBonus strategyBonus, IStrategyDiscount strategyDiscount)
        {
            _title = title;
            _istrategyBonus = strategyBonus;
            _istrategyDiscount = strategyDiscount;
        }


        public String getTitle()
        {
            return _title;
        }

        public double GetSum(Item each)
        {
            summ = each.getQuantity() * each.getPrice();
            return summ;
        }

        public double GetDiscount(Item each)
        {
            return _istrategyDiscount.GetDiscountValue(each,summ);
        }

        public double GetBonus(Item each)
        {
            return _istrategyBonus.GetBonusValue(each,summ);
        }
    }
}
