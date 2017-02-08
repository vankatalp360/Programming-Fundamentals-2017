using System;

namespace _01.Debugging_Exercise_Tricky_Strings
{
    public class Program
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            var currentString = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (i != numberOfStrings)
                {
                    result += currentString + delimiter;
                }
                else
                {
                    result += currentString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
