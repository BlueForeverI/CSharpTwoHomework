using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.FindMaxInRange
{
    class FindMaxInRange
    {
        static int GetMax(int[] array, int index)
        {
            int max = int.MinValue;
            for(int i = index; i < array.Length; i ++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int[] SortArray(int[] array, bool ascending = true)
        {
            List<int> numbers = array.ToList();
            List<int> sorted = new List<int>();

            for (int i = 0; i < numbers.Count; i ++)
            {
                int max = GetMax(numbers.ToArray(), i);
                sorted.Add(max);

                int maxIndex = numbers.IndexOf(max, i);
                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }

            if(ascending)
            {
                sorted.Reverse();
            }

            return sorted.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sorted array in ascending order: {0}",
                string.Join(", ", SortArray(array, true)));

            Console.WriteLine("The sorted array in descending order: {0}",
                string.Join(", ", SortArray(array, false)));
        }
    }
}
