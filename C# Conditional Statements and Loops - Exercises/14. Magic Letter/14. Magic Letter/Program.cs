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
            char first = char.Parse(Console.ReadLine());
            char seconde = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            for (char i = first; i <= seconde; i++)
            {
                for (char j = first; j <= seconde; j++)
                {
                    for (char m = first; m <= seconde; m++)
                    {
                        if (i != third && j != third && m != third)
                        {
                            Console.Write($"{i}{j}{m} ");
                        }
                    }
                }
            }

        }
    }
}
