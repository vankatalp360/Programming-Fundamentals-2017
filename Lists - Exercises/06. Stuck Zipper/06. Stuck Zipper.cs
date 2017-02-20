using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Stuck_Zipper
{
    public class Program
    {
        public static void Main()
        {
            var firstNumbersLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondNumbersLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var smallestNumber = int.MaxValue;
            var minNumber = 0;
            var digits = 0;
            var digitsCounter = 0;
            var answer = new List<int>();

            for (int i = 0; i < firstNumbersLine.Count; i++)
            {
                for (int k = 0; k < secondNumbersLine.Count; k++)
                {
                    minNumber = Math.Min(Math.Abs(firstNumbersLine[i]), Math.Abs(secondNumbersLine[k]));
                    if (minNumber < smallestNumber)
                    {
                        smallestNumber = minNumber;
                    }
                }
            }

            foreach (var symbol in smallestNumber.ToString())
            {
                digits++;
            }

            for (int i = 0; i < firstNumbersLine.Count; i++)
            {
                foreach (var item in firstNumbersLine[i].ToString())
                {
                    if (item < 48 || item > 57)
                    {

                    }
                    else
                    {
                        digitsCounter++;
                    }
                }

                if (digitsCounter > digits)
                {
                    firstNumbersLine.Remove(firstNumbersLine[i]);
                    i--;
                }
                digitsCounter = 0;
            }

            for (int i = 0; i < secondNumbersLine.Count; i++)
            {
                foreach (var item in secondNumbersLine[i].ToString())
                {
                    if (item < 48 || item > 57)
                    {

                    }
                    else
                    {
                        digitsCounter++;
                    }
                }

                if (digitsCounter > digits)
                {
                    secondNumbersLine.Remove(secondNumbersLine[i]);
                    i--;
                }
                digitsCounter = 0;
            }

            var plus = 1;
            for (int i = 0; i < firstNumbersLine.Count; i++)
            {
                secondNumbersLine.Insert(Math.Min(plus,secondNumbersLine.Count), firstNumbersLine[i]);
                plus +=2;
            }

            Console.WriteLine(string.Join(" ", secondNumbersLine));
        }
    }
}
