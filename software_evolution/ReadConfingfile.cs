using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace software_evolution
{
    public class ReadConfingfile
    {
        public string ValueView { get; set; }
        public double DiscounRegular { get; set; }
        public double BonusRegular { get; set; }
        public double DiscounSale { get; set; }
        public double BonusSale { get; set; }
        public double DiscounSpecial { get; set; }
        public double BonusSpesial { get; set; }
        public double SummRegular { get; set; }
        public double SummSale { get; set; }
        public double SummSpesial { get; set; }


        public ReadConfingfile()
        {
            ValueView = ConfigurationManager.AppSettings.Get("view");
            Setconfing();
        }


        public void Setconfing()
        {    
           
            if (ValueView == "standart")
            {
               
                DiscounRegular = Convert.ToDouble(ConfigurationManager.AppSettings["StandartDiscountRegular"]);
                BonusRegular = Convert.ToDouble(ConfigurationManager.AppSettings["StandartBonusRegular"]);
                DiscounSale = Convert.ToDouble(ConfigurationManager.AppSettings["StandartDiscountSale"]);
                BonusSale = Convert.ToDouble(ConfigurationManager.AppSettings["StandartBonusSale"]);
                DiscounSpecial = Convert.ToDouble(ConfigurationManager.AppSettings["StandartDiscountSpecial"]);
                BonusSpesial = Convert.ToDouble(ConfigurationManager.AppSettings["StandartBonusSpecial"]);
            }
            else
            {
                SummRegular = Convert.ToInt32(ConfigurationManager.AppSettings["FestiveSummRegular"]);
                SummSale = Convert.ToInt32(ConfigurationManager.AppSettings["FestiveSummSaler"]);
                SummSpesial = Convert.ToInt32(ConfigurationManager.AppSettings["FestiveSummSpecial"]);
                DiscounRegular = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveDiscountRegular"]);
                BonusRegular = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveBonusRegular"]);
                DiscounSale = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveDiscountSale"]);
                BonusSale = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveBonusSale"]);
                DiscounSpecial = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveDiscountSpecial"]);
                BonusSpesial = Convert.ToDouble(ConfigurationManager.AppSettings["FestiveBonusSpecial"]);
                
            }
        }
    }
}
