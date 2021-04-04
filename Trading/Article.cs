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

        private string outletName;

        private decimal price = 100m;
        public string ProductName
        {
            set
            {
                productName = value;
            }
            get
            {
                return productName;
            }
        }
        public Article()
        {
        }
        public string OutletName
        {
            set
            {
                outletName = value;
            }
            get
            {
                return outletName;
            }
        }
        public decimal Price
        {
            set
            {
                price = value
                    ;
            }
            get
            {
                return price;
            }
        }




        public void Show()
        {
            Console.Write(ProductName + "\t|");
            Console.Write(OutletName + "\t|");
            Console.Write(Price);
        }

    }
}

