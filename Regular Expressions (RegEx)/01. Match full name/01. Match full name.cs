using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Match_full_name
{
    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(',').ToArray();
            Regex regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");
            var listOfNames = new List<string>();

            foreach (var name in names)
            {
                var isName = name.Trim();
                if (regex.IsMatch(isName))
                {
                    listOfNames.Add(isName);
                }
            }

            Console.WriteLine(string.Join("\r\n", listOfNames));
        }
    }
}
