using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortByStringLength
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            Console.Write("size = ");
            int size = int.Parse(Console.ReadLine());

            string[] array = new string[size];
            for(int i = 0; i < size; i ++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Console.ReadLine();
            }

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Sorted array: {0}", String.Join(", ", array));
            Console.ReadLine();
        }
    }
}
