using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.RemoveListedWords
{
    class RemoveListedWords
    {
        static void Main(string[] args)
        {
            string fileName = "..\\..\\file.txt";
            try
            {
                string content = File.ReadAllText(fileName);
                string[] words = File.ReadAllLines("..\\..\\wordList.txt");

                string newContent = content;
                foreach (var word in words)
                {
                    newContent = Regex.Replace(newContent, string.Format("\\s{0}[\\s\\.\\?!;:,]", word), " ");
                }

                File.WriteAllText(fileName, newContent);
                Console.WriteLine("Words removed successfully!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception of type {0}: {1}", ex.GetType(), ex.Message);
            }
        }
    }
}
