using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(' ');
                var command = token[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(token[1]);

                        array = Exchange(array, index);
                        break;
                    case "max":
                    case "min":
                        var maxOrMin = command;
                        var evenOrOdd = token[1];
                        if (maxOrMin == "max")
                        {
                            MaxEvenOdd(array, evenOrOdd);
                        }
                        else if (maxOrMin == "min")
                        {
                            MinEvenOdd(array, evenOrOdd);
                        }
                        break;
                    case "first":
                    case "last":
                        FirstLastEvenOdd(array, command, token[2], int.Parse(token[1]));

                        break;
                }


                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");

        }

        public static List<int> Exchange(List<int> array, int index)
        {
            var isValidIndex = index >= 0 && index < array.Count();
            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var secondPart = array.Skip(index + 1).ToList();
            var firstPart = array.Take(index + 1).ToList();
            secondPart.AddRange(firstPart);

            return secondPart;
        }

        public static void MaxEvenOdd (List<int> array, string evenOrOdd)
        {
            var index = 0;
            if (evenOrOdd == "even")
            {
                var evenOrOddElements = array.Where(x => (x % 2) == 0);
                if (evenOrOddElements.Any())
                {
                    var number = array.Where(x => (x % 2) == 0).Max();
                    index = array.FindLastIndex(x => x == number);
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (evenOrOdd == "odd")
            {
                var evenOrOddElements = array.Where(x => (x % 2) == 1);
                if (evenOrOddElements.Any())
                {
                    var number = array.Where(x => (x % 2) == 1).Max();
                    index = array.FindLastIndex(x => x == number);
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
        }

        public static void MinEvenOdd(List<int> array, string evenOrOdd)
        {
            var index = 0;
            if (evenOrOdd == "even")
            {
                var evenOrOddElements = array.Where(x => (x % 2) == 0);
                if (evenOrOddElements.Any())
                {
                    var number = array.Where(x => (x % 2) == 0).Min();
                    index = array.FindLastIndex(x => x == number);
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (evenOrOdd == "odd")
            {
                var evenOrOddElements = array.Where(x => (x % 2) == 1);
                if (evenOrOddElements.Any())
                {
                    var number = array.Where(x => (x % 2) == 1).Min();
                    index = array.FindLastIndex(x => x == number);
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
        }

        public static void FirstLastEvenOdd (List<int> array, string firstOrLast, string evenOrOdd, int count)
        {
            var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(x => (x % 2) == evenOrOddParity);
            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("[]");
                return;
            }
            else
            {
                if (firstOrLast == "first")
                {
                    Console.WriteLine($"[{string.Join(", ", evenOrOddElements.Take(count))}]");
                }
                else if (firstOrLast == "last")
                {
                    Console.WriteLine($"[{string.Join(", ", evenOrOddElements.Reverse().Take(count).Reverse())}]");
                }
            }

        }
    }
}
