using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.Combinations
{
    class Combinations
    {
        static List<List<int>> FindCombinations(int N, int K)
        {
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = i + 1;
            }

            int maxCount = (int)Math.Pow(2, N);
            List<List<int>> combinations = new List<List<int>>();

            for (int i = 0; i < maxCount; i++)
            {
                string binaryString = new string(Convert.ToString(i, 2).Reverse().ToArray());
                if (binaryString.Count(c => c == '1') == K)
                {
                    List<int> combination = new List<int>();
                    for (int j = 0; j < binaryString.Length; j++)
                    {
                        if (binaryString[j] == '1')
                        {
                            combination.Add(numbers[j]);
                        }
                    }

                    combinations.Add(combination);
                }
            }

            return combinations;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            var variations = FindCombinations(N, K);
            foreach (var variation in variations)
            {
                Console.WriteLine(string.Join(", ", variation));
            }
        }
    }
}
