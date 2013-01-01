using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for(int i = 0; i < array.Length; i ++)
            {
                array[i] = i*5;
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
        }
    }
}
