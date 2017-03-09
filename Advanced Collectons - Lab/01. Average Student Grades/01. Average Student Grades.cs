using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Average_Student_Grades
{
    public class Program
    {
        public static void Main()
        {
            var grades = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ');
                var name = token[0];
                var grade = double.Parse(token[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                var name = kvp.Key;
                var allGrades = kvp.Value;

                var averageGrades = kvp.Value.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {averageGrades:f2})");
            }
        }
    }
}
