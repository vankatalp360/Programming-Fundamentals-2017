using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Command_Interpreter
{
    public class Program
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var positionOrTimesRegex = new Regex(@"-?[0-9]+");
            var startPosition = 0;
            var count = 0;
            var resultArray = new List<string>();

            while (true)
            {
                var commands = Console.ReadLine();
                var commandsParts = commands.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                var command = commandsParts[0];
                if (commands == "end")
                {
                    break;
                }
                var positionsOrTimes = positionOrTimesRegex.Matches(commands);
                if (positionsOrTimes.Count == 1)
                {
                    count = int.Parse(positionsOrTimes[0].ToString());
                }
                else if (positionsOrTimes.Count > 1)
                {
                    startPosition = int.Parse(positionsOrTimes[0].ToString());
                    count = int.Parse(positionsOrTimes[1].ToString());
                }

                switch (command)
                {
                    case "reverse":
                        if (IsValid(strings, startPosition, count))
                        {
                            Revers(strings, startPosition, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        if (IsValid(strings, startPosition, count))
                        {
                            Sort(strings, startPosition, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        if (count >= 0)
                        {
                            RollLeft(strings, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        if (count >= 0)
                        {
                            RollRight(strings, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", strings)}]");

        }

        private static bool IsValid(List<string> strings, int start, int count)
        {
            bool result = start >= 0 
                && start < strings.Count 
                && count >= 0 
                && (start + count) <= strings.Count;
            return result;
        }

        public static void Revers(List<string> strings, int start, int count)
        {
            strings.Reverse(start, count);
        }
        public static void Sort(List<string> strings, int start, int count)
        {
            strings.Sort(start, count, null);
        }
        public static void RollLeft(List<string> strings, int count)
        {
            count = count % strings.Count;
            for (int i = 0; i < count; i++)
            {
                var firstElement = strings[0];
                strings.Add(firstElement);
                strings.RemoveAt(0);
            }
        }
        public static void RollRight(List<string> strings, int count)
        {
            count = count % strings.Count;
            for (int i = 0; i < count; i++)
            {
                var lastElement = strings[strings.Count - 1];
                strings.Insert(0, lastElement);
                strings.RemoveAt(strings.Count - 1);
            }
        }
    }
}
