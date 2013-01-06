using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.AnyToAny
{
    class AnyToAny
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            Console.Write("Enter From base: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Enter To base: ");
            int d = int.Parse(Console.ReadLine());

            if(s < 2 || s > 16 || d < 2 || d > 16)
            {
                Console.WriteLine("The bases should be between 2 and 16");
                return;
            }

            Console.WriteLine("Converted from base {0} to base {1}: {2}", s, d,
                Convert.ToString(Convert.ToInt32(num, s), d));
        }
    }
}
