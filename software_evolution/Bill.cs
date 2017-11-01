using System;
using System.Windows;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
        public class Bill
        {
            private List<Item> _items;

            private Customer _customer;

            private IPresenter p;

            public Bill(Customer customer,IPresenter p)
            {
                this.p = p;
                this._customer = customer;
                this._items = new List<Item>();
            }
            public void addGoods(Item arg)
            {
                _items.Add(arg);
            }
        
            public int GetUsedBonus(Item each)
            {
             
                 int usedBonus = 0;
            
                 if ((each.getGoods().GetType() == typeof(RegularStrategyBonus)) && each.getQuantity() > 5)
                 {
                  usedBonus = _customer.useBonus((int)(each.GetSum() - each.GetBonus()));
                 }

                 if ((each.getGoods().GetType() == typeof(SpecialStrategyBonus)) && each.getQuantity() > 1)
            {
                  usedBonus = _customer.useBonus((int)(each.GetSum() - each.GetDiscount()));
                 }

                return usedBonus;
            }
           
            public String statement()
            {
                double totalAmount = 0;
                int totalBonus = 0;
                List<Item>.Enumerator items = _items.GetEnumerator();
                String result = p.GetHeader(_customer);
                while (items.MoveNext())
                {
                    double thisAmount = 0;
                    Item each = (Item)items.Current;
                //определить сумму для каждой строки
                    each.SetSumm();
                    double discount = each.GetDiscount();
                    double bonus = each.GetBonus();
                    int usedBonus = GetUsedBonus(each);
                    thisAmount = each.GetSum() - discount - usedBonus;
                    //показать результаты
                    result += p.GetItemString(each, discount + usedBonus, (int)bonus, thisAmount);
                    totalAmount += thisAmount;
                    totalBonus += (int)bonus;
                }
                //добавить нижний колонтитул
                result += p.GetFooter(totalAmount, totalBonus);
                //Запомнить бонус клиента
                _customer.receiveBonus(totalBonus);


                return result;
            }
        
    }
}
