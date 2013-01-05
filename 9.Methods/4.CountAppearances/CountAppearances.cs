using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CountAppearances
{
    class CountAppearances
    {
        static int GetAppearanceCount(int[] array, int number)
        {
            int count = 0;
            foreach (var i in array)
            {
                if(i == number)
                {
                    count++;
                }
            }

            return count;
        }

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

            Console.Write("Enter a number to find: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number appears {0} times", GetAppearanceCount(array, number));
        }
    }
}
