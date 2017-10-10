using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char[] lettersAsArray = letters.ToArray(); 

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{lettersAsArray[i]} -> {(int)lettersAsArray[i] - 97}");
            }
        }
    }
}
