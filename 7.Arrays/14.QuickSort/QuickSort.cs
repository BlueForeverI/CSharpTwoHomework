using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.QuickSort
{
    class QuickSort
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

            int[] sorted = QuickSortArray(array, 0, size - 1);
            Console.WriteLine("Sorted: {0}", string.Join(", ", sorted));
        }

        private static int[] QuickSortArray(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right)/2];

            while(i <= j)
            {
                while(arr[i] < pivot)
                {
                    i++;
                }

                while(arr[j] > pivot)
                {
                    j--;
                }

                if(i <= j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            if(left < j)
            {
                arr = QuickSortArray(arr, left, j);
            }

            if(i < right)
            {
                arr = QuickSortArray(arr, i, right);
            }

            return arr;
        }
    }
}
