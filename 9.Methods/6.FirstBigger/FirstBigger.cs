using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _5.BiggerThanNeighbours;

namespace _6.FirstBigger
{
    class FirstBigger
    {
        static int GetFirstBiggerIndex(int[] array)
        {
            for(int i = 1; i < array.Length - 1; i ++)
            {
                if(BiggerThanNeighbours.IsBiggerThanNeighbours(array, i))
                {
                    return i;
                }
            }

            return -1;
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

            Console.WriteLine("The first element that is bigger than its two neighbours has index {0}",
                GetFirstBiggerIndex(array));
        }
    }
}
