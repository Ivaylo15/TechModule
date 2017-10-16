using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> comands = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                if (comands[0] == "Odd" || comands[0] == "Even")
                {
                    if (comands[0] == "Odd")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                    }
                    else if (comands[0] == "Even")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                    }
                    break;
                }
                if (comands[0] == "Delete")
                {
                    int remove = int.Parse(comands[1]);
                    numbers.RemoveAll(x => x == remove);
                }
                else if (comands[0] == "Insert")
                {
                    int element = int.Parse(comands[1]);
                    int position = int.Parse(comands[2]);
                    numbers.Insert(position, element);
                }
                comands = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
