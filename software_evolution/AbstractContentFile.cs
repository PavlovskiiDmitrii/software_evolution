using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    abstract class AbstractContentFile 
    {
        abstract public Customer GetCustomer();

        abstract public int GetGoodsCount();

        abstract public int GetItemsCount();

        abstract public string GetNextGoods();

        abstract public string GetNextItem();

        abstract public void SetSours(TextReader sr);
    }
}
