using System;

namespace _10.Data_Overflow
{
    public class Program
    {
        public static void Main()
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            ulong biggerNumber = Math.Max(firstNumber, secondNumber);
            ulong smallerNumber = Math.Min(firstNumber, secondNumber);

            string bigType = "";
            string smallType = "";
            ulong smallNumType = 0;

            if (biggerNumber >= smallerNumber)
            {
                if (biggerNumber > byte.MinValue && biggerNumber <= byte.MaxValue)
                {
                    bigType = "byte";
                }
                else if (biggerNumber > ushort.MinValue && biggerNumber <= ushort.MaxValue)
                {
                    bigType = "ushort";
                }
                else if (biggerNumber > uint.MinValue && biggerNumber <= uint.MaxValue)
                {
                    bigType = "uint";
                }
                else if (biggerNumber > ulong.MinValue && biggerNumber <= ulong.MaxValue)
                {
                    bigType = "ulong";
                }

                if (smallerNumber > byte.MinValue && smallerNumber <= byte.MaxValue)
                {
                    smallType = "byte";
                    smallNumType = byte.MaxValue;
                }
                else if (smallerNumber > ushort.MinValue && smallerNumber <= ushort.MaxValue)
                {
                    smallType = "ushort";
                    smallNumType = ushort.MaxValue;
                }
                else if (smallerNumber > uint.MinValue && smallerNumber <= uint.MaxValue)
                {
                    smallType = "uint";
                    smallNumType = uint.MaxValue;
                }
                else if (smallerNumber > ulong.MinValue && smallerNumber <= ulong.MaxValue)
                {
                    smallType = "ulong";
                    smallNumType = ulong.MaxValue;
                }

                Console.WriteLine($"bigger type: {bigType}");
                Console.WriteLine($"smaller type: {smallType}");
                Console.WriteLine($"{biggerNumber} can overflow {smallType} {Math.Round((double)biggerNumber / smallNumType)} times");
            }

        }
    }
}
