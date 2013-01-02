using System;

namespace _13.MergeSort
{
    class MergeSort
    {
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

            int[] sorted = MergeSortArray(array);
            Console.WriteLine("Sorted: {0}", string.Join(", ", sorted));
        }

        private static int[] MergeSortArray(int[] array)
        {
            if(array.Length == 1)
            {
                return array;
            }

            int middle = array.Length/2;

            int[] left = new int[middle];
            for(int i = 0; i < middle; i ++)
            {
                left[i] = array[i];
            }

            int[] right = new int[array.Length - middle];
            for(int i = 0; i < array.Length - middle; i++)
            {
                right[i] = array[i + middle];
            }

            left = MergeSortArray(left);
            right = MergeSortArray(right);

            int l = 0;
            int r = 0;

            int[] sorted = new int[array.Length];
            for(int i = 0; i < array.Length; i ++)
            {
                if(l < left.Length && r < right.Length)
                {
                    if(left[l] < right[r])
                    {
                        sorted[i] = left[l++];
                    }
                    else
                    {
                        sorted[i] = right[r++];
                    }
                }
                else
                {
                    if(l < left.Length)
                    {
                        sorted[i] = left[l++];
                    }
                    else
                    {
                        sorted[i] = right[r++];
                    }
                }
            }

            return sorted;
        }
    }
}
