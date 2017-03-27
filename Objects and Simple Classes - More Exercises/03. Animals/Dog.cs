using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        
        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
}
