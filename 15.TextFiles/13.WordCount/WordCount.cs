using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _13.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            try
            {
                string[] words = File.ReadAllLines("..\\..\\words.txt");
                string[] content =
                    File.ReadAllText("..\\..\\test.txt").ToLower().Split(new char[] {' ', ',', '.', '!', '\n', '?'},
                                                                         StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> occurences = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    occurences.Add(word, 0);
                }

                foreach (var word in content)
                {
                    if (words.Contains(word))
                    {
                        occurences[word]++;
                    }
                }

                var wordList = occurences.ToList();
                wordList.Sort((x, y) => y.Value.CompareTo(x.Value));
                StringBuilder sb = new StringBuilder();
                foreach (var keyValuePair in wordList)
                {
                    sb.AppendLine(string.Format("{0} -> {1} times", keyValuePair.Key,
                                                keyValuePair.Value));
                }

                File.WriteAllText("..\\..\\result.txt", sb.ToString());
                Console.WriteLine("Words counted successfully!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception of type {0}: {1}", ex.GetType(), ex.Message);
            }
        }
    }
}
