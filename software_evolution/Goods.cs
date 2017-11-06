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
        public Typeofdiscount _type;
        public IStrategyBonus _istrategyBonus;
        public IStrategyDiscount _istrategyDiscount;
        public double summ;
        ReadConfingfile Confingfile;

        public Goods(String title, Typeofdiscount type, IStrategyBonus strategyBonus, IStrategyDiscount strategyDiscount, ReadConfingfile readConfingfile)
        {
            _type = type;
            _title = title;
            _istrategyBonus = strategyBonus;
            _istrategyDiscount = strategyDiscount;
            Confingfile = readConfingfile;
        }


        public String getTitle()
        {
            return _title;
        }
        public Typeofdiscount getGoodsType()
        {
            return _type;
        }

        public void SetSumm(Item each)
        {
            summ = each.getQuantity() * each.getPrice(); ;
        }
        public double GetSum(Item each)
        {
          return each.getQuantity() * each.getPrice();
        }

        public double GetDiscount(Item each)
        {
            if(Confingfile.ValueView == "standart")
            {
                return _istrategyDiscount.StandartDiscountValue(each, Confingfile);
            }

            return _istrategyDiscount.FestiveDiscountValue(each, Confingfile);
        }

        public double GetBonus(Item each)
        {
            if(Confingfile.ValueView == "standart")
            {
                return _istrategyBonus.StandartBonusValue(each, Confingfile);
            }
            return _istrategyBonus.FestiveBonusValue(each, Confingfile);
        }
    }
}
