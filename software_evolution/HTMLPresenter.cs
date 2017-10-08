using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
   public class HTMLPresenter  : IPresenter
    {
        public string GetHeader(Customer _customer)
        {
            string headerresult = "Счет для " + _customer.getName() + "\n" + "\n" +"\t" + "|Название|" + "\t" + "|Цена|" + "\t" + "|Кол-во|" + "|Стоимость|" + "\t" + "|Скидка|"  + "|Сумма|" + "\t" + "|Бонус|" + "\n";
            return headerresult;
        }
        public string GetItemString(Item item, double discount, int bonus, double thisAmount)
        {
            string itemresult = "\t" +"|"+ item.getGoods().getTitle() +"|"+ "\t" + "\t" + "|" + item.getPrice() + "|" + "\t" + "|" + item.getQuantity() + "|" + "\t" + "|" + (item.GetSum()).ToString() + "|" + "\t" + "\t" + "|" + discount.ToString() + "|" + "\t" + "|" + thisAmount.ToString() + "|" + "\t" + "|" + bonus.ToString() + "|" + "\n";
            return itemresult;
        }
        public string GetFooter(double totalAmount, int totalBonus)
        {
            string Footerresult = "Сумма счета составляет " + totalAmount.ToString() + "\n" + "Вы заработали " + totalBonus.ToString() + " бонусных балов";
            return Footerresult;
        }
    }
}
