using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary: {0}", Convert.ToString(n, 2));
        }
    }
}
