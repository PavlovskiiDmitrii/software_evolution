using System;
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
            public Bill(Customer customer)
            {
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
                if ((each.getGoods().GetType() ==
                  typeof(RegularGoods)) && each.getQuantity() > 5)
                    usedBonus = _customer.useBonus((int)(each.GetSum() - each.GetBonus()));
                if ((each.getGoods().GetType() ==
                  typeof(SpecialOrderGoods)) && each.getQuantity() > 1)
                    usedBonus = _customer.useBonus((int)(each.GetSum() - each.GetDiscount()));
                return usedBonus;
            }
            public string GetHeader()
            {
                string headerresult = "Счет для " + _customer.getName() + "\n" + "\t" + "Название" + "\t" + "Цена" + "\t" + "Кол-во" + "Стоимость" + "\t" + "Скидка" + "\t" + "Сумма" + "\t" + "Бонус" + "\n";
                return headerresult;
            }
            public string GetItemString(Item item, double discount, int bonus, double thisAmount)
            {
                string itemresult = "\t" + item.getGoods().getTitle() + "\t" + "\t" + item.getPrice() + "\t" + item.getQuantity() + "\t" + (item.GetSum()).ToString() + "\t" + discount.ToString() + "\t" + thisAmount.ToString() + "\t" + bonus.ToString() + "\n";
                return itemresult;
            }
            public string GetFooter(double totalAmount, int totalBonus)
            {
                string Footerresult = "Сумма счета составляет " + totalAmount.ToString() + "\n" + "Вы заработали " + totalBonus.ToString() + " бонусных балов";
                return Footerresult;
            }

            public String statement()
            {
                double totalAmount = 0;
                int totalBonus = 0;
                List<Item>.Enumerator items = _items.GetEnumerator();
                String result = GetHeader();
                while (items.MoveNext())
                {
                    double thisAmount = 0;
                    Item each = (Item)items.Current;
                    //определить сумму для каждой строки

                    double discount = each.GetDiscount();
                    int bonus = each.GetBonus();
                    int usedBonus = GetUsedBonus(each);
                    thisAmount = each.GetSum() - discount - usedBonus;
                    //показать результаты
                    result += GetItemString(each, discount + usedBonus, bonus, thisAmount);
                    totalAmount += thisAmount;
                    totalBonus += bonus;
                }
                //добавить нижний колонтитул
                result += GetFooter(totalAmount, totalBonus);
                //Запомнить бонус клиента
                _customer.receiveBonus(totalBonus);


                return result;
            }
        
    }
}
