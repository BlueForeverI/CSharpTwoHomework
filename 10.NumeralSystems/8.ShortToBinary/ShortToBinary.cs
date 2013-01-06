using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.ShortToBinary
{
    class ShortToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 16-bit signed integer: ");
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine("Binary representatoin: {0}",
                Convert.ToString(n, 2));
        }
    }
}
