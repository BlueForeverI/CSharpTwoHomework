using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.IntegerSetMethods
{
    class IntegerSetMethods
    {
        static int Minimum(params int[] nums)
        {
            return nums.Min();
        }

        static int Maximum(params int[] nums)
        {
            return nums.Max();
        }

        static double Average(params int[] nums)
        {
            return nums.Average();
        }

        static int Sum(params int[] nums)
        {
            return nums.Sum();
        }

        static long Product(params int[] nums)
        {
            long product = 1;

            foreach (var num in nums)
            {
                product *= num;
            }

            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The sequence is 2, 3 ,5, 7, 13");
            Console.WriteLine("Minimum: {0}", Minimum(2, 3, 5, 7, 13));
            Console.WriteLine("Maximum: {0}", Maximum(2, 3, 5, 7, 13));
            Console.WriteLine("Average: {0}", Average(2, 3, 5, 7, 13));
            Console.WriteLine("Sum: {0}", Sum(2, 3, 5, 7, 13));
            Console.WriteLine("Product: {0}", Product(2, 3, 5, 7, 13));
        }
    }
}
