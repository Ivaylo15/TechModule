﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sqrNumbers = new List<int>();



            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    sqrNumbers.Add(numbers[i]);
                }
            }
            sqrNumbers.Sort();
            sqrNumbers.Reverse();

            Console.WriteLine(string.Join(" ", sqrNumbers));
        }
    }
}
