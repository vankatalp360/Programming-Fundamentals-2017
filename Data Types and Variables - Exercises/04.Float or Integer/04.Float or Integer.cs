using System;

namespace _04.Float_or_Integer
{
    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            number = Math.Round(number);
            Console.WriteLine(number);
        }
    }
}
