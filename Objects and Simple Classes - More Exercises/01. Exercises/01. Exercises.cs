using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var listExercises = new List<Exercise>();

            while (line != "go go go")
            {
                var token = line.Split(new[] { ' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
                var topic = token[0];
                var courseName = token[1];
                var judgeContestLink = token[2];
                var problems = new List<string>();

                for (int i = 3; i < token.Length; i++)
                {
                    problems.Add(token[i]);
                }

                var exercise = new Exercise
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = problems
                };

                listExercises.Add(exercise);

                line = Console.ReadLine();
            }

            foreach (var exercise in listExercises)
            {
                var count = 1;
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }
}
