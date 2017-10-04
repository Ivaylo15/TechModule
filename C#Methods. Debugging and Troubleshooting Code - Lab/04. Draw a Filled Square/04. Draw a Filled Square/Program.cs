using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFirstandLastRow(n);
            PrintMiddleRow(n);
            PrintFirstandLastRow(n);
        }

        static void PrintMiddleRow(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void PrintFirstandLastRow(int n)
        {
            string dashes = new string('-', n * 2);
            Console.WriteLine(dashes);
        }
    }
}
