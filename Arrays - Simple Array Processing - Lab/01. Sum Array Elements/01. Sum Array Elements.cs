using System;

namespace _01.Sum_Array_Elements
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); ;
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
