using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;

        // Конструктор.
        public DerivedClass()
        {
            derivedArray = new string[5];
            derivedArray[0] = "książka";
            derivedArray[1] = "długopis";
            derivedArray[2] = "słońce";
            derivedArray[3] = "jabłko";
            derivedArray[4] = "stół";
        }
        public DerivedClass(string zero, string  one, string two, string three, string four)
        {
            derivedArray = new string[5];
            derivedArray[0] = zero;
            derivedArray[1] = one;
            derivedArray[2] = two;
            derivedArray[3] = three;
            derivedArray[4] = four;
        }
        //Переопределенный индексатор.
      
        public override string this[int index]
        {
            get
            {
                if (index >= 0 && index < derivedArray.Length)
                    return base[index] + " - " + derivedArray[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public override string this[string index]
        {
            get
            {
                for (int i = 0; i < derivedArray.Length; i++)
                    if (base[i] == index)
                        return base[i] + " - " + derivedArray[i];
       
                return string.Format($"{index} - нет перевода для этого слова.");
            }
        }

        

    }
}
