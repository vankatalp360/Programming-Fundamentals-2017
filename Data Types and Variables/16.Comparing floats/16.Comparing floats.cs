using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool answer = (Math.Abs(a - b) < 0.000001);
            Console.WriteLine(answer);
        }
    }
}
