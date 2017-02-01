using System;

namespace _01.Hello__Name_
{
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string answer = Hello(name);
            Console.WriteLine(answer);
        }

        public static string Hello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
