using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MostFrequentNumber
{
    class MostFrequentNumber
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

            Dictionary<int, int> occurences = new Dictionary<int, int>();
            for(int i = 0; i < size; i ++)
            {
                if(occurences.ContainsKey(array[i]))
                {
                    occurences[array[i]]++;
                }
                else
                {
                    occurences.Add(array[i], 1);
                }
            }

            List<KeyValuePair<int, int>> sorted = occurences.ToList();
            sorted.Sort((x, y) => x.Value.CompareTo(y.Value));
            Console.WriteLine("The most frequent number is {0} -> {1} times", 
                sorted.Last().Key, sorted.Last().Value);
            Console.ReadLine();
        }
    }
}
