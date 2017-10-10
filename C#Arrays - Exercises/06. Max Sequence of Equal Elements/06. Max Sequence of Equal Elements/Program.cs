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

            int start = arr[0];
            int lenght = 0;
            int bestLenght = 0;
            int bestStart = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (start == arr[i])
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
                    start = arr[i];
                    lenght = 1;
                }
            }
            if (bestLenght != 0)
            {
                int[] result = new int[bestLenght];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = bestStart;
                }
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
            else
            {
                int[] result = new int[lenght];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = start;
                }
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
