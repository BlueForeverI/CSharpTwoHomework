using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.BinaryToHex
{
    class BinaryToHex
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string bin = Console.ReadLine();
            Console.WriteLine("Hexadecimal representation: 0x{0}",
                Convert.ToString(Convert.ToInt32(bin, 2), 16));
        }
    }
}
