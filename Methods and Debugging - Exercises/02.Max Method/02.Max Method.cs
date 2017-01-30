using System;

namespace _02.Max_Method
{
    public class Program
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int answer = GetMax(first, second, third);
            Console.WriteLine(answer);
        }

        public static int GetMax(int first, int second, int third)
        {
            int a = Math.Max(first, second);
            int answer = Math.Max(a, third);
            return answer;
        }
    }
}
