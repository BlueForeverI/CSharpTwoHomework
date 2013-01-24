using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.ExtractPalindromes
{
    class ExtractPalindromes
    {
        static bool IsPalindrome(string s)
        {
            if(s.Length == 1)
            {
                return false;
            }

            for(int i = 0; i < s.Length / 2; i ++)
            {
                if(s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string text = "A palindrome is a word, phrase, number, or other sequence of " +
                          "units that may be read the same way in either direction. For example, " +
                          "ABBA and mom are palindromes, and so is exe. Adam, however is not.";

            Console.WriteLine("Text: {0}\n", text);

            string[] words = text.Split(new char[] {' ', ',', '.', ';', ':', '!', '?', '-'},
                                                  StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Palindromes: ");
            foreach (var word in words)
            {
                if(IsPalindrome(word.ToLower()))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
