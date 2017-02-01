using System;

namespace _12.Variable_in_Hexadecimal_Format
{
    public class Program
    {
        public static void Main()
        {
            string hexadecimal = Console.ReadLine();
            var number = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(number);
        }
    }
}
