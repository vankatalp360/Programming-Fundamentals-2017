using System;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int simbol = start; simbol <= end; simbol++)
            {
                char index = Convert.ToChar(simbol);
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }
    }
}
