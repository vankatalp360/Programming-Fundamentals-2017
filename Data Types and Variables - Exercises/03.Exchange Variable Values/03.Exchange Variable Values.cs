using System;

namespace _03.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int old = 0;
            old = a;
            a = b;
            b = old;
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
        }
    }
}
