using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            char[] symbols = {' ', '.', ',', '!', '?', ';', ':', '-'};
            string[] words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);

            var symbolPositions = new Dictionary<int, char>();
            int index = 0;
            string trimmed = text.Replace(" ", "");
            int wordIndex = 0;

            foreach (var word in words)
            {
                index += word.Length;
                if(symbols.Contains(trimmed[index]))
                {
                    symbolPositions.Add(wordIndex, trimmed[index]);
                    index += 1;
                }

                wordIndex++;
            }

            StringBuilder sb = new StringBuilder();
            words = words.Reverse().ToArray();
            for(int i = 0; i < words.Length; i ++)
            {
                sb.Append(words[i]);
                if(symbolPositions.Any(p => p.Key == i))
                {
                    sb.Append(symbolPositions[i]);
                }

                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
