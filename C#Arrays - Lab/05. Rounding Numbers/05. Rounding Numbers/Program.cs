using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                double num1 = Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num[i]} => {num1}");
            }
        }
    }
}
