using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Decode_Radio_Frequencies
{
    public class Program
    {
        public static void Main()
        {
            var frequencies = Console.ReadLine().Split(' ').ToList();
            var frequenc = new List<int>();
            var chars = new List<char>();
            var leftPart = 0;
            var rightPart = 0;

            for (int i = 0; i < frequencies.Count; i++)
            {
                frequenc = frequencies[i].Split('.').Select(int.Parse).ToList();
                leftPart = frequenc[0];
                rightPart = frequenc[1];
                frequenc.Clear();

                if (leftPart >= 32 && leftPart <= 126)
                {
                    chars.Insert(i, (char)leftPart);
                }

                if (rightPart >= 32 && rightPart <= 126)
                {
                    chars.Insert(i + 1, (char)rightPart);
                }

            }

            Console.WriteLine(string.Join("", chars));
        }
    }
}
