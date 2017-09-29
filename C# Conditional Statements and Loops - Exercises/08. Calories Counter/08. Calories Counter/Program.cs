using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cal = 0;

            for (int i = 1; i <= n; i++)
            {
                string ing = Console.ReadLine();
                ing = ing.ToLower();

                if (ing == "cheese")
                {
                    cal += 500;
                }
                else if (ing == "tomato sauce")
                {
                    cal += 150;
                }
                else if (ing == "salami")
                {
                    cal += 600;
                }
                else if (ing == "pepper")
                {
                    cal += 50;
                }
                if (i == 20)
                {
                    break;
                }
            }
            Console.WriteLine($"Total calories: {cal}");
        }
    }
}
