using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split('|').ToArray();
            List<int> results = new List<int>();

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                int[] newElements = elements[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                results.AddRange(newElements);
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
