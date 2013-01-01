using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MaxSumOfK
{
    class MaxSumOfK
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            List<int> numbers = new List<int>(array);
            numbers.Sort();
            List<int> result = new List<int>();
            for(int i = N - K; i < N; i ++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine("[{0}] -> {1}", string.Join(", ", result), result.Sum());
        }
    }
}
