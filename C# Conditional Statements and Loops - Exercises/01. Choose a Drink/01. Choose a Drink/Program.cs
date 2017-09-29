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

            if (pro == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (pro == "Businessman" || pro == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (pro == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
