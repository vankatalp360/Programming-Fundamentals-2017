using System;
using System.Linq;

namespace _04.Phone
{
    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            bool stop = false;
            int number = 0;
            int sum = 0;
            int difference = 0;

            while (stop != true)
            {
                string[] comand = Console.ReadLine().Split(' ');
                if (comand[0] == "done")
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (comand[1] == names[i] && comand[0] == "call" || comand[1] == phoneNumbers[i] && comand[0] == "call")
                        {
                            foreach (var symbol in phoneNumbers[i])
                            {
                                if (symbol >= 48 && symbol <= 57)
                                {
                                    var digit = symbol - '0';
                                    number = digit;
                                    sum += number;
                                }
                            }
                            if (comand[1] == names[i])
                            {
                                Console.WriteLine($"calling {phoneNumbers[i]}...");
                            }
                            else
                            {
                                Console.WriteLine($"calling {names[i]}...");
                            }
                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            if (sum % 2 == 0)
                            {
                                TimeSpan time = TimeSpan.FromSeconds(sum);
                                string duration = time.ToString(@"mm\:ss");

                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                            sum = 0;
                        }
                        else if (comand[1] == names[i] && comand[0] == "message" || comand[1] == phoneNumbers[i] && comand[0] == "message")
                        {
                            foreach (var symbol in phoneNumbers[i])
                            {
                                if (symbol >= 48 && symbol <= 57)
                                {
                                    var digit = symbol - '0';
                                    number = digit;
                                    sum += number;
                                }
                            }
                            difference = sum;
                            if (comand[1] == names[i])
                            {
                                Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            }
                            else
                            {
                                Console.WriteLine($"sending sms to {names[i]}...");
                            }
                            if (difference % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            if (difference % 2 == 0)
                            {
                                Console.WriteLine($"meet me there");
                                difference = 0;
                            }
                            sum = 0;
                        }
                    }
                }
            }
        }
    }
}
