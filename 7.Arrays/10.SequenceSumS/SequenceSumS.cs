using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SequenceSumS
{
    class SequenceSumS
    {
        static void Main(string[] args)
        {
            Console.Write("Enter S: ");
            int S = int.Parse(Console.ReadLine());

            Console.Write("Enter sequence length: ");
            int N = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for(int i = 0; i < N; i ++)
            {
                Console.Write("Enter element {0}: ", i);
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            List<int> result = new List<int>(); for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= i; j--)
                {
                    List<int> sequence = new List<int>();
                    for (int k = i; k <= j; k++)
                    {
                        sequence.Add(numbers[k]);
                    }
                    
                    if(sequence.Sum() == S)
                    {
                        result = new List<int>(sequence);
                        break;
                    }
                }
            }
            

            if(result.Count == 0)
            {
                Console.WriteLine("No such sequence");
            }
            else
            {
                Console.WriteLine("[{0}] -> {1}", string.Join(", ", result), S);
            }
        }
    }
}
