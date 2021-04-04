using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MyMatrix
    {
        private static int rows;
        private static int colums;
        private int[,] matrix;
        Random rdm = new Random();
        public int Rows { set; get; }
        public int Colums { set; get; }
        public MyMatrix(int row, int colum)
        {
            Rows = row;
            Colums = colum;
            matrix = new int[Rows, Colums];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colums; j++)
                {
                    matrix[i, j] = rdm.Next(0, 20);
                }
            }
        }
        public void PrintMattrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colums; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void ResizeMattrix(int x, int y)
        {
            if (x < Rows || y < Colums)
            {
                for (int i = 0; i < x; i++)
                {

                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));
                for (int i = 0; i < x; i++)
                {
                    for (int j = Colums - y; j < Colums; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));

                for (int i = Rows - x; i < Rows; i++)
                {

                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));
                for (int i = Rows - x; i < Rows; i++)
                {
                    for (int j = Colums - y; j < Colums; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('_', 20));
            }
            else
                Console.WriteLine("Currency out of range");
        }
    }
}
