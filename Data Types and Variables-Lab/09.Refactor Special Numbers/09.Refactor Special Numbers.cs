using System;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool result = false;
            for (int nums = 1; nums <= number; nums++)
            {
                num = nums;
                while (nums > 0)
                {
                    sum += nums % 10;
                    nums = nums / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {result}");
                sum = 0;
                nums = num;
            }
        }
    }
}
