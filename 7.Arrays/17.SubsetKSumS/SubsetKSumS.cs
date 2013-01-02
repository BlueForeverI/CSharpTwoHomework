using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.SubsetKSumS
{
    class SubsetKSumS
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());


            Console.Write("Enter S: ");
            int S = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxCombinations = (int)Math.Pow(2, N);
            List<int> result = new List<int>();

            for (int i = 0; i < maxCombinations; i++)
            {
                string binaryString = new string(Convert.ToString(i, 2).Reverse().ToArray());
                List<int> subset = new List<int>();

                for (int j = 0; j < binaryString.Length; j++)
                {
                    if (binaryString[j] == '1')
                    {
                        subset.Add(array[j]);
                    }
                }

                if (subset.Sum() == S && subset.Count == K)
                {
                    result = new List<int>(subset);
                    break;
                }
            }

            if (result.Count() == 0)
            {
                Console.WriteLine("No such subset");
            }
            else
            {
                Console.WriteLine("Yes ({0})", string.Join("+", result));
            }
        }
    }
}
