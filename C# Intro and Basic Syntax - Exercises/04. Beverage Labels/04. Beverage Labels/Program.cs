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
            string brand = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double vol = volume / 100;

            double kcal = energy * vol;
            double g = sugar * vol;

            Console.WriteLine($"{volume}ml {brand}:");
            Console.WriteLine($"{kcal}kcal, {g}g sugars");
        }
    }
}
