using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Tear_List_in_Half
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstPart = new List<int>();
            var secondPart = new List<int>();
            var answer = new List<int>();
            var count = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                secondPart.Add(numbers[i]);
            }
            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                firstPart.Add(numbers[i]);
            }

            for (int i = 0; i < firstPart.Count; i++)
            {
                foreach (var symbol in firstPart[i].ToString())
                {
                    count++;
                    var digit = symbol - '0';
                    if (count != 2)
                    {
                        answer.Add(digit);
                        answer.Add(secondPart[i]);
                    }
                    else if (count == 2)
                    {
                        answer.Add(digit);
                    }
                }
                count = 0;
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
