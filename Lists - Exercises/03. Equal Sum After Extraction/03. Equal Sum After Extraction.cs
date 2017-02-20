using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Equal_Sum_After_Extraction
{
    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list1Sum = 0;
            var list2Sum = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int k = 0; k < secondList.Count; k++)
                {
                    if (firstList[i] == secondList[k])
                    {
                        secondList.Remove(firstList[i]);
                    }
                }
            }

            foreach (var number in firstList)
            {
                list1Sum += number;
            }
            foreach (var number in secondList)
            {
                list2Sum += number;
            }

            if (list1Sum == list2Sum)
            {
                Console.WriteLine($"Yes. Sum: {list1Sum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(list2Sum - list1Sum)}");
            }
        }
    }
}
