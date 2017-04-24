using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    public class Program
    {
        public static void Main()
        {
            var fieldLenght = int.Parse(Console.ReadLine());
            var field = new int[fieldLenght];
            var ladybugsPositions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var command = Console.ReadLine();

            foreach (var position in ladybugsPositions)
            {
                if (position < field.Length && position >= 0)
                {
                    field[position] = 1;
                }
            }


            while (command != "end")
            {
                var token = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var previosPosition = int.Parse(token[0]);
                var direction = token[1];
                var nextPosition = int.Parse(token[2]);
                var position = 0;

                if (previosPosition < field.Length && previosPosition >= 0)
                {
                    if (field[previosPosition] == 1)
                    {
                        field[previosPosition] = 0;
                        if (direction == "right")
                        {
                            position = previosPosition + nextPosition;
                        }
                        else
                        {

                            position = previosPosition - nextPosition;
                        }
                        if (position < field.Length && position >= 0)
                        {
                            while (field[position] == 1)
                            {
                                if (direction == "right")
                                {
                                    position = position + nextPosition;
                                }
                                else
                                {

                                    position = position - nextPosition;
                                }
                                if (position >= field.Length && position >= 0)
                                {
                                    break;
                                }
                            }

                            if (position < field.Length && position >= 0)
                            {
                                field[position] = 1;
                            }
                        }
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
