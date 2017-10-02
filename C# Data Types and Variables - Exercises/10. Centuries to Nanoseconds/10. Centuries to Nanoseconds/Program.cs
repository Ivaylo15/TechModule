using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            decimal milSeconds = seconds * 1000M;
            decimal micSeconds = milSeconds * 1000;
            decimal nanoSeconds = micSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milSeconds} milliseconds = {micSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
