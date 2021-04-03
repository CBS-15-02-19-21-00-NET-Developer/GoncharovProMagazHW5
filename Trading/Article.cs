using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading
{
    class Article
    {
        private string productName;
        public string ProductName { set; get; }
        private string outletName;
        public string OutletName { set; get; }
        private decimal price;
        public decimal Price { set; get; }

        public void Show()
        {
            Console.Write(ProductName + "\t|");
            Console.Write(OutletName + "\t|");
            Console.Write(Price);
        }
    }
}
