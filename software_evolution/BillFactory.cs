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
                return _goods = new RegularGoods(title);
            }
            if(id == Typeofdiscount.SaleGoods)
            {
                return _goods = new SaleGoods(title);
            }
            if(id == Typeofdiscount.SpecialGoods)
            {
                return _goods = new SpecialOrderGoods(title);
            }
            return null;
        }
    }
}
