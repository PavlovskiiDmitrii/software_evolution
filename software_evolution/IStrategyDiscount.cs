using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public interface IStrategyDiscount
    {
        double GetDiscountValue(Item item, double summ);
    }
}
