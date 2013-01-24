using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = ".NET – platform for applications from Microsoft\n" +
                                "CLR – managed execution environment for .NET\n" +
                                "namespace – hierarchical organization of classes\n" +
                                "CTS – common type system\n" +
                                "method – piece of code that describes class actions\n";

            Console.Write("Enter a word to search: ");
            string word = Console.ReadLine();
            string explanation = "";

            foreach(string line in dictionary.Split(new char[]{'\n'}, StringSplitOptions.RemoveEmptyEntries))
            {
                if(line.Substring(0, word.Length) == word)
                {
                    explanation = line.Split(new string[] {" – "}, StringSplitOptions.RemoveEmptyEntries)[1];
                }
            }

            if(explanation == "")
            {
                Console.WriteLine("Explanation not found!");
            }
            else
            {
                Console.WriteLine("Explanation: {0}", explanation);
            }
        }
    }
}
