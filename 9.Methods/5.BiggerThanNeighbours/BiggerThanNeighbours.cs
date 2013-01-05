using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BiggerThanNeighbours
{
    public class BiggerThanNeighbours
    {
        public static bool IsBiggerThanNeighbours(int[] array, int index)
        {
            if(index >= array.Length - 1 || index <= 0)
            {
                return false;
            }

            return (array[index] > array[index - 1] && array[index] > array[index + 1])
                       ? true
                       : false;
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

            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("The element at index {0} is {1}bigger than its two neighbours",
                index, (IsBiggerThanNeighbours(array, index) ? "" : "not "));
        }
    }
}
