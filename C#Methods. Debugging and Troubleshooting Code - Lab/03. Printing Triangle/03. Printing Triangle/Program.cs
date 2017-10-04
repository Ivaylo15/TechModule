using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintTriangle(1, i);
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                PrintTriangle(1, i);
                Console.WriteLine();
            }
        }

        static void PrintTriangle(int start , int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
