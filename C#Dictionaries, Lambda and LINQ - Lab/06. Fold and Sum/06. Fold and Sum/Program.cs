using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(num => int.Parse(num))
                .ToArray();
            int k = numbers.Length / 4;
            int[] raw1left = numbers.Take(k).Reverse().ToArray();
            int[] raw1right = numbers.Reverse().Take(k).ToArray();
            int[] raw1 = raw1left.Concat(raw1right).ToArray();
            int[] raw2 = numbers.Skip(k).Take(k * 2).ToArray();
            int[] result = raw1.Select((x, index) => x + raw2[index]).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
