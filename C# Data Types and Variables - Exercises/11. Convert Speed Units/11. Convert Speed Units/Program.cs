using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float km = meters / 1000f;
            float milles = meters / 1609f;

            float tottalTimeSec = seconds + (minutes * 60f) + ((hours * 60f) * 60f);
            float tottalTimeHours = (tottalTimeSec / 60f) / 60f;

            float metersPerSeconds = meters / tottalTimeSec;
            float kmPerHour = km / tottalTimeHours;
            float millsPerHour = milles / tottalTimeHours;


            Console.WriteLine($"{metersPerSeconds}");
            Console.WriteLine($"{kmPerHour}");
            Console.WriteLine($"{millsPerHour}");
        }
    }
}
