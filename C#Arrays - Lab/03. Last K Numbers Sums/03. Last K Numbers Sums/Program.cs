using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < seq.Length; i++)
            {
                long result = 0;
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        result += seq[j];
                    }
                }
                seq[i] = result;
            }
            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write($"{seq[i]} ");
            }
            Console.WriteLine();
        }
    }
}
