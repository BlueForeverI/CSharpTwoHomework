using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string text =
                "We are living in a yellow submarine. We don't have anything else." 
                + " Inside the submarine is very tight. So we are drinking all the day." 
                + " We will move out of it in 5 days.";

            string word = "in";
            string[] sentences = text.Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(new char[] {' ', ',', ':', ';', '-'});
                if(words.Contains(word))
                {
                    result.Add(sentence.Trim());
                }
            }

            Console.WriteLine("Sentences that contain '{0}':", word);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
