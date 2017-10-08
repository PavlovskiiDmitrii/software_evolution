using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public interface IPresenter
    {
        string GetHeader(Customer _customer);
        string GetItemString(Item item, double discount, int bonus, double thisAmount);
        string GetFooter(double totalAmount, int totalBonus);
    }
}
