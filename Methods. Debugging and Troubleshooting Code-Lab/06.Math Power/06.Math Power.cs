using System;

namespace _06.Math_Power
{
    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        public static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
