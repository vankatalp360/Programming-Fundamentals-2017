using System;

namespace _01.Largest_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            int theLargestElement = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] > theLargestElement)
                {
                    theLargestElement = numbers[i];
                }
            }

            Console.WriteLine(theLargestElement);
        }
    }
}
