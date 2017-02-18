using System;
using System.Linq;

namespace _03.Count_of_Given_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenElement = int.Parse(Console.ReadLine());
            int counterOfGivenElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == givenElement)
                {
                    counterOfGivenElement += 1;
                }
            }

            Console.WriteLine(counterOfGivenElement);
        }
    }
}
