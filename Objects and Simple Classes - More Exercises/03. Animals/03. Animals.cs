using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var Dogs = new Dictionary<string, Dog>();
            var Cats = new Dictionary<string, Cat>();
            var Snakes = new Dictionary<string, Snake>();


            while (line != "I'm your Huckleberry")
            {
                var token = line.Split(' ').ToArray();
                if (token.Length > 2)
                {
                    var animal = token[0];
                    var name = token[1];
                    var age = int.Parse(token[2]);
                    var parameter = int.Parse(token[3]);

                    if (animal == "Dog")
                    {
                        var currentDog = new Dog
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter
                        };
                        Dogs[name] = currentDog;
                    }
                    if (animal == "Cat")
                    {
                        var currentCat = new Cat
                        {
                            Name = name,
                            Age = age,
                            IntelligenceQotient = parameter
                        };
                        Cats[name] = currentCat;
                    }
                    if (animal == "Snake")
                    {
                        var currentSnake = new Snake
                        {
                            Name = name,
                            Age = age,
                            CrueltyCoefficient = parameter
                        };
                        Snakes[name] = currentSnake;
                    }
                }
                else
                {
                    var name = token[1];
                    if (Dogs.ContainsKey(name))
                    {
                        Dog.ProduceSound();
                    }
                    if (Cats.ContainsKey(name))
                    {
                        Cat.ProduceSound();
                    }
                    if (Snakes.ContainsKey(name))
                    {
                        Snake.ProduceSound();
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var dog in Dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in Cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQotient}");
            }
            foreach (var snake in Snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
