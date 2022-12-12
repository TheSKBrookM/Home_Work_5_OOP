using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_5_3
{
    internal class Article
    {
        private double costUAH;
        public string NameItem { get; private set; }
        public string NameShop { get; private set; }
        public double CostUAH 
        {
            get
            {
                return costUAH;
            }
            set
            {
                costUAH = value;
            }
        }
        public Article(string nameItem, string nameShop, double costUAH)
        {
            NameItem = nameItem;
            NameShop = nameShop;
            CostUAH = costUAH;
        }
        public string ShowInfo()
        {
            string info = ($"{NameItem} from {NameShop} cost {costUAH} UAH.");

            return info;
        }
    }
}
