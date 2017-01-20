using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main()
        {
            string Boolean = Console.ReadLine();
            bool a = Convert.ToBoolean(Boolean);
            if (a == true)
            {
                Console.WriteLine("Yes");
            }
            else if (a == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
