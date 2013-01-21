using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _2.ConcatFiles
{
    class ConcatFiles
    {
        static void Main(string[] args)
        {
            string firstContent = File.ReadAllText("..\\..\\file1.txt");
            string secondContent = File.ReadAllText("..\\..\\file2.txt");
            File.WriteAllText("..\\..\\resultFile.txt", firstContent + secondContent);
            Console.WriteLine("The two files were concatenated.");
        }
    }
}
