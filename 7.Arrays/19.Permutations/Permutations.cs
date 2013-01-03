using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Permutations
{
    class Permutations
    {
        public static List<List<int>> FindPermutations(int n)
        {
            int[] numbers = new int[n];
            for(int i = 0; i < n; i ++)
            {
                numbers[i] = i + 1;
            }

            List<List<int>> perms = new List<List<int>>();
            int factorial = 1;

            for(int i = 2; i <= n; i ++)
            {
                factorial *= i;
            }

            for(int i = 0; i < factorial; i ++)
            {
                List<int> set = new List<int>(numbers);
                int k = i;

                for(int j = 2; j <= n; j ++)
                {
                    int other = (k % j);
                    int tmp = set[j - 1];
                    set[j - 1] = set[other];
                    set[other] = tmp;

                    k = k/j;
                }

                perms.Add(set);
            }

            return perms;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            var permutations = FindPermutations(N);
            foreach (var permutation in permutations)
            {
                Console.WriteLine(string.Format("[{0}]", string.Join(", ", permutation)));
            }
        }
    }
}
