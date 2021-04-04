using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter curency of array: ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
            }
            Console.WriteLine("Array have next elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            System.Array.Sort(array);
            //наибольшее значение массива 
            Console.WriteLine($"Max Value is: {array[array.Length - 1]}");
            //наименьшее значение массива 
            Console.WriteLine($"Min Value is: {array[0]}");
            //общую сумму элементов
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Sum of every array elements is: {sum}");
            //среднее арифметическое всех элементов
            var average = sum / array.Length;
            Console.WriteLine($"Average of array is : {average}");
            //вывести все нечетные значения
            Console.WriteLine("Array - array have next oods ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    Console.WriteLine(array[i]);
            }


            Console.ReadKey();
        }
    }
}
