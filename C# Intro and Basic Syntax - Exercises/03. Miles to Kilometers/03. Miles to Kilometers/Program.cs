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
            double m = double.Parse(Console.ReadLine());

            double km = m * 1.60934;

            Console.WriteLine($"{km:f2}");
        }
    }
}
