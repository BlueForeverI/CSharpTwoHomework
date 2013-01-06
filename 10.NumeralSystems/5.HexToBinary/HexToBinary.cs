using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.HexToBinary
{
    class HexToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hexadecimal number: ");
            string hex = Console.ReadLine();
            Console.WriteLine("Binary representation: {0}", Convert.ToString(Convert.ToInt32(hex, 16), 2));
        }
    }
}
