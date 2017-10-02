using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = sbyte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            short sh = short.Parse(Console.ReadLine());
            ushort uSh = ushort.Parse(Console.ReadLine());
            uint uInt = uint.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            long lo = long.Parse(Console.ReadLine());

            Console.WriteLine(sb);
            Console.WriteLine(b);
            Console.WriteLine(sh);
            Console.WriteLine(uSh);
            Console.WriteLine(uInt);
            Console.WriteLine(i);
            Console.WriteLine(lo);
        }
    }
}
