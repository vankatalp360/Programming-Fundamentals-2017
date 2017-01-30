using System;

namespace _01.Hello__Name_
{
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
