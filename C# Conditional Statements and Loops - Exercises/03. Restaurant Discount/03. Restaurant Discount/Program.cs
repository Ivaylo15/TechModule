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
            int grp = int.Parse(Console.ReadLine());
            string pac = Console.ReadLine();

            double sum = 0;

            if (grp <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                sum += 2500;
                if (pac == "Normal")
                {
                    sum += 500;
                    double dis = sum * 5 / 100;
                    sum = sum - dis;
                }
                else if (pac == "Gold")
                {
                    sum += 750;
                    double dis = sum * 0.1;
                    sum = sum - dis;
                }
                else if (pac == "Platinum")
                {
                    sum += 1000;
                    double dis = sum * 15 / 100;
                    sum = sum - dis;
                }
            }
            else if (grp <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                sum += 5000;
                if (pac == "Normal")
                {
                    sum = sum + 500;
                    double dis = sum * 0.05;
                    sum = sum - dis;
                }
                else if (pac == "Gold")
                {
                    sum += 750;
                    double dis = sum * 0.1;
                    sum = sum - dis;
                }
                else if (pac == "Platinum")
                {
                    sum += 1000;
                    double dis = sum * 15 / 100;
                    sum = sum - dis;
                }
            }
            else if (grp <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                sum += 7500;
                if (pac == "Normal")
                {
                    sum = sum + 500;
                    double dis = sum * 0.05;
                    sum = sum - dis;
                }
                else if (pac == "Gold")
                {
                    sum += 750;
                    double dis = sum * 0.1;
                    sum = sum - dis;

                }
                else if (pac == "Platinum")
                {
                    sum += 1000;
                    double dis = sum * 15 / 100;
                    sum = sum - dis;
                }
            }
            else if (grp > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (sum != 0)
            {
                double priP = sum / grp;
                Console.WriteLine($"The price per person is {priP:f2}$");
            }
        }
    }
}
