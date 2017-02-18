using System;
using System.Linq;

namespace _05.Char_Rotation
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string answer = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += (char)(text[i] - numbers[i]);
                }
                else
                {
                    answer += (char)(numbers[i] + text[i]);
                }
            }

            Console.WriteLine(answer);
        }
    }
}
