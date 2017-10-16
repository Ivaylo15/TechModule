using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> bombNumber = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int bomb = bombNumber[1];
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber[0])
                {
                    int left = Math.Max(i - bomb, 0);

                    int right = Math.Min(i + bomb, numbers.Count - 1);

                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
