using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int iChecker = 0;
            int lenght = 1;
            int bestLenght = 1;
            int bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[iChecker])
                {
                    lenght++;
                    if (bestLenght < lenght)
                    {
                        bestLenght = lenght;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    lenght = 1;
                }
                iChecker = i;
            }
            for (int i = bestStart; i < bestLenght + bestStart; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
