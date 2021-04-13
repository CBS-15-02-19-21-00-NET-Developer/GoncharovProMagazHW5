using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            BaseClass dictionary;
            DerivedClass instance;
            Console.WriteLine("Choose direction of translation(1: rus-eng, 2: rus-pl)");
            
            Lable1:
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            { instance= new DerivedClass("book", "pen", "sun", "apple", "table"); }
            else if (choose == 2)
            { instance = new DerivedClass(); }
            else 
            { 
                    Console.WriteLine("Wrong choose!!!!! choose 1 or 2");
                goto Lable1;
                }
            dictionary = instance;

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]); 

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
                           
            }
            // Delay.
            Console.ReadKey();
        }
    }
}
