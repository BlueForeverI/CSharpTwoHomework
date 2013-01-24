using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24.SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of words, separated by space:");
            string[] words = Console.ReadLine().Split(new char[] {' '},
                                                      StringSplitOptions.RemoveEmptyEntries);
            List<string> sorted = new List<string>(words);
            sorted.Sort();

            Console.WriteLine("Words in alphabetical order: {0}",
                string.Join(",", sorted));
        }
    }
}
