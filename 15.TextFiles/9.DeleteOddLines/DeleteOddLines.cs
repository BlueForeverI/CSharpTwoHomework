using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _9.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\file.txt";
            string[] lines = File.ReadAllLines(filePath);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < lines.Length; i ++)
            {
                if(i % 2 == 1)
                {
                    sb.AppendLine(lines[i]);
                }
            }

            File.WriteAllText(filePath, sb.ToString());
            Console.WriteLine("Odd lines deleted!");
        }
    }
}
