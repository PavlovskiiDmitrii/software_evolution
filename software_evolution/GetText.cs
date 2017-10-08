using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    public class GetText
    {
        public string Get_String(TextReader sr)
        {
            // read customer
            //SetSours
            string line = sr.ReadLine();
            string[] result = line.Split(':');
            string name = result[1].Trim();


            // read bonus
            line = sr.ReadLine();
            result = line.Split(':');
            int bonus = Convert.ToInt32(result[1].Trim());

            //Customer
            Customer customer = new Customer(name, bonus);


            IPresenter p = new TXTPresenter();
            Bill b = new Bill(customer, p);


            // read goods count
            line = sr.ReadLine();
            result = line.Split(':');
            int goodsQty = Convert.ToInt32(result[1].Trim());
            Goods[] g = new Goods[goodsQty];


            for (int i = 0; i < g.Length; i++)
            {
                // Пропустить комментарии
                do
                {
                  line = sr.ReadLine();
                } while (line.StartsWith("#"));
                result = line.Split(':');
                result = result[1].Trim().Split();
                string type = result[1].Trim();

               
                switch (type)
                {
                    case "REG":
                        g[i] = new RegularGoods(result[0]);
                        break;
                    case "SAL":
                        g[i] = new SaleGoods(result[0]);
                        break;
                    case "SPO":
                        g[i] = new SpecialOrderGoods(result[0]);
                        break;
                }
            }
            // read items count
            // Пропустить комментарии
            do
            {
                line = sr.ReadLine();
            } while (line.StartsWith("#"));
            result = line.Split(':');
            int itemsQty = Convert.ToInt32(result[1].Trim());


            for (int i = 0; i < itemsQty; i++)
            {
                // Пропустить комментарии
                do
                {
                 line = sr.ReadLine();
                } while (line.StartsWith("#"));
                result = line.Split(':');
                result = result[1].Trim().Split();
                int gid = Convert.ToInt32(result[0].Trim());

                double price = Convert.ToDouble(result[1].Trim());

                int qty = Convert.ToInt32(result[2].Trim());

                b.addGoods(new Item(g[gid - 1], qty, price));
            }

            string bill = b.statement();

            return bill;
        }
    }
}
