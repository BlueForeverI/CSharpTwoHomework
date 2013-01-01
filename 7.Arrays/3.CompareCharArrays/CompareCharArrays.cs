using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            char[] array1 = new char[size];
            char[] array2 = new char[size];

            for(int i = 0; i < size; i ++)
            {
                Console.Write("Enter array1[{0}]: ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write("nEnter array2[{0}]: ", i);
                array2[i] = char.Parse(Console.ReadLine());
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
