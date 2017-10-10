using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] left = numbers.Take(k).ToArray();
            int[] middle = numbers.Skip(k).Take(k * 2).ToArray();
            int[] right = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(left);
            Array.Reverse(right);
            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = left[i] + middle[i];
                result[i + k] = middle[i + k] + right[i];
            }

            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
