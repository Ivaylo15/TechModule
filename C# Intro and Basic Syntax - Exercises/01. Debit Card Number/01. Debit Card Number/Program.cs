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
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            if (one < 10)
            {
                Console.Write($"000{one} ");
            }
            else if (one < 100)
            {
                Console.Write($"00{one} ");
            }
            else if (one < 1000)
            {
                Console.Write($"0{one} ");
            }
            else
            {
                Console.Write($"{one} ");
            }
            if (two < 10)
            {
                Console.Write($"000{two} ");
            }
            else if (two < 100)
            {
                Console.Write($"00{two} ");
            }
            else if (two < 1000)
            {
                Console.Write($"0{two} ");
            }
            else
            {
                Console.Write($"{two} ");
            }
            if (three < 10)
            {
                Console.Write($"000{three} ");
            }
            else if (three < 100)
            {
                Console.Write($"00{three} ");
            }
            else if (three < 1000)
            {
                Console.Write($"0{three} ");
            }
            else
            {
                Console.Write($"{three} ");
            }
            if (four < 10)
            {
                Console.Write($"000{four}");
            }
            else if (four < 100)
            {
                Console.Write($"00{four}");
            }
            else if (four < 1000)
            {
                Console.Write($"0{four}");
            }
            else
            {
                Console.Write($"{four}");
            }
        }
    }
}
