using System;

namespace _04.Refactor_Volume_of_Pyramid
{
    public class Program
    {
        public static void Main()
        {
            double Lenght, Width, Height = 0;
            Console.Write("Length: ");
            Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
            double volume = ((Lenght * Width * Height) / 3);
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
