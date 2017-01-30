using System;

namespace _07.From_Terabytes_to_Bits
{
    public class Program
    {
        public static void Main()
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());
            decimal bits = terabytes * 8796093022208;
            Console.WriteLine("{0:F0}", bits);
        }
    }
}
