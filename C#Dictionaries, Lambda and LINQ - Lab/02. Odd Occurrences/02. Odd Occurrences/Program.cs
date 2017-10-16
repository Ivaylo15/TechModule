using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
            var result = new Dictionary<string, int>();
            List<string> final = new List<string>();

            foreach (var item in input)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }

            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    final.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", final));
        }
    }
}
