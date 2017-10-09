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
        public Goods Create (Typeofdiscount id)
        {
            if (id == Typeofdiscount.RegularGoods)
            {
                return _goods = new RegularGoods("cola");
            }
            if(id == Typeofdiscount.SaleGoods)
            {
                return _goods = new SaleGoods("cola");
            }
            if(id == Typeofdiscount.SpecialGoods)
            {
                return _goods = new SpecialOrderGoods("cola");
            }
            return null;
        }
    }
}
