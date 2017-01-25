﻿using System;

namespace _07.Greater_of_Two_Values
{
    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var answer = GetMax(first, second);
                Console.WriteLine(answer);
            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                var answer = GetMax(first, second);
                Console.WriteLine(answer);
            }

            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                var answer = GetMax(first, second);
                Console.WriteLine(answer);
            }
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        public static char GetMax(char first, char second)
        {
            return (char)GetMax((int)first, (int)second);
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) < 0)
            {
                return second;
            }

            else
            {
                return first;
            }
        }
    }
}
