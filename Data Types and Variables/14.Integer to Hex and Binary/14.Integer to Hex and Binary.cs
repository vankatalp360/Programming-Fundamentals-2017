using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string hexadecial = Convert.ToString(number, 16);
            string binary = Convert.ToString(number, 2);
            string Upper = hexadecial.ToUpper();
            Console.WriteLine(Upper);
            Console.WriteLine(binary);
        }
    }
}
