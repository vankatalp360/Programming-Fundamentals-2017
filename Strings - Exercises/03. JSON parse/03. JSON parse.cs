using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.JSON_parse
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var chars = new char[] { '[', ']', '{', '}', ':', '"',  ',', ' '};

            var jsonCollection = line
                .Split(chars,StringSplitOptions.RemoveEmptyEntries).ToList();
            var allStudents = parseStudents(jsonCollection);
            foreach (var student in allStudents)
            {
                if (student.Grades.Count == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
            }
        }

        private static List<Student> parseStudents(List<string> jsonCollection)
        {
            var students = new List<Student>();
            var isName = false;
            var isAge = false;
            var isGrades = false;
            var name = string.Empty;
            var age = 0;
            var grades = new List<int>();
            var counter = 0;

            foreach (var word in jsonCollection)
            {
                counter++;
                if (isName)
                {
                    name = word;
                    isName = false;
                }
                else if (isAge)
                {
                    age = int.Parse(word);
                    isAge = false;
                }
                if (word == "name")
                {
                    isName = true;
                    isGrades = false;
                    if (counter != 1)
                    {
                        students.Add(new Student { Name = name, Age = age, Grades = grades });
                        grades = new List<int>();
                    }
                }
                if (isGrades)
                {
                    grades.Add(int.Parse(word));
                }

                if (word == "age")
                {
                    isAge = true;
                }
                else if (word == "grades")
                {
                    isGrades = true;
                }

                if (counter == jsonCollection.Count)
                {
                    students.Add(new Student { Name = name, Age = age, Grades = grades });
                    grades = new List<int>();
                }
            }


            return students;
        }
    }
}
