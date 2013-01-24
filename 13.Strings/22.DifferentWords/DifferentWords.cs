using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.DifferentWords
{
    class DifferentWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();


            string[] words = input.ToLower().Split(new char[] { ' ', ',', '.', ';', ':', '!', '?', '-' },
                                                  StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(occurences.ContainsKey(word))
                {
                    occurences[word]++;
                }
                else
                {
                    occurences.Add(word, 1);
                }
            }

            Console.WriteLine("Different words: ");
            foreach (var occurence in occurences)
            {
                Console.WriteLine("{0} -> {1} times", 
                    occurence.Key, occurence.Value);
            }
        }
    }
}
