using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _1.PrintOddLines
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("..\\..\\input.txt");
            for(int i = 0; i < lines.Length; i ++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
    }
}
