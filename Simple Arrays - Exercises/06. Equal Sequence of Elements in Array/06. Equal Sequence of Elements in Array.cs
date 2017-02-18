using System;
using System.Linq;

namespace _05.Increasing_Sequence_of_Elements
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string answer = string.Empty;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    answer = "Yes";
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
