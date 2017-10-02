using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double dif = Math.Abs(a - b);

            bool diff = dif <= 0.000001;

            Console.WriteLine(diff);
        }
    }
}
