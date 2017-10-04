using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangeBase = double.Parse(Console.ReadLine());
            double triangeHeight = double.Parse(Console.ReadLine());

            double area = TriangeArea(triangeBase, triangeHeight);
            Console.WriteLine(area);
        }

        static double TriangeArea(double triangeBase, double triangeHeight)
        {
            return triangeBase * triangeHeight / 2;
        }
    }
}
