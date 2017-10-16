using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(num => double.Parse(num));

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(num => num).Take(3)));
        }
    }
}
