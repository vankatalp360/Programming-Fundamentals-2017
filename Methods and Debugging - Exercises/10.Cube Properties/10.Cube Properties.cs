using System;

namespace _10.Cube_Properties
{
    public class Program
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double answer = Calculate(side, parameter);
            answer = Math.Round(answer, 2);
            Console.WriteLine("{0:f2}", answer);
        }

        public static double Calculate(double side, string parameter)
        {
            double answer = 0;
            switch (parameter)
            {
                case "face": answer = Math.Sqrt(2 * side * side); break;
                case "space": answer = Math.Sqrt(3 * side * side); break;
                case "volume": answer = (side * side * side); break;
                case "area": answer = (6 * side * side); break;
            }
            return answer;
        }
    }
}
