using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading
{
    class Store
    {
        public Article[] article = new Article[5];

        public Store()
        {
            this.article[0].ProductName = "product1";
            this.article[0].OutletName = "outlet1";
            this.article[0].Price = 100;
            this.article[1].ProductName = "product2";
            this.article[1].OutletName = "outlet1";
            this.article[1].Price = 200;
            this.article[2].ProductName = "product3";
            this.article[2].OutletName = "outlet2";
            this.article[2].Price = 50;
            this.article[3].ProductName = "product4";
            this.article[3].OutletName = "outlet2";
            this.article[3].Price = 150;
            this.article[4].ProductName = "product5";
            this.article[4].OutletName = "outlet3";
            this.article[4].Price = 100;

        }

        public void StoreList()
        {
            for (int i = 0; i < 5; i++)
            {
                article[i].Show();
            }
        }
        // public Article[] this[int index, decimal value]
        // {
        //     get
        //     {
        //         for (int i = 0; i < 5; i++)
        //         if(article[i].Price == value)
        //                 article[i].Show() ;
        //     }
        // }
    }
}
