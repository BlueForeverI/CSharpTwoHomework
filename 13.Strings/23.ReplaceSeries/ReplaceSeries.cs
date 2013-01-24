using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23.ReplaceSeries
{
    class ReplaceSeries
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = input.Length;

            StringBuilder replaced = new StringBuilder();
            for(int i = 0; i < length - 1; i ++)
            {
                if(input[i] != input[i + 1])
                {
                    replaced.Append(input[i]);
                }
            }

            replaced.Append(input[length - 1]);

            Console.WriteLine("All series were replaced: {0}", replaced.ToString());
        }
    }
}
