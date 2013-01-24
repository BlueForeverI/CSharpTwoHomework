using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            Console.WriteLine("Reversed: {0}", new string(Console.ReadLine().Reverse().ToArray()));
        }
    }
}
