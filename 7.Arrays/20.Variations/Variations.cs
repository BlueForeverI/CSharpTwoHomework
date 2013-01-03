using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.Variations
{
    class Variations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            List<int> input = new List<int>();
            for(int i = 0; i < N; i ++)
            {
                input.Add(i + 1);
            }

            FindVariations(input, K, new List<int>());
        }

        private static void FindVariations(List<int> input, int depth, List<int> output)
        {
            if(depth == 0)
            {
                Console.WriteLine(string.Join(", ", output));
            }
            else
            {
                for(int i = 0; i < input.Count; i ++)
                {
                    output.Add(input[i]);
                    FindVariations(input, depth - 1, output);
                    output.RemoveAt(output.Count - 1);
                }
            }
        }
    }
}
