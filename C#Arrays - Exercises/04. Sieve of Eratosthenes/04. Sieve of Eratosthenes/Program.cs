using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] check = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                check[i] = true;
            }
            check[0] = false;
            check[1] = false;

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] == true)
                {
                    for (int j = 2; (j* i) <= n; j++)
                    {
                        check[j * i] = false;
                    }
                }
            }

            for (int j = 2; j <= n; j++)
            {
                if (check[j] == true)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
