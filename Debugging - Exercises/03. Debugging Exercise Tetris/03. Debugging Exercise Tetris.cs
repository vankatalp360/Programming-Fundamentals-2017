using System;

namespace _03.Debugging_Exercise_Tetris
{
    public class Program
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        Up(n);
                        break;
                    case "right":
                        Right(n);
                        break;
                    case "down":
                        Down(n);
                        break;
                    case "left":
                        Left(n);
                        break;
                }
                currentDirection = Console.ReadLine();
            }
        }

        static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }
        }

        static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }
        }

        static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', 3 * n)
                        );
            }
        }

        static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', 3 * n)
                        );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }
        }
    }
}
