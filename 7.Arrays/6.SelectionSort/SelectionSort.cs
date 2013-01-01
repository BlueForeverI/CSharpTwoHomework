using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.SelectionSort
{
    class SelectionSort
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

            for(int i = 0; i < size; i ++)
            {
                int smallestIndex = i;

                for(int j = i + 1; j < size; j ++)
                {
                    if(array[j] < array[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                int temp = array[smallestIndex];
                array[smallestIndex] = array[i];
                array[i] = temp;
            }

            Console.WriteLine("\nThe sorted array: {0}", String.Join(", ", array));
            Console.ReadLine();
        }
    }
}
