using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i = 0; i < N; i ++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int number = array.LastOrDefault(x => x <= K);
            int index = Array.BinarySearch(array, number);

            Console.WriteLine("The largest number in the array that is <= {0} is {1}",
                K, array[index]);
            Console.ReadLine();
        }
    }
}
