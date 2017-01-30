using System;

namespace _06.Increment_Variable
{
    public class Program
    {
        public static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            byte number = (byte)n;
            Console.WriteLine(number);

            if (n > 255)
            {
                long overflow = n / 256;
                Console.WriteLine($"Overflowed {overflow} times");
            }
        }
    }
}
