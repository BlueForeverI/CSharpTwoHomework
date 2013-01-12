using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.PrintRandomNumbers
{
    class PrintRandomNumbers
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            for(int i = 0; i < 10; i ++)
            {
                Console.WriteLine(generator.Next(99, 199));
            }

            Console.ReadLine();
        }
    }
}
