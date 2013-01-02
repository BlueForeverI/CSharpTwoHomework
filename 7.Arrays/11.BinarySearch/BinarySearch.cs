using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for(int i = 0; i < size; i ++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter element to search: ");
            int element = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int index = BinarySearchElement(array, element, 0, size - 1);
            Console.WriteLine("The index of {0} is {1}", element, index);
        }

        private static int BinarySearchElement(int[] array, int element, int min, int max)
        {
            if(max <= min)
            {
                return -1;
            }

            int mid = min + ((max - min)/2);
            if(array[mid] > element)
            {
                return BinarySearchElement(array, element, min, mid - 1);
            }
            else if(array[mid] < element)
            {
                return BinarySearchElement(array, element, mid + 1, max);
            }
            else
            {
                return mid;
            }
        }
    }
}
