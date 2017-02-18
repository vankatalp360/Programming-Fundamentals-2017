using System;
using System.Linq;

namespace _03.Phonebook
{
    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string comand = "";

            while (comand != "done")
            {
                comand = Console.ReadLine();
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    if (names[i] == comand)
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
