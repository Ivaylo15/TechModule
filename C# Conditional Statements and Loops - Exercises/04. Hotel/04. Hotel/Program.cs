using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double Studio = 0;
            double Double = 0;
            double Suite = 0;

            if (month == "May" || month == "October")
            {
                Studio += 50 * nights;
                Double += 65 * nights;
                Suite += 75 * nights;
                if (nights > 7)
                {
                    double dis = Studio * 5 / 100;
                    Studio = Studio - dis;
                }
                if (month == "October" && nights > 7)
                {
                    double dis = Studio / nights;
                    Studio = Studio - dis;
                }
            }
            else if (month == "June" || month == "September")
            {
                Studio += 60 * nights;
                Double += 72 * nights;
                Suite += 82 * nights;
                if (nights > 14)
                {
                    double dis = Double * 10 / 100;
                    Double = Double - dis;
                }
                if (month == "September" && nights > 7)
                {
                    double dis = Studio / nights;
                    Studio = Studio - dis;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                Studio += 68 * nights;
                Double += 77 * nights;
                Suite += 89 * nights;
                if (nights > 14)
                {
                    double dis = Suite * 15 / 100;
                    Suite = Suite - dis;
                }
            }
            Console.WriteLine($"Studio: {Studio:f2} lv.");
            Console.WriteLine($"Double: {Double:f2} lv.");
            Console.WriteLine($"Suite: {Suite:f2} lv.");
        }
    }
}
