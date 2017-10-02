using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string hexa = num.ToString("X");
            Console.WriteLine(hexa);

            int bineri;
            string bi = string.Empty;
            while (num > 0)
            {
                bineri = num % 2;
                num /= 2;

                bi = bineri.ToString() + bi;
            }
            Console.WriteLine(bi);
        }
    }
}
