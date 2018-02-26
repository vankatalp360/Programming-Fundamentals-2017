using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1
{
    public class Program
    {
        public static void Main()
        {
            var wormsLenghtInput = BigInteger.Parse(Console.ReadLine());
            var wormsWidth = double.Parse(Console.ReadLine());

            double wormsLenght = (double)wormsLenghtInput * 100;
            var remainder = wormsLenght % wormsWidth;

            if (remainder == 0 || wormsWidth == 0)
            {
                var result = (decimal)(wormsLenght * wormsWidth);
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                var result = (decimal)(wormsLenght / wormsWidth) * 100;
                Console.WriteLine($"{result:F2}%");
            }
        }
    }
}
