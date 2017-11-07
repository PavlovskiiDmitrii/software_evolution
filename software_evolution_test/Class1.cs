using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using software_evolution;

namespace software_evolution_test
{
    [TestFixture]
    public class Tests
    {

        ReadConfingfile ConfingValue = new ReadConfingfile();
        [Test]
        public void RegLess1_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x,p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void RegMore2_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 10);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t21,7\t368,3\t19\nСумма счета составляет 368,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleLess3_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 2, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t2\t76\t0\t76\t0\nСумма счета составляет 76\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialLess10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 8, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t8\t184\t0\t184\t0\nСумма счета составляет 184\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialMore10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 13, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t13\t299\t14,95\t284,05\t0\nСумма счета составляет 284,05\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleMore3()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t2,66\t263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BRegular()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 8, 40);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t40\t8\t320\t9,6\t310,4\t16\nСумма счета составляет 310,4\nВы заработали 16 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BsSale()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 20, 36);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t36\t20\t720\t7,2\t712,8\t7\nСумма счета составляет 712,8\nВы заработали 7 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 2, 93);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t93\t2\t186\t0\t186\t0\nСумма счета составляет 186\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
        [Test]
        public void UseBRegularLess5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 20);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 45\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 10, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t10\t230\t0\t230\t0\nСумма счета составляет 230\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBRegularMore5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 30);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t41,7\t348,3\t19\nСумма счета составляет 348,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSaleMore1()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t2,66\t263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void HTMLPresenter()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new HTMLPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\n\t|Название|\t|Цена|\t|Кол-во||Стоимость|\t|Скидка||Сумма|\t|Бонус|\n\t|Cola|\t\t|38|\t|7|\t|266|\t\t|2,66|\t|263,34|\t|2|\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }


        // СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        // СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        // СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        // СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        // СПЕЦИАЛЬНЫЕ СКИДКИ \\\


        public void NYRegLess1_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYRegMore2_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 10);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t25,6\t364,4\t23\nСумма счета составляет 364,4\nВы заработали 23 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSaleLess3_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 2, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t2\t76\t0\t76\t0\nСумма счета составляет 76\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSpecialLess10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 8, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t8\t184\t0\t184\t0\nСумма счета составляет 184\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSpecialMore10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 13, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t13\t299\t0\t299\t0\nСумма счета составляет 299\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSaleMore3()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t0\t266\t0\nСумма счета составляет 266\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBRegular()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 8, 40);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t40\t8\t320\t12,8\t307,2\t19\nСумма счета составляет 307,2\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBsSale()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 20, 36);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t36\t20\t720\t14,4\t705,6\t14\nСумма счета составляет 705,6\nВы заработали 14 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 2, 93);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t93\t2\t186\t0\t186\t0\nСумма счета составляет 186\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
        [Test]
        public void NYUseBRegularLess5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 20);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t0\nСумма счета составляет 45\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 10, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t10\t230\t0\t230\t0\nСумма счета составляет 230\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBRegularMore5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 30);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t45,6\t344,4\t23\nСумма счета составляет 344,4\nВы заработали 23 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBSaleMore1()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t0\t266\t0\nСумма счета составляет 266\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
    }
}
