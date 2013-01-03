using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.RemoveToSort
{
    static class RemoveToSort
    {
        public static bool IsSorted<T>(this IEnumerable<T> @this, Comparison<T> comparison = null)
        {
            if (comparison == null)
                comparison = Comparer<T>.Default.Compare;

            using (IEnumerator<T> e = @this.GetEnumerator())
            {
                if (!e.MoveNext())
                    return true;

                T prev = e.Current;
                while (e.MoveNext())
                {
                    T current = e.Current;
                    if (comparison(prev, current) > 0)
                        return false;

                    prev = current;
                }
            }
            return true;
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

            int maxCombinations = (int) Math.Pow(2, size);
            List<int> sorted = new List<int>();

            for(int i = 0; i < maxCombinations; i ++)
            {
                string binaryString = new string(Convert.ToString(i, 2).Reverse().ToArray());
                List<int> numbers = new List<int>(array);

                for(int j = 0; j < binaryString.Length; j ++)
                {
                    if(binaryString[j] == '1')
                    {
                        numbers.Remove(array[j]);
                    }
                }

                if(numbers.IsSorted() && numbers.Count > sorted.Count)
                {
                    sorted = new List<int>(numbers);
                }
            }

            Console.WriteLine("Sorted: [{0}]", string.Join(", ", sorted));
        }
    }
}
