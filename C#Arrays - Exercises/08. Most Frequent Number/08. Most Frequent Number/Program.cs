using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long mostUsedNumber = 0;
            long numberCounter = 0;
            long bestCounter = 0;
            long currentSymbol = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        numberCounter++;
                    }
                    if (bestCounter < numberCounter)
                    {
                        bestCounter = numberCounter;
                        mostUsedNumber = arr[i];
                    }
                }
                numberCounter = 0;
            }
            Console.WriteLine(mostUsedNumber);
        }
    }
}
