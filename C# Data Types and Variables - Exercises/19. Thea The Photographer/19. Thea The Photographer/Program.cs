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
            long amountOfPictures = long.Parse(Console.ReadLine());
            long timeToFilter = long.Parse(Console.ReadLine());
            long amountOfGoodPictures = long.Parse(Console.ReadLine());
            long timeForUpload = long.Parse(Console.ReadLine());

            long totalPictures = (long)Math.Ceiling((double)amountOfPictures * amountOfGoodPictures / 100);
            long totalFilterTIme = amountOfPictures * timeToFilter;
            long totalUploadTime = totalPictures * timeForUpload;
            long totalTime = totalUploadTime + totalFilterTIme;
            
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(result);
        }
    }
}
