using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers.Take(comands[0]);
            numbers.RemoveRange(0, comands[1]);

            bool number = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == comands[2])
                {
                    number = true;
                }
            }
            if (number)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
