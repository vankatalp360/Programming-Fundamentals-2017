using System;

namespace _04.Tripple_Sum
{
    public class Program
    {
        public static void Main()
        {
            string numbersText = Console.ReadLine();
            var splitText = numbersText.Split(' ');
            var numbers = new int[splitText.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentText = splitText[i];
                var currentNumber = int.Parse(currentText);
                numbers[i] = currentNumber;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0 && numbers[i + 1] > numbers[i] && numbers[i + 1] < numbers.Length)
                {
                    for (int sum = 0; sum < numbers.Length; sum++)
                    {
                        if (numbers[sum] == (numbers[i] + numbers[i + 1]))
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[i+1]} == {numbers[sum]}]");
                        }
                    }
                }
            }
        }
    }
}
