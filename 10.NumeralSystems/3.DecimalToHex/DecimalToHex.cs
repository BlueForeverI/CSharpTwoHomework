using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hex representation: 0x{0}", Convert.ToString(n, 16));
        }
    }
}
