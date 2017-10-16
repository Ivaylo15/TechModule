using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = 0;
            int bestCounter = 0;
            int symbol = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (bestCounter < counter)
                {
                    bestCounter = counter;
                    symbol = numbers[i];
                }
                counter = 0;
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write($"{symbol} ");
            }
            Console.WriteLine();
        }
    }
}
