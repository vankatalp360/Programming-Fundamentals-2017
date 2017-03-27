using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQotient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
}
