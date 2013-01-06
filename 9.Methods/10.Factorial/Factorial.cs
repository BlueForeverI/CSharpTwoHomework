using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _10.Factorial
{
    class Factorial
    {
        static BigInteger CalculateFactorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n*CalculateFactorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n! = {0}", CalculateFactorial(n));
        }
    }
}
