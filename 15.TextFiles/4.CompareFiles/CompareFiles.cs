using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _4.CompareFiles
{
    class CompareFiles
    {
        static void Main(string[] args)
        {
            string[] firstLines = File.ReadAllLines("..\\..\\file1.txt");
            string[] secondLines = File.ReadAllLines("..\\..\\file2.txt");
            int sameCount = 0;
            int differentCount = 0;

            for(int i = 0; i < firstLines.Length; i ++)
            {
                if(firstLines[i] == secondLines[i])
                {
                    sameCount++;
                }
                else
                {
                    differentCount++;
                }
            }

            Console.WriteLine("Same lines: {0}", sameCount);
            Console.WriteLine("Different lines: {0}", differentCount);
        }
    }
}
