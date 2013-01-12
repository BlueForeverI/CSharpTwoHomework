using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.SumOfSequence
{
    class SumOfSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers: ");
            string sequence = Console.ReadLine();
            int sum = (from n in sequence.Split(' ')
                             select int.Parse(n)).ToArray().Sum();

            Console.WriteLine("The sum of {0} is {1}", sequence, sum);
            Console.ReadLine(); 
        }
    }
}
