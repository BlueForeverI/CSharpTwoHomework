using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.LetterIndex
{
    class LetterIndex
    {
        static void Main(string[] args)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            foreach (var letter in word)
            {
                Console.WriteLine("'{0}' -> {1}", letter, Array.IndexOf(letters, Char.ToUpper(letter)));
            }

            Console.ReadLine();
        }
    }
}
