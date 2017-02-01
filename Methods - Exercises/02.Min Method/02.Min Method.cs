using System;

namespace _02.Min_Method
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int answer = GetMin(a, b, c);
            Console.WriteLine(answer);
        }

        public static int GetMin(int a, int b, int c)
        {
            int first = Math.Min(a, b);
            return Math.Min(first, c);
        }
    }
}
