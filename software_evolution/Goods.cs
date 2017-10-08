using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public abstract class Goods
    {
        protected String _title;

        public Goods(String title)
        {
            _title = title;
        }

        public String getTitle()
        {
            return _title;
        }

        public double GetSum(Item each)
        {
            double sum = each.getQuantity() * each.getPrice();
            return sum;
        }

        abstract public double GetDiscount(Item each);

        abstract public int GetBonus(Item each);
    }
}
