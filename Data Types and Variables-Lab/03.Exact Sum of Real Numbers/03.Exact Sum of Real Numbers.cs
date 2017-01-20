using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int nums = 0; nums < number; nums++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
