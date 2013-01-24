using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.DifferentLetters
{
    class DifferentLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in input.ToLower())
            {
                if(letter >= 'a' && letter <= 'z')
                {
                    if(occurences.ContainsKey(letter))
                    {
                        occurences[letter]++;
                    }
                    else
                    {
                        occurences.Add(letter, 1);
                    }
                }
            }

            Console.WriteLine("Different letters: ");
            foreach (var occurence in occurences)
            {
                Console.WriteLine("{0} -> {1} times", occurence.Key, occurence.Value);
            }
        }
    }
}
