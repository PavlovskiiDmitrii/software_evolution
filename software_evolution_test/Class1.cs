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
        [Test]
        public void RegLess1()
        {
            Goods cola = new RegularGoods("Cola");
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void RegMore2()
        {
            Goods cola = new RegularGoods("Cola");
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 10);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t21,7\t368,3\t19\nСумма счета составляет 368,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleLess3()
        {
            Goods twix = new SaleGoods("Cola");
            Item i1 = new Item(twix, 2, 38);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t2\t76\t0\t76\t0\nСумма счета составляет 76\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialLess10()
        {
            Goods bread = new SpecialOrderGoods("Cola");
            Item i1 = new Item(bread, 8, 23);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t8\t184\t0\t184\t0\nСумма счета составляет 184\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialMore10()
        {
            Goods bread = new SpecialOrderGoods("Cola");
            Item i1 = new Item(bread, 13, 23);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t13\t299\t1,495\t297,505\t0\nСумма счета составляет 297,505\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleMore3()
        {
            Goods twix = new SaleGoods("Cola");
            Item i1 = new Item(twix, 7, 38);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t2,66\t263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BRegular()
        {
            Goods bonaqua = new RegularGoods("Cola");
            Item i1 = new Item(bonaqua, 8, 40);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t40\t8\t320\t9,6\t310,4\t16\nСумма счета составляет 310,4\nВы заработали 16 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BsSale()
        {
            Goods doshirak = new SaleGoods("Cola");
            Item i1 = new Item(doshirak, 20, 36);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t36\t20\t720\t7,2\t712,8\t7\nСумма счета составляет 712,8\nВы заработали 7 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BSpecial()
        {
            Goods lays = new SpecialOrderGoods("Cola");
            Item i1 = new Item(lays, 2, 93);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t93\t2\t186\t0\t186\t0\nСумма счета составляет 186\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBRegularLess5()
        {
            Goods cola = new RegularGoods("Cola");
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 20);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSpecial()
        {
            Goods bread = new SpecialOrderGoods("Cola");
            Item i1 = new Item(bread, 10, 23);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t23\t10\t230\t0\t230\t0\nСумма счета составляет 230\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBRegularMore5()
        {
            Goods cola = new RegularGoods("Cola");
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 30);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t6\t390\t41,7\t348,3\t19\nСумма счета составляет 348,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSaleMore1()
        {
            Goods twix = new SaleGoods("Cola");
            Item i1 = new Item(twix, 7, 38);
            Customer x = new Customer("test", 0);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t38\t7\t266\t2,66\t263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
    }
}
