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
            int c = 0;
            for (int i = 0; i <= 20; i++)
            {
                string ing = Console.ReadLine();
                if (ing == "Bake!")
                {
                    if (c != 0)
                    {
                        Console.WriteLine($"Preparing cake with {c} ingredients.");
                    }
                    break;
                }
                Console.WriteLine($"Adding ingredient {ing}.");
                c++;
            }
        }
    }
}
