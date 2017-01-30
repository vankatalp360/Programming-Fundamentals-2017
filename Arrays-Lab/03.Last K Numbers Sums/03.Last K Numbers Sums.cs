using System;

namespace _03.Last_K_Numbers_Sums
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var sequence = new long[n];
            sequence[0] = 1;

            for (int i = 1; i < sequence.Length; i++)
            {
                long sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += sequence[prev];
                sequence[i] = sum;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
