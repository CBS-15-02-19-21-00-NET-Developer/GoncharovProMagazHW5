using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class BaseClass
    {
        private string[] baseArray = null;

        // Конструктор.
        public BaseClass()
        {
            baseArray = new string[5];
            baseArray[0] = "книга";
            baseArray[1] = "ручка";
            baseArray[2] = "солнце";
            baseArray[3] = "яблоко";
            baseArray[4] = "стол";
        }

        // Виртуальный индексатор.

        public virtual string this[int index]
        {
            get
            {
                if (index >= 0 && index < baseArray.Length)
                    return baseArray[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public virtual string this[string index]
        {
            get
            {
                for (int i = 0; i < baseArray.Length; i++)
                    if (baseArray[i] == index)
                        return baseArray[i];

                return string.Format($"{index} - нет перевода для этого слова.");
            }
        }
    }
}
