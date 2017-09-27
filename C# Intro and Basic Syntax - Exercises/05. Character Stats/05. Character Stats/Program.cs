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
            string name = Console.ReadLine();
            int curH = int.Parse(Console.ReadLine());
            int maxH = int.Parse(Console.ReadLine());
            int curE = int.Parse(Console.ReadLine());
            int maxE = int.Parse(Console.ReadLine());

            string maxxH = new string('.', maxH - curH);
            string currH = new string('|', curH);
            string maxxE = new string('.', maxE - curE);
            string currE = new string('|', curE);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currH}{maxxH}|");
            Console.WriteLine($"Energy: |{currE}{maxxE}|");
        }
    }
}
