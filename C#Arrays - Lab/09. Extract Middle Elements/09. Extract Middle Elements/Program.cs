using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n.Length == 1)
            {
                Console.WriteLine(n[0]);
            }
            else if (n.Length % 2 == 0)
            {
                for (int i = n.Length / 2 - 1; i <= n.Length / 2; i++)
                {
                    if (i == n.Length / 2 - 1)
                    {
                        Console.Write($"{{{n[i]}, {n[i + 1]}}}");
                        break;
                    }
                }
                Console.WriteLine();
            }
            else if (n.Length % 2 != 0)
            {
                for (int i = n.Length / 2 - 1; i <= n.Length / 2 + 1; i++)
                {
                    if (i == n.Length / 2 - 1)
                    {
                        Console.Write($"{{{n[i]}, {n[i+1]}, {n[i+2]}}}");
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
