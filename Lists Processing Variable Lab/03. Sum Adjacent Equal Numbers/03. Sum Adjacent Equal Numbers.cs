using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    while (i < numbers.Count - 1)
                    {
                        if (numbers[i] == numbers[i + 1])
                        {
                            numbers[i] = numbers[i] * 2;
                            numbers.Remove(numbers[i + 1]);
                            if (i > 0)
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
