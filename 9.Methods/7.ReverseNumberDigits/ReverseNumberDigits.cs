using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.ReverseNumberDigits
{
    class ReverseNumberDigits
    {
        static string ReverseDigits(int n)
        {
            return new string(n.ToString().Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Reversed digits: {0}", ReverseDigits(number));
        }
    }
}
