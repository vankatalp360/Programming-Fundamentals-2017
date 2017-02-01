using System;

namespace _16.Tricky_Strings
{
    public class Program
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string answer = "";

            for (int counter = 1; counter <= number; counter++)
            {
                string text = Console.ReadLine();
                if (counter == number)
                {
                    answer = answer + text;
                }
                else
                {

                    answer = answer + text + delimiter;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
