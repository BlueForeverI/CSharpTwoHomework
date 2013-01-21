using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _6.SortStrings
{
    class SortStrings
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("..\\..\\input.txt");
            List<string> sorted = new List<string>(lines);
            sorted.Sort();
            
            using(FileStream stream = new FileStream("..\\..\\output.txt", FileMode.OpenOrCreate))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (var line in sorted)
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Sorted lines saved to file output.txt");
        }
    }
}
