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
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int n1 = 0;
            int m1 = 0;
            int c = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        n1 = i;
                        m1 = j;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
            if (n1 == 0)
            {
                Console.WriteLine($"{c} combinations - neither equals {magic}");
            }
            else
            {
                Console.WriteLine($"Number found! {n1} + {m1} = {magic}");
            }
        }
    }
}
