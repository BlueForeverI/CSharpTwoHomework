using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            const long MAX = 10000000;
            List<long> numbers = new List<long>();
            for(long i = 2; i <= MAX; i ++)
            {
                numbers.Add(i);
            }

            double stop = Math.Sqrt((double)MAX);

            for(long i = 2; i <= stop; i ++)
            {
                if(!numbers.Contains(i))
                {
                    continue;
                }

                for(long toRemove = 2 * i; toRemove < MAX + 1; toRemove += i)
                {
                    numbers.Remove(toRemove);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
            Console.ReadLine();
        }
    }
}
