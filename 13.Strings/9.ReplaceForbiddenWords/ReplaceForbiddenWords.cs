using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.ReplaceForbiddenWords
{
    class ReplaceForbiddenWords
    {
        static void Main(string[] args)
        {
            string text =
                "Microsoft announced its next generation PHP compiler today. "
                + "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbidden = {"PHP", "CLR", "Microsoft", "is"};
            string replaced = text;

            foreach (var word in forbidden)
            {
                replaced = replaced.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine("Original text:\n{0}\n", text);
            Console.WriteLine("Replaced the words {0}", string.Join(", ", forbidden));
            Console.WriteLine("The result:");
            Console.WriteLine(replaced);
        }
    }
}
