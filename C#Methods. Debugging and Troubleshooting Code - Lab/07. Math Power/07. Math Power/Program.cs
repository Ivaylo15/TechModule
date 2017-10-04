using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RaiseToPower(num, power));
        }

        static double RaiseToPower(double num, int power)
        {
            double powerdNumber = 1;
            for (int i = 1; i <= power; i++)
            {
                powerdNumber = powerdNumber * num;
            }
            return powerdNumber;
        }
    }
}
