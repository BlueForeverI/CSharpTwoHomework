using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _11.DeleteWordsWithPrefix
{
    class DeleteWordsWithPrefix
    {
        static void Main(string[] args)
        {
            string fileName = "..\\..\\file.txt";
            string content = File.ReadAllText(fileName);
            string newContent = Regex.Replace(content, "test[A-Za-z0-9]+", "");
            File.WriteAllText(fileName, newContent);

            Console.WriteLine("The words have been deleted!");
        }
    }
}
