using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_evolution
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string filename = "BillInfo.yaml";
            if (args.Length == 1)
            {
                filename = args[0];
            }
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            YAMLFile _yamlfile = new YAMLFile();
            _yamlfile.SetSours(sr);
            _yamlfile.Readbonus();
            _yamlfile.GetCustomer();

            IPresenter p = new TXTPresenter();
            Bill b = new Bill(_yamlfile.GetCustomer(), p);

            int goodsCount = _yamlfile.GetGoodsCount();
            Goods[] g = new Goods[goodsCount];
            _yamlfile.SetTypeGoods(g);
            _yamlfile.GetItemsCount();
            _yamlfile.SetParameterItems(b, g);


            Console.WriteLine(_yamlfile.Returnbill(b));

            //GetText _gettext = new GetText();
            //Console.WriteLine(_gettext.Get_String(sr));

            Console.ReadKey();
        }
    }
}
