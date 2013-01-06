using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.GenericSetMethods
{
    static class GenericSetMethods
    {
        static T Minimum<T>(params T[] nums) 
        {
            return nums.Min();
        }

        static T Maximum<T>(params T[] nums)
        {
            return nums.Max();
        }

        static T Average<T>(params T[] nums)
        {
            dynamic sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum/nums.Length;
        }

        static T Sum<T>(params T[] nums)
        {
            dynamic sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static T Product<T>(params T[] nums)
        {
            dynamic product = 1;
            foreach (var num in nums)
            {
                product *= num;
            }

            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The sequence is 12.5, 13.3, 14.9, 17.43, 19,11");
            Console.WriteLine("The minimum is: {0}", Minimum(12.5, 13.3, 14.9, 17.43, 19, 11));
            Console.WriteLine("The maximum is: {0}", Maximum(12.5, 13.3, 14.9, 17.43, 19, 11));
            Console.WriteLine("The average is: {0}", Average(12.5, 13.3, 14.9, 17.43, 19, 11));
            Console.WriteLine("The sum is: {0}", Sum(12.5, 13.3, 14.9, 17.43, 19, 11));
            Console.WriteLine("The product is: {0}", Product(12.5, 13.3, 14.9, 17.43, 19, 11));
        }
    }
}
