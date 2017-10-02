using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexa =Console.ReadLine();

            int deci = Convert.ToInt32(hexa, 16);

            Console.WriteLine(deci);
        }
    }
}
