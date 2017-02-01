using System;

namespace _14.ASCII_String
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string answer = "";

            for (int counter = 1; counter <= number; counter++)
            {
                int ASCII = int.Parse(Console.ReadLine());
                char letter = Convert.ToChar(ASCII);
                answer = answer + letter;
            }
            Console.WriteLine(answer);
        }
    }
}
