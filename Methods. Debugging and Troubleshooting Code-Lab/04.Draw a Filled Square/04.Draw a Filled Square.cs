using System;

namespace _04.Draw_a_Filled_Square
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int middleRow = 1; middleRow <= n - 2; middleRow++)
            {
                PrintBody(n);
            }
            PrintHeader(n);
        }

        public static void PrintHeader(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        public static void PrintBody(int number)
        {
            Console.Write('-');
            for (int middle = 1; middle < number; middle++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }
    }
}
