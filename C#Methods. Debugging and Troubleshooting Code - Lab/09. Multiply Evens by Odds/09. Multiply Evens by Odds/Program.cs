using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            ResulForEvenAndOdd(number);
            Console.WriteLine(ResulForEvenAndOdd(number));
        }

        static int ResulForEvenAndOdd(int number)
        {
            int even = ResultForEven(number);
            int odd = ResultForOdds(number);
            return even * odd;
        }
        static int ResultForOdds(int number)
        {
            int odd = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    odd += lastDigit;
                }
                number /= 10;
            }
            return odd;
        }
        static int ResultForEven(int number)
        {
            int even = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    even += lastDigit;
                }
                number /= 10;
            }
            return even;
        }
    }
}
