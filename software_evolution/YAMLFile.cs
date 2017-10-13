using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class YAMLFile : AbstractContentFile
    {
        BillFactory _billfactory = new BillFactory();
        TextReader sr;
        Customer customer;
        string line;
        string[] result;
        string name;
        int bonus;
        int itemsCount;

        public void SetSours(TextReader sr)
        {
            this.sr = sr;
            GetNextLine();
            name = result[1].Trim();
        }

        public void Readbonus()
        {
            GetNextLine();
            bonus = Convert.ToInt32(result[1].Trim());
        }

        public Customer GetCustomer()
        {
            customer = new Customer(name, bonus);
            return customer;
        }

        //IPresenter p = new TXTPresenter();
        //Bill b = new Bill(customer, p);

        public int GetGoodsCount()
        {
            GetNextLine();
            int goodsCount = Convert.ToInt32(result[1].Trim());
            return goodsCount;
        }

        //Goods[] g = new Goods[goodsQty];


        public void SetTypeGoods(Goods[] g)
        {
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
                        g[i] = _billfactory.Create(Typeofdiscount.RegularGoods);
                            break;
                    case "SAL":
                        g[i] = _billfactory.Create(Typeofdiscount.SaleGoods);
                        break;
                    case "SPO":
                        g[i] = _billfactory.Create(Typeofdiscount.SpecialGoods);
                        break;
                }
            }
        }

        public int GetItemsCount()
        {
            do
            {
                line = sr.ReadLine();
            } while (line.StartsWith("#"));
            result = line.Split(':');
            itemsCount = Convert.ToInt32(result[1].Trim());
            return itemsCount;
        }

        public void SetParameterItems(Bill b,Goods[] g)
        {
            for (int i = 0; i < itemsCount; i++)
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
        }
        
        public void GetNextLine()
        {
            line = sr.ReadLine();
            result = line.Split(':');
        }

        public string CreateBill(StreamReader sr, IPresenter p)
        {
            SetSours(sr);
            Readbonus();
            GetCustomer();
            Bill b = new Bill(GetCustomer(), p);
            Goods[] g = new Goods[GetGoodsCount()];
            SetTypeGoods(g);
            GetItemsCount();
            SetParameterItems(b, g);
            return b.statement();
        }


    }
}
