using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            for(int i = 0; i < size; i ++)
            {
                Console.Write("Enter array1[{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write("nEnter array2[{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write("array1[{0}] ", i);
                string sign = "=";
                if(array1[i] > array2[i])
                {
                    sign = ">";
                }
                else if(array1[i] < array2[i])
                {
                    sign = "<";
                }

                Console.Write(sign);
                Console.Write(" array2[{0}]\n", i);
            }

            Console.ReadLine();
        }
    }
}
