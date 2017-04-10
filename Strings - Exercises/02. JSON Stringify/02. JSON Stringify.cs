using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSON_Stringify
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var students = new List<Student>();

            while (line != "stringify")
            {
                var token = line.Split(new[] { ' ', '-', '>', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = token[0];
                var age = int.Parse(token[1]);
                var grades = new List<int>();

                for (int i = 2; i < token.Length; i++)
                {
                    grades.Add(int.Parse(token[i]));
                }

                var student = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };
                students.Add(student);


                line = Console.ReadLine();
            }
            var counter = 0;

            Console.Write("[");

            foreach (var name in students)
            {
                counter++;
                Console.Write("{" + "name:" + "\"" + $"{name.Name}" + "\"" + $",age:{name.Age},grades:[{string.Join(", ", name.Grades)}]" + "}");
                if (counter != students.Count)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
