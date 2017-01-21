using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(totalPrictures * (filterFactor / 100.0));
            double picturesTime = (double) totalPrictures * filterTime;
            double filterPicturesTime = (double) filteredPictures * uploadTime;
            double totaltime = (double) (picturesTime + filterPicturesTime);

            TimeSpan time = TimeSpan.FromSeconds(totaltime);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
