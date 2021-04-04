using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter currency rows of matrix: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter currency colums of matrix: ");
            int y = int.Parse(Console.ReadLine());
            MyMatrix matrix = new MyMatrix(x, y);

            matrix.PrintMattrix();
            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Enter currency rows of the derived matrix: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter currency colums of the derived matrix: ");
            int y1 = int.Parse(Console.ReadLine());
            matrix.ResizeMattrix(x1, y1);

            Console.ReadKey();

        }
    }
}
