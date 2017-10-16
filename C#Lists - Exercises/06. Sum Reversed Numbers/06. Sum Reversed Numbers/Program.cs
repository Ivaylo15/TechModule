using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> reversed = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                Reversed(numbers[i]);
                reversed.Add(Reversed(numbers[i]));
            }
            int sum = 0;
            for (int i = 0; i < reversed.Count; i++)
            {
                sum += reversed[i];
            }
            Console.WriteLine(sum);
        }

        private static int Reversed(int v)
        {
            int result = 0;
            while (v > 0)
            {
                result = result * 10 + v % 10;
                v /= 10;
            }
            return result;
        }
    }
}
