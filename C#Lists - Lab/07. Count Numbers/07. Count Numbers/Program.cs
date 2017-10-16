using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            int count = 1;

            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i == numbers.Count)
                {
                    Console.WriteLine($"{numbers[i - 1]} -> 1");
                    break;
                }
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (i == numbers.Count - 1)
                    {
                        Console.WriteLine($"{numbers[i - 1]} -> {count}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{numbers[i - 1]} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
