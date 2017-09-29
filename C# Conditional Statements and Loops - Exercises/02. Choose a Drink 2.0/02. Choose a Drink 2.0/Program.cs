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
            string pro = Console.ReadLine();
            int cu = int.Parse(Console.ReadLine());

            if (pro == "Athlete")
            {
                double pri = cu * 0.70;
                Console.WriteLine($"The Athlete has to pay {pri:f2}.");
            }
            else if (pro == "Businessman" || pro == "Businesswoman")
            {
                double pri = cu * 1.00;
                if (pro == "Businessman")
                {
                    Console.WriteLine($"The Businessman has to pay {pri:f2}.");
                }
                else if (pro == "Businesswoman")
                {
                    Console.WriteLine($"The Businesswoman has to pay {pri:f2}.");
                }
            }
            else if (pro == "SoftUni Student")
            {
                double pri = cu * 1.70;
                Console.WriteLine($"The SoftUni Student has to pay {pri:f2}.");
            }
            else
            {
                double pri = cu * 1.20;
                Console.WriteLine($"The {pro} has to pay {pri:f2}.");
            }
        }
    }
}
