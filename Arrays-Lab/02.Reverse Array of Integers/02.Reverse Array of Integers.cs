using System;

namespace _02.Reverse_Array_of_Integers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
