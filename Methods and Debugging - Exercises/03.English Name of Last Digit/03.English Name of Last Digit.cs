using System;

namespace _03.English_Name_of_Last_Digit
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string answer = GetLastNumber(number);
            Console.WriteLine(answer);
        }

        public static string GetLastNumber(long number)
        {
            long num = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                num = digit;
            }
            return EnglishName(num);
        }

        public static string EnglishName(long number)
        {
            string answer = "";
            switch (number)
            {
                case 1: answer = "one"; break;
                case 2: answer = "two"; break;
                case 3: answer = "three"; break;
                case 4: answer = "four"; break;
                case 5: answer = "five"; break;
                case 6: answer = "six"; break;
                case 7: answer = "seven"; break;
                case 8: answer = "eight"; break;
                case 9: answer = "ninе"; break;
                case 0: answer = "zero"; break;
            }
            return answer;
        }
    }
}
