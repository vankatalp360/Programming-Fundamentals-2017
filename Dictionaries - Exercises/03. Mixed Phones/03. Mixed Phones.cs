using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Mixed_Phones
{
    public class Program
    {
        public static void Main()
        {
            var phoneInformation = new List<string>();
            var phone = new SortedDictionary<string, decimal>();
            var isCurect = false;

            do
            {
                phoneInformation.Clear();
                phoneInformation = Console.ReadLine().Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                if (phoneInformation[0] != "Over")
                {
                    foreach (var symbol in phoneInformation[1])
                    {
                        if (symbol < 48 || symbol > 57)
                        {
                            isCurect = false;
                            break;
                        }
                        isCurect = true;
                        break;
                    }

                    if (isCurect)
                    {
                        phone[phoneInformation[0]] = decimal.Parse(phoneInformation[1]);
                    }
                    else
                    {
                        phone[phoneInformation[1]] = decimal.Parse(phoneInformation[0]);
                    }
                }
            } while (phoneInformation[0] != "Over");

            foreach (var kvp in phone)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
