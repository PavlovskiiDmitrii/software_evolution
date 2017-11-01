using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public enum Typeofdiscount
    {
        RegularGoods,
        SaleGoods,
        SpecialGoods
    }
    public class BillFactory
    {
        Goods _goods;
        // <<ФАБРИЧНЫЙ МЕТОД>>
        public Goods Create (Typeofdiscount id,string title)
        {
            if (id == Typeofdiscount.RegularGoods)
            {
                return _goods = new Goods(title, new RegularStrategyBonus(), new RegularStrategyDiscount());
            }
            if(id == Typeofdiscount.SaleGoods)
            {
                return _goods = new Goods(title, new SaleStrategyBonus(), new SaleStrategyDiscount());
            }
            if(id == Typeofdiscount.SpecialGoods)
            {
                return _goods = new Goods(title, new SpecialStrategyBonus(), new SpecialStrategyDiscount());
            }
            return null;
        }
    }
}
