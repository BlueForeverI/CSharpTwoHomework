using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3.AddLineNumbers
{
    class AddLineNumbers
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("..\\..\\input.txt");
            using (FileStream stream = new FileStream("..\\..\\output.txt", FileMode.OpenOrCreate))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    for(int i = 0; i < lines.Length; i ++)
                    {
                        writer.WriteLine("{0}.{1}", i + 1, lines[i]);
                    }
                }
            }

            Console.WriteLine("Lines numbers added successfully!");
        }
    }
}
