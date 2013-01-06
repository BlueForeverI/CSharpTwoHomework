using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number: ");
            string hex = Console.ReadLine();
            Console.WriteLine("Decimal representation: {0}", Convert.ToInt32(hex, 16));
        }
    }
}
