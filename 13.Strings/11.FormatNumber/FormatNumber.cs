using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal: {0:d15}", num);
            Console.WriteLine("Hexadecimal: {0:x15}", num);
            Console.WriteLine("Percentage: {0:000000000000000%}", num);
            Console.WriteLine("Scientific: {0:e15}", num);
        }
    }
}
