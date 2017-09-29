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
            int c = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    c++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(c);
        }
    }
}
