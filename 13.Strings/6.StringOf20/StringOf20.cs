using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.StringOf20
{
    class StringOf20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            if(input.Length > 20)
            {
                Console.WriteLine("The string should now be longer than 20 characters");
                return;
            }

            string suffix = new string('*', 20 - input.Length);
            input += suffix;
            Console.WriteLine("The result: {0}", input);
        }
    }
}
