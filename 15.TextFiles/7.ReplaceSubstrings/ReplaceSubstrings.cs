using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _7.ReplaceSubstrings
{
    class ReplaceSubstrings
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\file.txt";
            string content = File.ReadAllText(filePath);
            File.WriteAllText(filePath, content.Replace("start", "finish"));

            Console.WriteLine("Substring replaced successfully!");
        }
    }
}
