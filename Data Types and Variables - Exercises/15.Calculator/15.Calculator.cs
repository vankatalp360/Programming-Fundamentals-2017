using System;

namespace _15.Calculator
{
    public class Program
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            char operatr = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            var answer = 0;

            switch (operatr)
            {
                case '+': answer = first + second; break;
                case '-': answer = first - second; break;
                case '*': answer = first * second; break;
                case '/': answer = first / second; break;
            }
            Console.WriteLine($"{first} {operatr} {second} = {answer}");
        }
    }
}
