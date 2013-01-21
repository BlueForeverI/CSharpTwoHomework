using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _8.ReplaceWords
{
    class ReplaceWords
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\file.txt";
            string content = File.ReadAllText(filePath);
            string newContent = content.Replace(" start ", " finish ").Replace(" start,", " finish,")
                .Replace(" start.", " finish.").Replace(" start\r\n", " finish\r\n").Replace(" start?", " finish?")
                .Replace(" start!", " finish!").Replace(" start:", " finish:").Replace(" start;", " finish;");
            File.WriteAllText(filePath, newContent);

            Console.WriteLine("Substring replaced successfully!");
        }
    }
}
