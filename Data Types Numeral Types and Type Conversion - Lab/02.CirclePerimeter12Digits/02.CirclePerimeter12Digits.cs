using System;

namespace _02.CirclePerimeter12Digits
{
    public class Program
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:F12}", perimeter);
        }
    }
}
