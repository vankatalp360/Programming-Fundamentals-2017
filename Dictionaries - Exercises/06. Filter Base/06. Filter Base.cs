using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Filter_Base
{
    public class Program
    {
        public static void Main()
        {
            var ageCase = new Dictionary<string, int>();
            var salaryCase = new Dictionary<string, double>();
            var positionCase = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "filter base")
            {
                var token = line.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                int age;
                var username = token[0];
                var position = token[1];
                double salary;
                var isInt = int.TryParse(token[1], out age);
                var isDouble = double.TryParse(token[1], out salary);
                
                if (isInt)
                {
                    ageCase[username] = age;
                }
                else if (isDouble)
                {
                    salaryCase[username] = Math.Round(salary, 2);
                }
                else
                {
                    positionCase[username] = position;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            if (line == "Age")
            {
                foreach (var kvp in ageCase)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (line == "Salary")
            {
                foreach (var kvp in salaryCase)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:F2}");
                    Console.WriteLine("====================");
                }
            }
            else if (line == "Position")
            {
                foreach (var kvp in positionCase)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
