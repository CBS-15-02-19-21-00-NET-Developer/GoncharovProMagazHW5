using System;

namespace Trading
{
    class Program
    {
        static void Main(string[] args)
        {

            Store magaz = new Store();

            magaz.StoreList();
            magaz.SearchProductByName();
            magaz.SearchProductByIndex();



            Console.ReadKey();
        }
    }
}
