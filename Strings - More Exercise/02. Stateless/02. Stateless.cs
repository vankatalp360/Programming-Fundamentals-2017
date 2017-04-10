using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Stateless
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var fiction = Console.ReadLine();


            while (line != "collapse")
            {
                var changeFiction = fiction;
                var lenght = 0;
                if (fiction.Length % 2 == 0)
                {
                    lenght = fiction.Length / 2;
                }
                else
                {
                    lenght = fiction.Length / 2 + 1;
                }
                for (int i = 0; i < lenght; i++)
                {
                    line = line.Replace(changeFiction, "");
                    if (changeFiction.Length > 1)
                    {
                        changeFiction = changeFiction.Remove(0, 1);
                        changeFiction = changeFiction.Remove(changeFiction.Length - 1, 1);
                    }
                }
                var words = line.Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                if (line.Length > 0)
                {
                    Console.WriteLine(string.Join(" ", words));
                }
                else
                {
                    Console.WriteLine("(void)");
                }
                line = Console.ReadLine();
                if (line != "collapse")
                {
                    fiction = Console.ReadLine();
                }
            }

        }
    }
}
