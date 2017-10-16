using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = 
                Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input = input.Where(num => num.Length < 5).OrderBy(num => num).Distinct().ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
