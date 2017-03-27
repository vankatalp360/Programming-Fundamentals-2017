using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fold_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = numbers.Length / 4;
            var leftPart = numbers.Take(k).Reverse().ToArray();
            var rightPart = numbers.Reverse().Take(k).ToArray();
            var row1 = leftPart.Concat(rightPart);
            var row2 = numbers.Skip(k).Take(2 * k).ToArray();
            var answer = row1.Select((n, index) => n + row2[index]);

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
