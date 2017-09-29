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
            int dmgP = int.Parse(Console.ReadLine());
            int dmgG = int.Parse(Console.ReadLine());

            int healthP = 100;
            int healthG = 100;
            int rounds = 1;

            while (true)
            {

                if (rounds % 2 != 0)
                {
                    healthG -= dmgP;
                    if (healthG > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthG} health.");
                    }
                }
                else
                {
                    healthP -= dmgG;
                    if (healthP > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthP} health.");
                    }
                }
                if (healthG <= 0 || healthP <= 0)
                {
                    break;
                }
                if (rounds % 3 == 0)
                {
                    healthP += 10;
                    healthG += 10;
                }
                rounds++;
            }
            if (healthP <= 0)
            {
                Console.WriteLine($"Gosho won in {rounds}th round.");
            }
            else if (healthG <= 0)
            {
                Console.WriteLine($"Pesho won in {rounds}th round.");
            }
        }
    }
}
