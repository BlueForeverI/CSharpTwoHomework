using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.GetMaxMethod
{
    class GetMaxMethod
    {
        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter integer 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter integer 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter integer 3: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest is: {0}", GetMax(GetMax(n1, n2), n3));
        }
    }
}
