using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("Decimal: {0}", Convert.ToInt32(binary, 2));
        }
    }
}
