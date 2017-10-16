using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string inputComands = Console.ReadLine();

            while (inputComands != "print")
            {
                var comands = inputComands
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (comands[0] == "add")
                {
                    numbers.Insert(int.Parse(comands[1]), int.Parse(comands[2]));
                }
                else if (comands[0] == "addMany")
                {
                    int index = int.Parse(comands[1]);
                    numbers.InsertRange(index, comands.Skip(2).Select(int.Parse).ToList());
                }
                else if(comands[0] == "contains")
                {
                    int contain = int.Parse(comands[1]);
                    Console.WriteLine(numbers.IndexOf(contain));
                }
                else if (comands[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(comands[1]));
                }
                else if (comands[0] == "shift")
                {
                    int shift = int.Parse(comands[1]);
                    shift = shift % numbers.Count;
                    for (int i = 0; i < shift; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (comands[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                inputComands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
