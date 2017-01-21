using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main()
        {
            char simbol;
            simbol = Convert.ToChar(Console.ReadLine());
            if (simbol == 'a' || simbol == 'e' || simbol == 'i' || simbol == 'o' || simbol == 'u' || simbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if ((simbol >= '0') && (simbol <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
