using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split(' ').ToArray();

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                Console.Write($"{symbols[i]} ");
            }
            Console.WriteLine();
        }
    }
}
