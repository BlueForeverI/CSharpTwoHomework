using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Resize(ref array, array.Length + 1);
            var tempList = new List<int>();
            var longestList = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempList.Add(array[i]);
                }
                else
                {
                    tempList.Add(array[i]);
                    if (tempList.Count > longestList.Count)
                    {
                        longestList = tempList;

                    }

                    tempList = new List<int>();
                }
            }

            Console.WriteLine("The maximal sequence is {0}", String.Join(", ", longestList.ToArray()));
            Console.ReadLine();
        }
    }
}
