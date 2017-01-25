using System;

namespace _03.Printing_Triangle
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);;
        }

        public static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColums(row);
            }

            for (int row = number - 1; row >= 1; row--)
            {
                PrintColums(row);
            }
        }

        public static void PrintColums(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
    }
}
