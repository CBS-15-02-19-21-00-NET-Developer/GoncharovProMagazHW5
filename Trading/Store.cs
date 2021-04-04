using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading
{
    class Store
    {
        public Article [] article = new Article[5];

        public Store()
        {
            article[0] = new Article();
            this.article[0].ProductName = "product1";
            this.article[0].OutletName = "outlet1";
            this.article[0].Price = 100;
            article[1] = new Article();
            this.article[1].ProductName = $"product2";
            this.article[1].OutletName = "outlet1";
            this.article[1].Price = 200;
            article[2] = new Article();
            this.article[2].ProductName = "product3";
            this.article[2].OutletName = "outlet2";
            this.article[2].Price = 50;
            article[3] = new Article();
            this.article[3].ProductName = "product4";
            this.article[3].OutletName = "outlet2";
            this.article[3].Price = 150;
            article[4] = new Article();
            this.article[4].ProductName = "product5";
            this.article[4].OutletName = "outlet3";
            this.article[4].Price = 100;

        }

        public void StoreList()
        {
            for (int i = 0; i < article.Length; i++)
            {
                article[i].Show();
                Console.WriteLine("\n");
            }
            Console.WriteLine(new string ('*',40));
        }
        public void SearchProductByIndex()
        {
            Console.WriteLine("Enter index of prodct for search");
            int indexForSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < article.Length; i++)
            {
                if (i == indexForSearch)
                {
                    article[i].Show();
                    Console.WriteLine("\n");
                }
            }
        }
        public void SearchProductByName()
        {
            Console.WriteLine("Enter name of prodct for search");
            string nameForSearch = Console.ReadLine();
            for (int i = 0; i < article.Length; i++)
            {
                if (article[i].ProductName == nameForSearch ) 
                {
                    article[i].Show();
                    Console.WriteLine("\n");
                }
            }
        }
        
    }
}
