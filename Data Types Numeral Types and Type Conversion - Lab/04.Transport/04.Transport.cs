using System;

namespace _04.Transport
{
    public class Program
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int transport = (int)Math.Ceiling((double)persons / 24);
            Console.WriteLine(transport);
        }
    }
}
