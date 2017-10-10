using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] > arr2[i] || arr1.Length > arr2.Length)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    break;
                }
                else if (arr1[i] < arr2[i] || arr1.Length < arr2.Length)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
