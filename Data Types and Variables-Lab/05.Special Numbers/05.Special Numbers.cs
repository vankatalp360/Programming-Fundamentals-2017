using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            for (int nums = 1; nums <= number; nums++)
            {
                num = nums;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                bool result = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine("{0} -> {1}", nums, result);
                sum = 0;
            }
        }
    }
}
