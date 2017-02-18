using System;

namespace _02.Count_of_Negative_Elements_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            int negativeElementsCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < 0)
                {
                    negativeElementsCounter += 1;
                }
            }

            Console.WriteLine(negativeElementsCounter);
        }
    }
}
