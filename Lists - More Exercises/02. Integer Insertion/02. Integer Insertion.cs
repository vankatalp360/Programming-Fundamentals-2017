using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Integer_Insertion
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = "";
            int number = 0;

            while (comand != "end")
            {
                comand = Console.ReadLine();
                if (comand != "end")
                {
                    number = Math.Abs(int.Parse(comand));

                    foreach (var symbol in number.ToString())
                    {
                        var digit = symbol - '0';
                        numbers.Insert(digit, number);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
