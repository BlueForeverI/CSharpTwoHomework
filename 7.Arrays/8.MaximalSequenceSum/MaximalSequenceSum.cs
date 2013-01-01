using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.MaximalSequenceSum
{
    class MaximalSequenceSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<List<int>, int> occurences = new Dictionary<List<int>, int>();
            for(int i = 0; i < size; i ++)
            {
                for(int j = size - 1; j >= i; j --)
                {
                    List<int> sequence = new List<int>();
                    for(int k = i; k <= j; k++)
                    {
                        sequence.Add(array[k]);
                    }

                    int sum = sequence.Sum();
                    occurences.Add(sequence, sum);
                }
            }

            var sorted = occurences.ToList();
            sorted.Sort((x, y) => x.Value.CompareTo(y.Value));
            Console.WriteLine();
            Console.WriteLine("The sequest with the biggest sum is {0} -> {1},",
                String.Join(", ", sorted.Last().Key), sorted.Last().Value);
        }
    }
}
