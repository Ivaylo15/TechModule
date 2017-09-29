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
            int max = int.Parse(Console.ReadLine());

            int count = 0;
            int comb = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    count += 3 * (i * j);
                    comb++;
                    if (count >= max)
                    {
                        break;
                    }
                }

                if (count >= max)
                {
                    break;
                }
            }
            Console.WriteLine($"{comb} combinations");
            if (count >= max)
            {
                Console.WriteLine($"Sum: {count} >= {max}");
            }
            else
            {
                Console.WriteLine($"Sum: {count}");
            }
        }
    }
}
