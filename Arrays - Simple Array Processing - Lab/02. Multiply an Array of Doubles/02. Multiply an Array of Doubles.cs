using System;
using System.Linq;

namespace _02.Multiply_an_Array_of_Doubles
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= number;
            }

            var answer = string.Join(" ", numbers);
            Console.WriteLine(answer);
        }
    }
}
