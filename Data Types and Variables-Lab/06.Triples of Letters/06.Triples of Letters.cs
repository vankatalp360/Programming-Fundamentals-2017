using System;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int first = 0; first < num; first++)
            {
                for (int second = 0; second < num; second++)
                {
                    for (int third = 0; third < num; third++)
                    {
                        char firstLetter = (char)('a' + first);
                        char secondLetter = (char)('a' + second);
                        char thirdLetter = (char)('a' + third);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
